namespace OOStat
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnStat = new System.Windows.Forms.Button();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVariance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(102, 49);
            this.txtInput.Name = "txtInput";
            this.txtInput.PlaceholderText = "Enter your numbers...";
            this.txtInput.Size = new System.Drawing.Size(486, 23);
            this.txtInput.TabIndex = 0;
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(617, 49);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(71, 23);
            this.btnStat.TabIndex = 1;
            this.btnStat.Text = "Statistics";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(162, 99);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.ReadOnly = true;
            this.txtNumbers.Size = new System.Drawing.Size(367, 23);
            this.txtNumbers.TabIndex = 2;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(160, 174);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(73, 23);
            this.txtSum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mean";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(262, 174);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(73, 23);
            this.txtMean.TabIndex = 5;
            this.txtMean.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Variance";
            // 
            // txtVariance
            // 
            this.txtVariance.Location = new System.Drawing.Point(357, 174);
            this.txtVariance.Name = "txtVariance";
            this.txtVariance.Size = new System.Drawing.Size(73, 23);
            this.txtVariance.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Standard Deviation";
            // 
            // txtSD
            // 
            this.txtSD.Location = new System.Drawing.Point(460, 174);
            this.txtSD.Name = "txtSD";
            this.txtSD.Size = new System.Drawing.Size(73, 23);
            this.txtSD.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVariance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput;
        private Button btnStat;
        private TextBox txtNumbers;
        private TextBox txtSum;
        private Label label1;
        private Label label2;
        private TextBox txtMean;
        private Label label3;
        private TextBox txtVariance;
        private Label label4;
        private TextBox txtSD;
    }
}