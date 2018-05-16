using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoloLearn_Coding_Challenges
{
    public partial class SummationsCalculator : Form
    {
        public SummationsCalculator()
        {
            InitializeComponent();
        }

        private void SummationsCalculator_Load(object sender, EventArgs e)
        {

        }

        private void ReturnToMainPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LowerBound = 0;
            int UpperBound = 0;

            int m = -1;
            int n = 0; //merge to one variable? //delete after use?

            string equation = Convert.ToString(textBox3.Text);
            char[] Equation = new char[equation.Length];
            List<string> EquationGrouped = new List<string>();

            try
            {
                LowerBound = Convert.ToInt32(textBox1.Text);
                UpperBound = Convert.ToInt32(textBox2.Text);

                if (LowerBound > UpperBound)
                {
                    MessageBox.Show("Please enter an upper bound greater than the lower bound.");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter integers.");
                return;
            } //deal with user input into bound boxes

            foreach (char c in equation)
            {
                m++;
                switch (c)
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                            Equation[m] = c;
                            break;
                    default:
                        if (char.IsNumber(c) == true)
                            Equation[m] = c;
                        else
                        {
                            MessageBox.Show("Please enter only integers and '+', '-', '/' and '*'.");
                            return;
                                }
                        break;
                }
            } //deal with user input into equation box

            //Check equation box is of the correct format
            {
                while (char.IsNumber(Equation[0]) == true)
                {
                    MessageBox.Show("The lower bound dictates the first number in the equation, and therefore your equation must begin with '*', '/', '+' or '-'");
                    return;
                }

                while (char.IsNumber(Equation[m]) == false)
                {
                    MessageBox.Show("An equation cannot end with an operator, it must end with an integer.");
                    return;
                }

                foreach (char c in equation)
                {
                    n++;
                    switch (c)
                    {
                        case '+':
                        case '-':
                        case '*':
                        case '/':
                            if (char.IsNumber(Equation[n]) == false & Equation[n]!=43/*+*/ & Equation[n]!= 45/*-*/)
                            {
                                MessageBox.Show("An operator must have a number, '+' or '-' after it.");
                                return;
                            }
                            break;
                    }
                } 
            }

            string Groupedc;
            int p = 0; //skip variable
            int q = 0; //skip variable
            //perform equation
            foreach (char c in equation)
            {
                while (p > 0)
                {
                    switch (c)
                    {

                        case '*':
                        case '/':
                        case '+':
                        case '-':
                            p--;
                            break;

                        default:
                            EquationGrouped.Add(Convert.ToString(c));
                            p++;
                            continue;
                    }
                }

                switch (c)
                {

                    case '*':
                    case '/':
                        EquationGrouped.Add(Convert.ToString(c));
                        break;

                    case '+':
                    case '-':
                        q++;
                        break;

                    default:
                        EquationGrouped.Add(Convert.ToString(c));
                        p++;
                        break;
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
