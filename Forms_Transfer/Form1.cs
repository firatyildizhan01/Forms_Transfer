using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Transfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public string isim1;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 cfg = new Form2();
            cfg.isim1 = textBox1.Text;
            cfg.isim2 = textBox2.Text;
            cfg.isim3 = textBox3.Text;
            cfg.isim4 = textBox4.Text;
            cfg.isim5 = textBox5.Text;
            cfg.Show();
            this.Hide();

            
            
            
        }
    }
}
