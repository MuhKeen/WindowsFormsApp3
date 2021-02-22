using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      textBox2.Text = "";
      double x = double.Parse(textBox1.Text);
      double y = (Math.Sqrt(1 + Math.Pow(Math.Exp(x), Math.Sqrt(x)) + Math.Cos(Math.Pow(x, 2))) / (Math.Abs(1 - Math.Pow(Math.Sin(x), 3))) + Math.Log(Math.Abs(2 * x)));
      textBox2.Text += Environment.NewLine + "Результат y = " + y.ToString();


    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
  }
}
