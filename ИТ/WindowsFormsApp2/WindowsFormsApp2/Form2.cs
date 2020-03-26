using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                List<string> list = new List<string>((textBox1.Text.Split(' ')));
                
                List<double> numbers = new List<double>();
                foreach(string num in list)
                {
                    numbers.Add(Double.Parse(num));
                }
                double min = double.Parse(list[0]), max = double.Parse(list[0]);
                foreach (double num in numbers)
                {
                    if (num > max)
                        max = num;
                    if (num < min)
                        min = num;
                }
                MessageBox.Show(max + " - максимальное число, " + min + " - минимальное число", "OK");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", "OK");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
