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
            this.PYCBox4 = new System.Windows.Forms.TextBox();
            this.FIVBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InitialInvestmentLabel
            // 
            this.InitialInvestmentLabel.AutoSize = true;
            this.InitialInvestmentLabel.Location = new System.Drawing.Point(213, 180);
            this.InitialInvestmentLabel.Name = "InitialInvestmentLabel";
            this.InitialInvestmentLabel.Size = new System.Drawing.Size(134, 17);
            this.InitialInvestmentLabel.TabIndex = 1;
            this.InitialInvestmentLabel.Text = "Initial Investment ($)";
            this.InitialInvestmentLabel.Click += new System.EventHandler(this.InitialInvestmentLabel_Click);
            // 
            // InterestRateLabel
            // 
            this.InterestRateLabel.AutoSize = true;
            this.InterestRateLabel.Location = new System.Drawing.Point(408, 180);
            this.InterestRateLabel.Name = "InterestRateLabel";
            this.InterestRateLabel.Size = new System.Drawing.Size(115, 17);
            this.InterestRateLabel.TabIndex = 1;
            this.InterestRateLabel.Text = "Interest Rate (%)";
            // 
            // CompoundLabel
            // 
            this.CompoundLabel.AutoSize = true;
            this.CompoundLabel.Location = new System.Drawing.Point(408, 250);
            this.CompoundLabel.Name = "CompoundLabel";
            this.CompoundLabel.Size = new System.Drawing.Size(191, 17);
            this.CompoundLabel.TabIndex = 1;
            this.CompoundLabel.Text = "Times per year Compounded";
            // 
            // YearsLabel
            // 
            this.YearsLabel.AutoSize = true;
            this.YearsLabel.Location = new System.Drawing.Point(213, 250);
            this.YearsLabel.Name = "YearsLabel";
            this.YearsLabel.Size = new System.Drawing.Size(115, 17);
            this.YearsLabel.TabIndex = 1;
            this.YearsLabel.Text = "Number of Years";
            // 
            // FutureMoneyValue
            // 
            this.FutureMoneyValue.AutoSize = true;
            this.FutureMoneyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FutureMoneyValue.Location = new System.Drawing.Point(182, 36);
            this.FutureMoneyValue.Name = "FutureMoneyValue";
            this.FutureMoneyValue.Size = new System.Drawing.Size(459, 36);
            this.FutureMoneyValue.TabIndex = 3;
            this.FutureMoneyValue.Text = "Future Value of Money Calculator";
            this.FutureMoneyValue.Click += new System.EventHandler(this.FutureMoneyValueLable_OnClick);
            // 
            // IVBox1
            // 
            this.IVBox1.Location = new System.Drawing.Point(216, 200);
            this.IVBox1.Name = "IVBox1";
            this.IVBox1.Size = new System.Drawing.Size(100, 22);
            this.IVBox1.TabIndex = 4;
            // 
            // IRBox2
            // 
            this.IRBox2.Location = new System.Drawing.Point(411, 200);
            this.IRBox2.Name = "IRBox2";
            this.IRBox2.Size = new System.Drawing.Size(100, 22);
            this.IRBox2.TabIndex = 5;
            // 
            // NYBox3
            // 
            this.NYBox3.Location = new System.Drawing.Point(216, 270);
            this.NYBox3.Name = "NYBox3";
            this.NYBox3.Size = new System.Drawing.Size(100, 22);
            this.NYBox3.TabIndex = 6;
            // 
            // PYCBox4
            // 
            this.PYCBox4.Location = new System.Drawing.Point(411, 270);
            this.PYCBox4.Name = "PYCBox4";
            this.PYCBox4.Size = new System.Drawing.Size(100, 22);
            this.PYCBox4.TabIndex = 7;
            // 
            // FIVBox5
            // 
            this.FIVBox5.Location = new System.Drawing.Point(311, 412);
            this.FIVBox5.Name = "FIVBox5";
            this.FIVBox5.Size = new System.Drawing.Size(111, 22);
            this.FIVBox5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Future Investment Value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(311, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Answer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 60);
            this.label3.TabIndex = 12;
            this.label3.Text = "Welcome! \r\nPlease enter boxes 1 - 4 then press the \"Answer\" \r\nbutton to find the " +
    "value of your investment.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 520);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIVBox5);
            this.Controls.Add(this.PYCBox4);
            this.Controls.Add(this.NYBox3);
            this.Controls.Add(this.IRBox2);
            this.Controls.Add(this.IVBox1);
            this.Controls.Add(this.FutureMoneyValue);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.TextBox PYCBox4;
        private System.Windows.Forms.TextBox FIVBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

