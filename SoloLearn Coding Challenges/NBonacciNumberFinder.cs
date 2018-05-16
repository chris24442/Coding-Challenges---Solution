using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoloLearn_Coding_Challenges
{
    public partial class NBonacciNumberFinder : Form
    {
        public NBonacciNumberFinder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int SequenceOrder = 0;
            int SequenceDigit = 0;
            // int exception = 0;

            try
            {
                SequenceOrder = Convert.ToInt32(textBox1.Text);
                SequenceDigit = Convert.ToInt32(textBox2.Text);

                if (SequenceOrder < 1 || SequenceDigit < 1)
                {
                    MessageBox.Show("Please enter positive integers.");
                    return;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please enter integers.");
                return;
            }

            try
            {
                SequenceOrder = Convert.ToInt32(textBox1.Text);
                SequenceDigit = Convert.ToInt32(textBox2.Text);

                if (SequenceOrder < 1 || SequenceDigit < 1)
                {
                    MessageBox.Show("Please enter positive integers.");
                    return;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please enter integers.");
                return;
            }

            List<int> NBonacciSequence = new List<int>();

                    for (int m=0; m < SequenceOrder - 1; m++)
                        NBonacciSequence.Add(0);

                    NBonacciSequence.Add(1);

                    int tempvalue = 0;
                    int templength = 0;

                    for (int n = 0; n < SequenceDigit - SequenceOrder; n++)
                    {
                        templength = NBonacciSequence.Count;
                        for (int p=0; p < SequenceOrder; p++)
                        {
                            tempvalue += NBonacciSequence[templength-p-1];
                        }
                        NBonacciSequence.Add(tempvalue);
                        tempvalue = 0;
                    }

                        MessageBox.Show("The " + textBox2.Text + SuffixGenerator(SequenceDigit) +
                            " digit of the " + textBox1.Text + SuffixGenerator(SequenceOrder)
                          + " order Fibonacci sequence is " + Convert.ToString(NBonacciSequence[SequenceDigit - 1]));

                    ///full sequence - DEL
                    var message = string.Join(Environment.NewLine, NBonacciSequence.ToArray());
                    MessageBox.Show(message);
        }

        static string SuffixGenerator(int number)
        {
            string NumberSuffix;
            string numberAsString = Convert.ToString(number);
            string lastTwoDigits = numberAsString.Substring(Math.Max(0, numberAsString.Length - 2));

            switch (lastTwoDigits)
            {
                case "11":
                case "12":
                case "13":
                    NumberSuffix = "th";
                    return NumberSuffix;
                default:
                    string lastDigit = numberAsString.Substring(numberAsString.Length-1);
                    switch (lastDigit)
                    {
                        case "1":
                            NumberSuffix = "st";
                            return NumberSuffix;
                        case "2":
                            NumberSuffix = "nd";
                            return NumberSuffix;
                        case "3":
                            NumberSuffix = "rd";
                            return NumberSuffix;
                        default:
                            NumberSuffix = "th";
                            return NumberSuffix;
                    }

            }

        }



        private void NBonacciNumberFinder_Load(object sender, EventArgs e)
        {

        }

        private void ReturnToMainPage_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
