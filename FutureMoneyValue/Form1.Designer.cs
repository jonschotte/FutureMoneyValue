namespace FutureMoneyValue
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InitialInvestmentLabel = new System.Windows.Forms.Label();
            this.InterestRateLabel = new System.Windows.Forms.Label();
            this.CompoundLabel = new System.Windows.Forms.Label();
            this.YearsLabel = new System.Windows.Forms.Label();
            this.FutureMoneyValue = new System.Windows.Forms.Label();
            this.IVBox1 = new System.Windows.Forms.TextBox();
            this.IRBox2 = new System.Windows.Forms.TextBox();
            this.NYBox3 = new System.Windows.Forms.TextBox();
            this.FIVBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dailyButton = new System.Windows.Forms.Button();
            this.weekButton = new System.Windows.Forms.Button();
            this.monthButton = new System.Windows.Forms.Button();
            this.quarterButton = new System.Windows.Forms.Button();
            this.biannualButton = new System.Windows.Forms.Button();
            this.yearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InitialInvestmentLabel
            // 
            this.InitialInvestmentLabel.AutoSize = true;
            this.InitialInvestmentLabel.Location = new System.Drawing.Point(554, 165);
            this.InitialInvestmentLabel.Name = "InitialInvestmentLabel";
            this.InitialInvestmentLabel.Size = new System.Drawing.Size(134, 17);
            this.InitialInvestmentLabel.TabIndex = 1;
            this.InitialInvestmentLabel.Text = "Initial Investment ($)";
            this.InitialInvestmentLabel.Click += new System.EventHandler(this.InitialInvestmentLabel_Click);
            // 
            // InterestRateLabel
            // 
            this.InterestRateLabel.AutoSize = true;
            this.InterestRateLabel.Location = new System.Drawing.Point(554, 191);
            this.InterestRateLabel.Name = "InterestRateLabel";
            this.InterestRateLabel.Size = new System.Drawing.Size(115, 17);
            this.InterestRateLabel.TabIndex = 1;
            this.InterestRateLabel.Text = "Interest Rate (%)";
            // 
            // CompoundLabel
            // 
            this.CompoundLabel.AutoSize = true;
            this.CompoundLabel.Location = new System.Drawing.Point(359, 258);
            this.CompoundLabel.Name = "CompoundLabel";
            this.CompoundLabel.Size = new System.Drawing.Size(92, 17);
            this.CompoundLabel.TabIndex = 1;
            this.CompoundLabel.Text = "Compounded";
            // 
            // YearsLabel
            // 
            this.YearsLabel.AutoSize = true;
            this.YearsLabel.Location = new System.Drawing.Point(554, 219);
            this.YearsLabel.Name = "YearsLabel";
            this.YearsLabel.Size = new System.Drawing.Size(115, 17);
            this.YearsLabel.TabIndex = 1;
            this.YearsLabel.Text = "Number of Years";
            // 
            // FutureMoneyValue
            // 
            this.FutureMoneyValue.AutoSize = true;
            this.FutureMoneyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FutureMoneyValue.Location = new System.Drawing.Point(28, 34);
            this.FutureMoneyValue.Name = "FutureMoneyValue";
            this.FutureMoneyValue.Size = new System.Drawing.Size(459, 36);
            this.FutureMoneyValue.TabIndex = 3;
            this.FutureMoneyValue.Text = "Future Value of Money Calculator";
            this.FutureMoneyValue.Click += new System.EventHandler(this.FutureMoneyValueLable_OnClick);
            // 
            // IVBox1
            // 
            this.IVBox1.Location = new System.Drawing.Point(448, 160);
            this.IVBox1.Name = "IVBox1";
            this.IVBox1.Size = new System.Drawing.Size(100, 22);
            this.IVBox1.TabIndex = 4;
            // 
            // IRBox2
            // 
            this.IRBox2.Location = new System.Drawing.Point(448, 188);
            this.IRBox2.Name = "IRBox2";
            this.IRBox2.Size = new System.Drawing.Size(100, 22);
            this.IRBox2.TabIndex = 5;
            // 
            // NYBox3
            // 
            this.NYBox3.Location = new System.Drawing.Point(448, 216);
            this.NYBox3.Name = "NYBox3";
            this.NYBox3.Size = new System.Drawing.Size(100, 22);
            this.NYBox3.TabIndex = 6;
            // 
            // FIVBox5
            // 
            this.FIVBox5.Location = new System.Drawing.Point(287, 344);
            this.FIVBox5.Name = "FIVBox5";
            this.FIVBox5.Size = new System.Drawing.Size(229, 22);
            this.FIVBox5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Future Investment Value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 142);
            this.label3.TabIndex = 12;
            this.label3.Text = "Welcome! \r\n\r\nPlease enter boxes 1 - 3 then press the button \r\nthat best describes" +
    " how it will be compounded.\r\n\r\nThe future value of initial investment will be \r\n" +
    "displayed below.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dailyButton
            // 
            this.dailyButton.Location = new System.Drawing.Point(143, 278);
            this.dailyButton.Name = "dailyButton";
            this.dailyButton.Size = new System.Drawing.Size(86, 25);
            this.dailyButton.TabIndex = 13;
            this.dailyButton.Text = "Daily";
            this.dailyButton.UseVisualStyleBackColor = true;
            this.dailyButton.Click += new System.EventHandler(this.dailyButton_Click);
            // 
            // weekButton
            // 
            this.weekButton.Location = new System.Drawing.Point(229, 278);
            this.weekButton.Name = "weekButton";
            this.weekButton.Size = new System.Drawing.Size(86, 25);
            this.weekButton.TabIndex = 14;
            this.weekButton.Text = "Weekly";
            this.weekButton.UseVisualStyleBackColor = true;
            this.weekButton.Click += new System.EventHandler(this.weekButton_Click);
            // 
            // monthButton
            // 
            this.monthButton.Location = new System.Drawing.Point(315, 278);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(86, 25);
            this.monthButton.TabIndex = 15;
            this.monthButton.Text = "Monthly";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.quarterButton_Click);
            // 
            // quarterButton
            // 
            this.quarterButton.Location = new System.Drawing.Point(401, 278);
            this.quarterButton.Name = "quarterButton";
            this.quarterButton.Size = new System.Drawing.Size(86, 25);
            this.quarterButton.TabIndex = 16;
            this.quarterButton.Text = "Quarterly";
            this.quarterButton.UseVisualStyleBackColor = true;
            // 
            // biannualButton
            // 
            this.biannualButton.Location = new System.Drawing.Point(487, 278);
            this.biannualButton.Name = "biannualButton";
            this.biannualButton.Size = new System.Drawing.Size(86, 25);
            this.biannualButton.TabIndex = 17;
            this.biannualButton.Text = "Biannually";
            this.biannualButton.UseVisualStyleBackColor = true;
            this.biannualButton.Click += new System.EventHandler(this.biannualButton_Click);
            // 
            // yearButton
            // 
            this.yearButton.Location = new System.Drawing.Point(573, 278);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(86, 25);
            this.yearButton.TabIndex = 18;
            this.yearButton.Text = "Yearly";
            this.yearButton.UseVisualStyleBackColor = true;
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 477);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.biannualButton);
            this.Controls.Add(this.quarterButton);
            this.Controls.Add(this.monthButton);
            this.Controls.Add(this.weekButton);
            this.Controls.Add(this.dailyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIVBox5);
            this.Controls.Add(this.NYBox3);
            this.Controls.Add(this.IRBox2);
            this.Controls.Add(this.IVBox1);
            this.Controls.Add(this.FutureMoneyValue);
            this.Controls.Add(this.InitialInvestmentLabel);
            this.Controls.Add(this.InterestRateLabel);
            this.Controls.Add(this.CompoundLabel);
            this.Controls.Add(this.YearsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Future Money Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InitialInvestmentLabel;
        private System.Windows.Forms.Label InterestRateLabel;
        private System.Windows.Forms.Label CompoundLabel;
        private System.Windows.Forms.Label YearsLabel;
        private System.Windows.Forms.Label FutureMoneyValue;
        private System.Windows.Forms.TextBox IVBox1;
        private System.Windows.Forms.TextBox IRBox2;
        private System.Windows.Forms.TextBox NYBox3;
        private System.Windows.Forms.TextBox FIVBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dailyButton;
        private System.Windows.Forms.Button weekButton;
        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Button quarterButton;
        private System.Windows.Forms.Button biannualButton;
        private System.Windows.Forms.Button yearButton;
    }
}

