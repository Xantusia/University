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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dot=-1, comma=-1;
            string part2;
            try
            {
                dot=textBox1.Text.IndexOf('.');
                comma= textBox1.Text.IndexOf(',');
            }
            catch
            {
                MessageBox.Show("Something went wrong", "OK");
            }
            if(dot!=-1)
                part2 = textBox1.Text.Substring(dot+1);
            else if(comma!=-1)
                part2 = textBox1.Text.Substring(comma+1);
            else
                part2 = "Дробной части нет";
            MessageBox.Show(part2, "OK");


        }
    }
}
