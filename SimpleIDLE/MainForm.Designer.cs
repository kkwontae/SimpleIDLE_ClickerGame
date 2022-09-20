namespace SampleIDLE
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Do0 = new System.Windows.Forms.Button();
            this.grp_Basic0 = new System.Windows.Forms.GroupBox();
            this.lbl_Count0 = new System.Windows.Forms.Label();
            this.lbl_Income0 = new System.Windows.Forms.Label();
            this.btn_Multiplier1 = new System.Windows.Forms.Button();
            this.lbl_Coins = new System.Windows.Forms.Label();
            this.grp_Status = new System.Windows.Forms.GroupBox();
            this.lbl_Debug = new System.Windows.Forms.Label();
            this.btn_MultiplierAll = new System.Windows.Forms.Button();
            this.btn_Multiplier25 = new System.Windows.Forms.Button();
            this.btn_Multiplier10 = new System.Windows.Forms.Button();
            this.lbl_TotalIncomeText = new System.Windows.Forms.Label();
            this.lbl_TotalIncome = new System.Windows.Forms.Label();
            this.grp_Basic1 = new System.Windows.Forms.GroupBox();
            this.lbl_Count1 = new System.Windows.Forms.Label();
            this.btn_Do1 = new System.Windows.Forms.Button();
            this.lbl_Income1 = new System.Windows.Forms.Label();
            this.grp_Basic2 = new System.Windows.Forms.GroupBox();
            this.lbl_Count2 = new System.Windows.Forms.Label();
            this.btn_Do2 = new System.Windows.Forms.Button();
            this.lbl_Income2 = new System.Windows.Forms.Label();
            this.grp_Basic3 = new System.Windows.Forms.GroupBox();
            this.lbl_Count3 = new System.Windows.Forms.Label();
            this.btn_Do3 = new System.Windows.Forms.Button();
            this.lbl_Income3 = new System.Windows.Forms.Label();
            this.grp_Basic4 = new System.Windows.Forms.GroupBox();
            this.lbl_Count4 = new System.Windows.Forms.Label();
            this.btn_Do4 = new System.Windows.Forms.Button();
            this.lbl_Income4 = new System.Windows.Forms.Label();
            this.pnl_Status = new System.Windows.Forms.Panel();
            this.pnl_Generators = new System.Windows.Forms.Panel();
            this.grp_Basic0.SuspendLayout();
            this.grp_Status.SuspendLayout();
            this.grp_Basic1.SuspendLayout();
            this.grp_Basic2.SuspendLayout();
            this.grp_Basic3.SuspendLayout();
            this.grp_Basic4.SuspendLayout();
            this.pnl_Status.SuspendLayout();
            this.pnl_Generators.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Do0
            // 
            this.btn_Do0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Do0.Enabled = false;
            this.btn_Do0.Location = new System.Drawing.Point(437, 41);
            this.btn_Do0.Name = "btn_Do0";
            this.btn_Do0.Size = new System.Drawing.Size(81, 41);
            this.btn_Do0.TabIndex = 0;
            this.btn_Do0.Text = "+0\r\n0.00e0\r\n";
            this.btn_Do0.UseVisualStyleBackColor = true;
            // 
            // grp_Basic0
            // 
            this.grp_Basic0.Controls.Add(this.lbl_Count0);
            this.grp_Basic0.Controls.Add(this.lbl_Income0);
            this.grp_Basic0.Controls.Add(this.btn_Do0);
            this.grp_Basic0.Location = new System.Drawing.Point(3, 3);
            this.grp_Basic0.Name = "grp_Basic0";
            this.grp_Basic0.Size = new System.Drawing.Size(524, 88);
            this.grp_Basic0.TabIndex = 2;
            this.grp_Basic0.TabStop = false;
            this.grp_Basic0.Text = "Basic-A";
            // 
            // lbl_Count0
            // 
            this.lbl_Count0.AutoSize = true;
            this.lbl_Count0.Location = new System.Drawing.Point(6, 25);
            this.lbl_Count0.Name = "lbl_Count0";
            this.lbl_Count0.Size = new System.Drawing.Size(20, 15);
            this.lbl_Count0.TabIndex = 2;
            this.lbl_Count0.Text = "x1";
            // 
            // lbl_Income0
            // 
            this.lbl_Income0.AutoSize = true;
            this.lbl_Income0.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Income0.Location = new System.Drawing.Point(6, 41);
            this.lbl_Income0.Name = "lbl_Income0";
            this.lbl_Income0.Size = new System.Drawing.Size(109, 30);
            this.lbl_Income0.TabIndex = 1;
            this.lbl_Income0.Text = "+0.00e0/s";
            // 
            // btn_Multiplier1
            // 
            this.btn_Multiplier1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Multiplier1.Location = new System.Drawing.Point(5, 77);
            this.btn_Multiplier1.Name = "btn_Multiplier1";
            this.btn_Multiplier1.Size = new System.Drawing.Size(124, 32);
            this.btn_Multiplier1.TabIndex = 3;
            this.btn_Multiplier1.Text = "x1";
            this.btn_Multiplier1.UseVisualStyleBackColor = true;
            this.btn_Multiplier1.Click += new System.EventHandler(this.btn_NumberToBuy1_Click);
            // 
            // lbl_Coins
            // 
            this.lbl_Coins.AutoSize = true;
            this.lbl_Coins.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Coins.Location = new System.Drawing.Point(6, 25);
            this.lbl_Coins.Name = "lbl_Coins";
            this.lbl_Coins.Size = new System.Drawing.Size(130, 50);
            this.lbl_Coins.TabIndex = 4;
            this.lbl_Coins.Text = "0.00e0";
            // 
            // grp_Status
            // 
            this.grp_Status.Controls.Add(this.lbl_Debug);
            this.grp_Status.Controls.Add(this.btn_MultiplierAll);
            this.grp_Status.Controls.Add(this.btn_Multiplier25);
            this.grp_Status.Controls.Add(this.btn_Multiplier10);
            this.grp_Status.Controls.Add(this.lbl_TotalIncomeText);
            this.grp_Status.Controls.Add(this.lbl_TotalIncome);
            this.grp_Status.Controls.Add(this.lbl_Coins);
            this.grp_Status.Controls.Add(this.btn_Multiplier1);
            this.grp_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Status.Location = new System.Drawing.Point(0, 0);
            this.grp_Status.Name = "grp_Status";
            this.grp_Status.Size = new System.Drawing.Size(552, 119);
            this.grp_Status.TabIndex = 5;
            this.grp_Status.TabStop = false;
            this.grp_Status.Text = "Status";
            // 
            // lbl_Debug
            // 
            this.lbl_Debug.AutoSize = true;
            this.lbl_Debug.Location = new System.Drawing.Point(403, 35);
            this.lbl_Debug.Name = "lbl_Debug";
            this.lbl_Debug.Size = new System.Drawing.Size(61, 15);
            this.lbl_Debug.TabIndex = 10;
            this.lbl_Debug.Text = "lbl_Debug";
            // 
            // btn_MultiplierAll
            // 
            this.btn_MultiplierAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MultiplierAll.Location = new System.Drawing.Point(416, 77);
            this.btn_MultiplierAll.Name = "btn_MultiplierAll";
            this.btn_MultiplierAll.Size = new System.Drawing.Size(124, 32);
            this.btn_MultiplierAll.TabIndex = 9;
            this.btn_MultiplierAll.Text = "All";
            this.btn_MultiplierAll.UseVisualStyleBackColor = true;
            this.btn_MultiplierAll.Click += new System.EventHandler(this.btn_NumberToBuyAll_Click);
            // 
            // btn_Multiplier25
            // 
            this.btn_Multiplier25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Multiplier25.Location = new System.Drawing.Point(279, 77);
            this.btn_Multiplier25.Name = "btn_Multiplier25";
            this.btn_Multiplier25.Size = new System.Drawing.Size(124, 32);
            this.btn_Multiplier25.TabIndex = 8;
            this.btn_Multiplier25.Text = "x25";
            this.btn_Multiplier25.UseVisualStyleBackColor = true;
            this.btn_Multiplier25.Click += new System.EventHandler(this.btn_NumberToBuy25_Click);
            // 
            // btn_Multiplier10
            // 
            this.btn_Multiplier10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Multiplier10.Location = new System.Drawing.Point(142, 77);
            this.btn_Multiplier10.Name = "btn_Multiplier10";
            this.btn_Multiplier10.Size = new System.Drawing.Size(124, 32);
            this.btn_Multiplier10.TabIndex = 7;
            this.btn_Multiplier10.Text = "x10";
            this.btn_Multiplier10.UseVisualStyleBackColor = true;
            this.btn_Multiplier10.Click += new System.EventHandler(this.btn_NumberToBuy10_Click);
            // 
            // lbl_TotalIncomeText
            // 
            this.lbl_TotalIncomeText.AutoSize = true;
            this.lbl_TotalIncomeText.Location = new System.Drawing.Point(201, 34);
            this.lbl_TotalIncomeText.Name = "lbl_TotalIncomeText";
            this.lbl_TotalIncomeText.Size = new System.Drawing.Size(77, 15);
            this.lbl_TotalIncomeText.TabIndex = 6;
            this.lbl_TotalIncomeText.Text = "Total Income";
            // 
            // lbl_TotalIncome
            // 
            this.lbl_TotalIncome.AutoSize = true;
            this.lbl_TotalIncome.Location = new System.Drawing.Point(285, 34);
            this.lbl_TotalIncome.Name = "lbl_TotalIncome";
            this.lbl_TotalIncome.Size = new System.Drawing.Size(55, 15);
            this.lbl_TotalIncome.TabIndex = 5;
            this.lbl_TotalIncome.Text = "+0.00e/s";
            // 
            // grp_Basic1
            // 
            this.grp_Basic1.Controls.Add(this.lbl_Count1);
            this.grp_Basic1.Controls.Add(this.btn_Do1);
            this.grp_Basic1.Controls.Add(this.lbl_Income1);
            this.grp_Basic1.Location = new System.Drawing.Point(3, 97);
            this.grp_Basic1.Name = "grp_Basic1";
            this.grp_Basic1.Size = new System.Drawing.Size(524, 88);
            this.grp_Basic1.TabIndex = 0;
            this.grp_Basic1.TabStop = false;
            this.grp_Basic1.Text = "Basic-B";
            // 
            // lbl_Count1
            // 
            this.lbl_Count1.AutoSize = true;
            this.lbl_Count1.Location = new System.Drawing.Point(6, 25);
            this.lbl_Count1.Name = "lbl_Count1";
            this.lbl_Count1.Size = new System.Drawing.Size(20, 15);
            this.lbl_Count1.TabIndex = 5;
            this.lbl_Count1.Text = "x1";
            // 
            // btn_Do1
            // 
            this.btn_Do1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Do1.Enabled = false;
            this.btn_Do1.Location = new System.Drawing.Point(437, 41);
            this.btn_Do1.Name = "btn_Do1";
            this.btn_Do1.Size = new System.Drawing.Size(81, 41);
            this.btn_Do1.TabIndex = 3;
            this.btn_Do1.Text = "+0\r\n0.00e0";
            this.btn_Do1.UseVisualStyleBackColor = true;
            // 
            // lbl_Income1
            // 
            this.lbl_Income1.AutoSize = true;
            this.lbl_Income1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Income1.Location = new System.Drawing.Point(6, 41);
            this.lbl_Income1.Name = "lbl_Income1";
            this.lbl_Income1.Size = new System.Drawing.Size(109, 30);
            this.lbl_Income1.TabIndex = 4;
            this.lbl_Income1.Text = "+0.00e0/s";
            // 
            // grp_Basic2
            // 
            this.grp_Basic2.Controls.Add(this.lbl_Count2);
            this.grp_Basic2.Controls.Add(this.btn_Do2);
            this.grp_Basic2.Controls.Add(this.lbl_Income2);
            this.grp_Basic2.Location = new System.Drawing.Point(3, 191);
            this.grp_Basic2.Name = "grp_Basic2";
            this.grp_Basic2.Size = new System.Drawing.Size(524, 88);
            this.grp_Basic2.TabIndex = 6;
            this.grp_Basic2.TabStop = false;
            this.grp_Basic2.Text = "Basic-C";
            // 
            // lbl_Count2
            // 
            this.lbl_Count2.AutoSize = true;
            this.lbl_Count2.Location = new System.Drawing.Point(6, 25);
            this.lbl_Count2.Name = "lbl_Count2";
            this.lbl_Count2.Size = new System.Drawing.Size(20, 15);
            this.lbl_Count2.TabIndex = 5;
            this.lbl_Count2.Text = "x1";
            // 
            // btn_Do2
            // 
            this.btn_Do2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Do2.Enabled = false;
            this.btn_Do2.Location = new System.Drawing.Point(437, 41);
            this.btn_Do2.Name = "btn_Do2";
            this.btn_Do2.Size = new System.Drawing.Size(81, 41);
            this.btn_Do2.TabIndex = 3;
            this.btn_Do2.Text = "+0\r\n0.00e0";
            this.btn_Do2.UseVisualStyleBackColor = true;
            // 
            // lbl_Income2
            // 
            this.lbl_Income2.AutoSize = true;
            this.lbl_Income2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Income2.Location = new System.Drawing.Point(6, 41);
            this.lbl_Income2.Name = "lbl_Income2";
            this.lbl_Income2.Size = new System.Drawing.Size(109, 30);
            this.lbl_Income2.TabIndex = 4;
            this.lbl_Income2.Text = "+0.00e0/s";
            // 
            // grp_Basic3
            // 
            this.grp_Basic3.Controls.Add(this.lbl_Count3);
            this.grp_Basic3.Controls.Add(this.btn_Do3);
            this.grp_Basic3.Controls.Add(this.lbl_Income3);
            this.grp_Basic3.Location = new System.Drawing.Point(3, 285);
            this.grp_Basic3.Name = "grp_Basic3";
            this.grp_Basic3.Size = new System.Drawing.Size(524, 88);
            this.grp_Basic3.TabIndex = 7;
            this.grp_Basic3.TabStop = false;
            this.grp_Basic3.Text = "Basic-D";
            // 
            // lbl_Count3
            // 
            this.lbl_Count3.AutoSize = true;
            this.lbl_Count3.Location = new System.Drawing.Point(6, 25);
            this.lbl_Count3.Name = "lbl_Count3";
            this.lbl_Count3.Size = new System.Drawing.Size(20, 15);
            this.lbl_Count3.TabIndex = 5;
            this.lbl_Count3.Text = "x1";
            // 
            // btn_Do3
            // 
            this.btn_Do3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Do3.Enabled = false;
            this.btn_Do3.Location = new System.Drawing.Point(437, 41);
            this.btn_Do3.Name = "btn_Do3";
            this.btn_Do3.Size = new System.Drawing.Size(81, 41);
            this.btn_Do3.TabIndex = 3;
            this.btn_Do3.Text = "+0\r\n0.00e0";
            this.btn_Do3.UseVisualStyleBackColor = true;
            // 
            // lbl_Income3
            // 
            this.lbl_Income3.AutoSize = true;
            this.lbl_Income3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Income3.Location = new System.Drawing.Point(6, 41);
            this.lbl_Income3.Name = "lbl_Income3";
            this.lbl_Income3.Size = new System.Drawing.Size(109, 30);
            this.lbl_Income3.TabIndex = 4;
            this.lbl_Income3.Text = "+0.00e0/s";
            // 
            // grp_Basic4
            // 
            this.grp_Basic4.Controls.Add(this.lbl_Count4);
            this.grp_Basic4.Controls.Add(this.btn_Do4);
            this.grp_Basic4.Controls.Add(this.lbl_Income4);
            this.grp_Basic4.Location = new System.Drawing.Point(3, 379);
            this.grp_Basic4.Name = "grp_Basic4";
            this.grp_Basic4.Size = new System.Drawing.Size(524, 88);
            this.grp_Basic4.TabIndex = 7;
            this.grp_Basic4.TabStop = false;
            this.grp_Basic4.Text = "Basic-E";
            // 
            // lbl_Count4
            // 
            this.lbl_Count4.AutoSize = true;
            this.lbl_Count4.Location = new System.Drawing.Point(6, 25);
            this.lbl_Count4.Name = "lbl_Count4";
            this.lbl_Count4.Size = new System.Drawing.Size(20, 15);
            this.lbl_Count4.TabIndex = 5;
            this.lbl_Count4.Text = "x1";
            // 
            // btn_Do4
            // 
            this.btn_Do4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Do4.Enabled = false;
            this.btn_Do4.Location = new System.Drawing.Point(437, 41);
            this.btn_Do4.Name = "btn_Do4";
            this.btn_Do4.Size = new System.Drawing.Size(81, 41);
            this.btn_Do4.TabIndex = 3;
            this.btn_Do4.Text = "+0\r\n0.00e0";
            this.btn_Do4.UseVisualStyleBackColor = true;
            // 
            // lbl_Income4
            // 
            this.lbl_Income4.AutoSize = true;
            this.lbl_Income4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Income4.Location = new System.Drawing.Point(6, 41);
            this.lbl_Income4.Name = "lbl_Income4";
            this.lbl_Income4.Size = new System.Drawing.Size(109, 30);
            this.lbl_Income4.TabIndex = 4;
            this.lbl_Income4.Text = "+0.00e0/s";
            // 
            // pnl_Status
            // 
            this.pnl_Status.Controls.Add(this.grp_Status);
            this.pnl_Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Status.Location = new System.Drawing.Point(0, 0);
            this.pnl_Status.Name = "pnl_Status";
            this.pnl_Status.Size = new System.Drawing.Size(552, 119);
            this.pnl_Status.TabIndex = 8;
            // 
            // pnl_Generators
            // 
            this.pnl_Generators.AutoScroll = true;
            this.pnl_Generators.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.pnl_Generators.Controls.Add(this.grp_Basic0);
            this.pnl_Generators.Controls.Add(this.grp_Basic1);
            this.pnl_Generators.Controls.Add(this.grp_Basic4);
            this.pnl_Generators.Controls.Add(this.grp_Basic2);
            this.pnl_Generators.Controls.Add(this.grp_Basic3);
            this.pnl_Generators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Generators.Location = new System.Drawing.Point(0, 119);
            this.pnl_Generators.Name = "pnl_Generators";
            this.pnl_Generators.Size = new System.Drawing.Size(552, 475);
            this.pnl_Generators.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 594);
            this.Controls.Add(this.pnl_Generators);
            this.Controls.Add(this.pnl_Status);
            this.Name = "MainForm";
            this.Text = "SimpleIDLE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.grp_Basic0.ResumeLayout(false);
            this.grp_Basic0.PerformLayout();
            this.grp_Status.ResumeLayout(false);
            this.grp_Status.PerformLayout();
            this.grp_Basic1.ResumeLayout(false);
            this.grp_Basic1.PerformLayout();
            this.grp_Basic2.ResumeLayout(false);
            this.grp_Basic2.PerformLayout();
            this.grp_Basic3.ResumeLayout(false);
            this.grp_Basic3.PerformLayout();
            this.grp_Basic4.ResumeLayout(false);
            this.grp_Basic4.PerformLayout();
            this.pnl_Status.ResumeLayout(false);
            this.pnl_Generators.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Do0;
        private GroupBox grp_Basic0;
        private Label lbl_Count0;
        private Label lbl_Income0;
        private Button btn_Multiplier1;
        private Label lbl_Coins;
        private GroupBox grp_Status;
        private Label lbl_TotalIncome;
        private Label lbl_TotalIncomeText;
        private Button btn_MultiplierAll;
        private Button btn_Multiplier25;
        private Button btn_Multiplier10;
        private GroupBox grp_Basic1;
        private Label lbl_Count1;
        private Button btn_Do1;
        private Label lbl_Income1;
        private GroupBox grp_Basic2;
        private Label lbl_Count2;
        private Button btn_Do2;
        private Label lbl_Income2;
        private GroupBox grp_Basic3;
        private Label lbl_Count3;
        private Button btn_Do3;
        private Label lbl_Income3;
        private GroupBox grp_Basic4;
        private Label lbl_Count4;
        private Button btn_Do4;
        private Label lbl_Income4;
        private Panel pnl_Status;
        private Panel pnl_Generators;
        private Label lbl_Debug;
    }
}