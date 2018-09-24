using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            int h;
            string g;

            if (comboBox1.SelectedIndex == 0)
            {
               h = a + b;
                g = h.ToString();
                textBoxH.Text = g;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                h = a - b;
                g = h.ToString();
                textBoxH.Text = g;

            }
            if (comboBox1.SelectedIndex == 2)
            {
                h = a * b;
                g = h.ToString();
                textBoxH.Text = g;

            }
            if (comboBox1.SelectedIndex == 3)
            {
                h = a / b;
                g = h.ToString();
                textBoxH.Text = g;

            }
        }

       
    }
}
