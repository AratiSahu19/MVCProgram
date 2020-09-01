using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fact = 1;
            int num = int.Parse(textBox1.Text);
            do
            {
                fact = fact * num;
                num--;
            } while (num > 0);
            label2.Text="factorial:"+fact;
        }
    }
}
