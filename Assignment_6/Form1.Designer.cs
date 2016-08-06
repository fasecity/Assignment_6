using System.Windows.Forms;

namespace Assignment_6
{
    partial class BmiCalculator
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
            this.Calculate = new System.Windows.Forms.Button();
            this.MetricradioButton1 = new System.Windows.Forms.RadioButton();
            this.SpitRichTextBox = new System.Windows.Forms.RichTextBox();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ImperialradioButton2 = new System.Windows.Forms.RadioButton();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.CalculateTextBox = new System.Windows.Forms.TextBox();
            this.ClearButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(16, 248);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(120, 64);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // MetricradioButton1
            // 
            this.MetricradioButton1.AutoSize = true;
            this.MetricradioButton1.Location = new System.Drawing.Point(16, 41);
            this.MetricradioButton1.Name = "MetricradioButton1";
            this.MetricradioButton1.Size = new System.Drawing.Size(77, 24);
            this.MetricradioButton1.TabIndex = 3;
            this.MetricradioButton1.TabStop = true;
            this.MetricradioButton1.Text = "Metric";
            this.MetricradioButton1.UseVisualStyleBackColor = true;
            this.MetricradioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SpitRichTextBox
            // 
            this.SpitRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpitRichTextBox.Location = new System.Drawing.Point(16, 338);
            this.SpitRichTextBox.Name = "SpitRichTextBox";
            this.SpitRichTextBox.ReadOnly = true;
            this.SpitRichTextBox.Size = new System.Drawing.Size(120, 74);
            this.SpitRichTextBox.TabIndex = 5;
            this.SpitRichTextBox.Text = "";
            this.SpitRichTextBox.TextChanged += new System.EventHandler(this.Calculate_Click);
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.Location = new System.Drawing.Point(12, 95);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(80, 20);
            this.Heightlabel.TabIndex = 8;
            this.Heightlabel.Text = "My Height";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(12, 169);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(83, 20);
            this.WeightLabel.TabIndex = 9;
            this.WeightLabel.Text = "My Weight";
            // 
            // ImperialradioButton2
            // 
            this.ImperialradioButton2.AutoSize = true;
            this.ImperialradioButton2.Location = new System.Drawing.Point(189, 41);
            this.ImperialradioButton2.Name = "ImperialradioButton2";
            this.ImperialradioButton2.Size = new System.Drawing.Size(90, 24);
            this.ImperialradioButton2.TabIndex = 4;
            this.ImperialradioButton2.TabStop = true;
            this.ImperialradioButton2.Text = "Imperial";
            this.ImperialradioButton2.UseVisualStyleBackColor = true;
            this.ImperialradioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(148, 95);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(131, 53);
            this.HeightTextBox.TabIndex = 10;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(151, 169);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(128, 53);
            this.WeightTextBox.TabIndex = 11;
            // 
            // CalculateTextBox
            // 
            this.CalculateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateTextBox.Location = new System.Drawing.Point(151, 259);
            this.CalculateTextBox.Name = "CalculateTextBox";
            this.CalculateTextBox.ReadOnly = true;
            this.CalculateTextBox.Size = new System.Drawing.Size(135, 53);
            this.CalculateTextBox.TabIndex = 12;
            // 
            // ClearButon
            // 
            this.ClearButon.Location = new System.Drawing.Point(191, 338);
            this.ClearButon.Name = "ClearButon";
            this.ClearButon.Size = new System.Drawing.Size(95, 74);
            this.ClearButon.TabIndex = 13;
            this.ClearButon.Text = "Clear";
            this.ClearButon.UseVisualStyleBackColor = true;
            this.ClearButon.Click += new System.EventHandler(this.ClearButon_Click);
            // 
            // BmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.ClearButon);
            this.Controls.Add(this.CalculateTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.Heightlabel);
            this.Controls.Add(this.SpitRichTextBox);
            this.Controls.Add(this.ImperialradioButton2);
            this.Controls.Add(this.MetricradioButton1);
            this.Controls.Add(this.Calculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BmiCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Calculate;
        private RadioButton MetricradioButton1;
        private System.Windows.Forms.RichTextBox SpitRichTextBox;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.Label WeightLabel;
        private RadioButton ImperialradioButton2;
        private TextBox HeightTextBox;
        private TextBox WeightTextBox;
        private TextBox CalculateTextBox;
        private Button ClearButon;
    }
}

