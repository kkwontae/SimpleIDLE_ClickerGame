using SampleIDLE.Controllers;
using SampleIDLE.Formatters;
using SampleIDLE.Generators;
using System.Drawing;
using System.Reflection;
//using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace SampleIDLE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            SetDefaultValues();
            CreateGeneratorMap();
            SetBonusMultiplier();

            InitializeTimer();

#if DEBUG
            lbl_Debug.Visible = true;
#else
            lbl_Debug.Visible = false;
#endif
        }

        static readonly Dictionary<string, Generator> GeneratorMap = new();
        static double Currency = 0;
        static long PlaytimeTick = 0;
        static bool IsInterrupted = false;

        private class DefaultValue
        {
            public static double StartCurrency { get; set; }
            public static int RefreshScreenTicks { get; set; }
        }

        void SetDefaultValues()
        {
            DefaultValue.StartCurrency = 10;
            DefaultValue.RefreshScreenTicks = 50;

            Currency = DefaultValue.StartCurrency;
        }

        void SetBonusMultiplier()
        {
            BonusController.SetBonusGlobal(GeneratorMap, 0);
            BonusController.SetBonusGlobalAchivement(GeneratorMap, 1);
            BonusController.SetBonusEventBuff(GeneratorMap, 0);
        }

        void CreateGeneratorMap()
        {
            GeneratorMap.Add("Basic0", new BasicA());
            GeneratorMap.Add("Basic1", new BasicB());
            GeneratorMap.Add("Basic2", new BasicC());
            GeneratorMap.Add("Basic3", new BasicD());
            GeneratorMap.Add("Basic4", new BasicE());

            GeneratorController.SetNumberToBuyForAllGenerators(GeneratorMap, 1);
            //GeneratorController.SetGlobalBonus(30);

            for (int i = 0; i< GeneratorMap.Count; i++)
            {
                Button _btn_Do = (Button)this.Controls["pnl_Generators"].Controls["grp_Basic" + i].Controls["btn_Do" + i];
                _btn_Do.Click += btn_Do_Click;
            }
        }

        void InitializeTimer()
        {
            Thread Timers = new(new ThreadStart(delegate
            {
                while (!IsInterrupted)
                {
                    int delay = DefaultValue.RefreshScreenTicks;
                    Currency += GeneratorController.GetTotalIncomePerSecond(GeneratorMap) / (1000 / delay);
                    PlaytimeTick += delay;
                    RefreshLabels();

                    Thread.Sleep(delay);
                }
                return;
            }));
            
            Timers.Start();
        }

        private void RefreshLabels()
        {
            //lbl_Debug.Text = GeneratorController.GetTotalIncomePerSecond(GeneratorMap).ToString();
            lbl_Coins.Text = $"{DoubleSpecifier.GetSpecifier(Currency)}";
            lbl_TotalIncome.Text = $"+{DoubleSpecifier.GetSpecifier(GeneratorController.GetTotalIncomePerSecond(GeneratorMap))}/s";

            lbl_Debug.Text = new TimeSpan(PlaytimeTick*10000).ToString(@"hh\:mm\:ss\:fff");

            for (int i = 0; i < GeneratorMap.Count; i++)
            {
                try
                {
                    Generator generator = GeneratorMap["Basic" + i];

                    Label _lbl_Count    =  (Label)this.Controls["pnl_Generators"].Controls["grp_Basic" + i].Controls["lbl_Count" + i];
                    Label _lbl_Income   =  (Label)this.Controls["pnl_Generators"].Controls["grp_Basic" + i].Controls["lbl_Income" + i];
                    Button _btn_Do      = (Button)this.Controls["pnl_Generators"].Controls["grp_Basic" + i].Controls["btn_Do" + i];

                    double totalIncomePerSecond = GeneratorController.GetTotalIncomePerSecond(GeneratorMap);
                    double percentage = totalIncomePerSecond != 0 ?
                        (generator.Income / totalIncomePerSecond) :0;
                    int numberToBuy = generator.GetNumberToBuy(Currency);
                    
                    _lbl_Count.Text  = $"x{generator.Count}    x{DoubleSpecifier.GetSpecifier(generator.GetIncomeBonus())}   (전체({DoubleSpecifier.GetSpecifier(generator.Bonus.Global)}) + (업적({DoubleSpecifier.GetSpecifier(generator.Bonus.GlobalArchivement)}) x 구간({DoubleSpecifier.GetSpecifier(generator.Bonus.GeneratorMilestone)})) + 이벤트({DoubleSpecifier.GetSpecifier(generator.Bonus.EventBuff)})";
                    _lbl_Income.Text = $"+{DoubleSpecifier.GetSpecifier(generator.Income)}/s ({percentage:#0.##%})";

                    if (numberToBuy == 0)
                    {
                        _btn_Do.Text = $"+{1}\n{DoubleSpecifier.GetSpecifier(generator.GetCostForGenertors(1))}\n";
                    }
                    else
                    {
                        _btn_Do.Text = $"+{numberToBuy}\n{DoubleSpecifier.GetSpecifier(generator.GetCostForGenertors(numberToBuy))}\n";
                    }
                    
                    if (Currency >= generator.GetCostForGenertors(numberToBuy) &&
                        generator.GetCostForGenertors(numberToBuy) != 0)
                    {
                        _btn_Do.Enabled = true;
                    }
                    else
                    {
                        _btn_Do.Enabled = false;
                    }

                }
                catch(Exception e) { MessageBox.Show(e.ToString()); }
            }

        }
        private void btn_Do_Click(object? sender, EventArgs? e)
        {
            string generatorName = "Basic" + Regex.Match(((Button)sender!).Name,
                                                         @"\d+").Value;
            Generator generator = GeneratorMap[generatorName];
            
            if (generator.GetNumberToBuy(Currency) > 0)
            {
                double costSum = generator.GetCostForGenertors(generator.GetNumberToBuy(Currency));
                if (Currency >= costSum)
                {
                    generator.Upgrade(generator.GetNumberToBuy(Currency));
                    Currency -= costSum;
                }
            }
            else
            {
                int maxCount = generator.GetMaxNumberCanBuy(Currency);
                double costSum = GeneratorMap[generatorName ].GetCostForGenertors(maxCount);
                if (Currency >= costSum)
                {
                    generator.Upgrade(maxCount);
                    Currency -= costSum;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsInterrupted = true;
        }

        private void btn_NumberToBuy1_Click(object sender, EventArgs e)
        {
            GeneratorController.SetNumberToBuyForAllGenerators(GeneratorMap, 1);
        }

        private void btn_NumberToBuy10_Click(object sender, EventArgs e)
        {
            GeneratorController.SetNumberToBuyForAllGenerators(GeneratorMap, 10);
        }

        private void btn_NumberToBuy25_Click(object sender, EventArgs e)
        {
            GeneratorController.SetNumberToBuyForAllGenerators(GeneratorMap, 25);
        }

        private void btn_NumberToBuyAll_Click(object sender, EventArgs e)
        {
            GeneratorController.SetNumberToBuyForAllGenerators(GeneratorMap, -1);
        }
    }
}