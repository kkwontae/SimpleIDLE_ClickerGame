using SampleIDLE.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleIDLE.Generators
{
    
    internal class Generator
    {
        protected string _name = Guid.NewGuid().ToString();
        protected double _baseIncome;
        protected double _income = 0;
        protected double _startingCost;
        protected double _cost;
        protected double _costMultFactor;
        protected List<double> _bonusMultiplier = new();
        private BonusController.BonusType _bonusType = new();

        protected private int _count = 0;
        private int _numberToBuy = 1;
        private readonly List<int> _incomeMilestone = new() {25,50,100,200,300,400,500,600,1000};
        private readonly List<int> _incomeMilestoneBonus = new() { 1, 2, 3, 5, 2, 3, 4, 2, 3, 4 };

        public BonusController.BonusType Bonus { get => _bonusType; }
        public int Count { get => _count; set => _count = value; }
        public double Income { get => _income; /*set => _income = value;*/ }

        public int NumberToBuy
        {
            set { _numberToBuy = value; }
        }

        public int GetNumberToBuy(double coins)
        {
            return _numberToBuy > 0 ? _numberToBuy : GetMaxNumberCanBuy(coins);
        }

        public void Upgrade(int numberToBuy)
        {
            this._count += numberToBuy;
            this._income = this._baseIncome * this._count * GetIncomeBonus();
            this._cost = this._startingCost * Math.Pow(this._costMultFactor, this._count);
        }

        public double GetCostForGenertors(int count)
        {
            double cost = _startingCost * (Math.Pow(_costMultFactor, _count) - Math.Pow(_costMultFactor, _count + count)) / (1 - _costMultFactor);
            return cost;
        }

        public int GetMaxNumberCanBuy(double coins)
        {
            int max = (int)Math.Floor(Math.Log(Math.Pow(_costMultFactor, _count) - coins * (1 - _costMultFactor) / _startingCost, _costMultFactor) - _count);
            return max;
        }
        public int MilestoneBonus()
        {
            int countMilestone = _incomeMilestone.Where(x => x <= this._count).Count();
            return _incomeMilestoneBonus[countMilestone];
        }
        public double GetIncomeBonus()
        {
            int countMilestone = _incomeMilestone.Where(x => x <= this._count).Count();
            //_bonusType.GeneratorMilestone = _incomeMilestoneBonus[countMilestone];
            int tmp = 1;
            for (int i = 1; i <= countMilestone; i++)
            {
                tmp *= _incomeMilestoneBonus[i];
            }
            _bonusType.GeneratorMilestone = tmp;

            return _bonusType.Global + (_bonusType.GeneratorMilestone * _bonusType.GlobalArchivement) + _bonusType.EventBuff;
        }
    }

    /// <summary>
    /// Generator Properties
    /// <param name="_name">이름</param>
    /// <param name="_baseIncome">수익</param>
    /// <param name="_startingCost">최초 구매 비용</param>
    /// <param name="_cost">비용(최초 구매 비용으로 초기화)</param>
    /// <param name="_costMultFactor">비용 증가 배율</param>
    /// </summary>
    internal class BasicA : Generator
    {
        public BasicA()
        {
            base._name = "BasicA";
            base._baseIncome = 2;
            base._startingCost = 5;
            base._cost = base._startingCost;
            base._costMultFactor = 1.07;
        }
    }
    internal class BasicB : Generator
    {
        public BasicB()
        {
            base._name = "BasicB";
            base._baseIncome = 10;
            base._startingCost = 50;
            base._cost = base._startingCost;
            base._costMultFactor = 1.15;
        }
    }
    internal class BasicC : Generator
    {
        public BasicC()
        {
            base._name = "BasicC";
            base._baseIncome = 30;
            base._startingCost = 300;
            base._cost = base._startingCost;
            base._costMultFactor = 1.14;
        }
    }
    internal class BasicD : Generator
    {
        public BasicD()
        {
            base._name = "BasicD";
            base._baseIncome = 100;
            base._startingCost = 2500;
            base._cost = base._startingCost;
            base._costMultFactor = 1.13;
            base._count = 0;
        }
    }
    internal class BasicE : Generator
    {
        public BasicE()
        {
            base._name = "BasicE";
            base._baseIncome = 250;
            base._startingCost = 50000;
            base._cost = base._startingCost;
            base._costMultFactor = 1.12;
            base._count = 0;
        }
    }
}
