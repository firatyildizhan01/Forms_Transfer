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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string isim1;
        public string isim2;
        public string isim3;
        public string isim4;
        public string isim5;
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = isim1;
            label1.Text = isim2;
            textBox2.Text = isim3;
            textBox1.Text = isim4;
            raft.Text = isim5;
        }
    }
}
