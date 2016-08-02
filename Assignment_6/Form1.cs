using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class BmiCalculator : Form
    {
        private bool _isMetric;
        public BmiCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MetricradioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            if (rdo == MetricradioButton1)
            {
                Heightlabel.Text = "Cm";
                WeightLabel.Text = "KG";
                _isMetric = true;
            }

            else
            {
                Heightlabel.Text = "In";
                WeightLabel.Text = "Lbs";
                _isMetric = false;
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = Convert.ToDouble(WeightTextBox.Text);
                double height = Convert.ToDouble(HeightTextBox.Text);
                double bmi = weight / (height * height);
                if (!_isMetric)
                {
                    bmi *= 703;

                    if (bmi <= 18.5)
                    {
                        SpitRichTextBox.Text = "Underweight";

                    }
                    else if (bmi >= 18.5 && bmi <= 24.9)
                    {
                        SpitRichTextBox.Text = "Normal";

                    }
                    else if (bmi >= 25 && bmi <= 29.9)
                    {
                        SpitRichTextBox.Text = "Overweight";
                    }
                    else
                    {
                        SpitRichTextBox.Text = "Obese";
                    }

                }
                CalculateTextBox.Text = bmi.ToString();
                if (_isMetric)
                {
                    bmi *= 703;

                    if (bmi <= 18.5)
                    {
                        SpitRichTextBox.Text = "Underweight";

                    }
                    else if (bmi >= 18.5 && bmi <= 24.9)
                    {
                        SpitRichTextBox.Text = "Normal";

                    }
                    else if (bmi >= 25 && bmi <= 29.9)
                    {
                        SpitRichTextBox.Text = "Overweight";
                    }
                    else
                    {
                        SpitRichTextBox.Text = "Obese";
                    }
                }
                CalculateTextBox.Text = bmi.ToString();

            }
            catch (FormatException error)
            {
               
                MessageBox.Show($"Please enter Nunbers! {0}", error.Message);
            }
            

        }

        private void ClearButon_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            CalculateTextBox.Text = "";
            SpitRichTextBox.Text = "";
        }
    }
    }

