using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, alan, çevre;
            sayi1 = 10;
            sayi2 = 20;
            alan = sayi1 * sayi2;
            çevre = (sayi1 * sayi2) * 2;
            label1.Text = "alan:" + alan + "çevre:" + çevre;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
