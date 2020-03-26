using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x, y, point ;
            double x1, x2, y1, y2, z1, z2, length;
            x = textBox1.Text;
            y = textBox2.Text;
            point = textBox3.Text;
            Regex symbolMatch1 = new Regex(@"\d*\+\d*\*\d*");
            Regex symbolMatch2 = new Regex(@"\d*,\d*");
            if(Form1.Debug)
            MessageBox.Show(symbolMatch1.IsMatch(x).ToString() + symbolMatch1.IsMatch(y).ToString() + symbolMatch2.IsMatch(point).ToString(), "ok");
            if(symbolMatch1.IsMatch(x)&& symbolMatch1.IsMatch(y)&& symbolMatch2.IsMatch(point))
            {
                x1 = double.Parse(x.Substring(0, x.IndexOf('+')));
                x2 = double.Parse(x.Substring(x.IndexOf('+') + 1, (x.IndexOf('*')) - x.IndexOf('+')-1));
                y1 = double.Parse(y.Substring(0, y.IndexOf('+')));
                y2 = double.Parse(y.Substring(y.IndexOf('+') + 1, (y.IndexOf('*')) - y.IndexOf('+')-1));
                z1= double.Parse(point.Substring(0, point.IndexOf(',')));
                z2 = double.Parse(point.Substring(point.IndexOf(',')+1, (point.Length- point.IndexOf(',')-1)));
                if(Form1.Debug)
                MessageBox.Show(x1 + " " + x2 + " " + y1 + " " + y2 + " " +z1 + " " + z2, "OK");
                double b,v,t1,t2;
                b = (z1 - x1) / x2;
                v = y2 * b + y1;
                t1 =Math.Abs(z2 - v);
                t2 = Math.Atan(y2);
                if(Form1.Debug)
                MessageBox.Show(b + " " + v + " " + t1 + " " + t2, "OK");
                length = Math.Pow(Math.Sin(t2) / t1,-1);
                MessageBox.Show(length.ToString(), "Длина от точки до прямой");
            }
            else
            {
                MessageBox.Show("Error", "OK");
            }
        }
    }
}
