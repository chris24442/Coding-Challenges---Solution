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
    public partial class SoloLearnCodingChallenges : Form
    {
        public SoloLearnCodingChallenges()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NBonacciNumberFinder nBonacciNumberFinder = new NBonacciNumberFinder();
            this.Hide();
            nBonacciNumberFinder.ShowDialog();
            this.Show();
           
        }

        private void BonacciCalculate_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SummationsCalculator summationsCalculator = new SummationsCalculator();
            this.Hide();
            summationsCalculator.ShowDialog();
            this.Show();
        }
    }
}
