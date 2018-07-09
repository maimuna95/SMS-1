using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroductionWindowsApp
{
    public partial class PijushUI : Form
        string _name=String.Empty;
        string _email=String.Empty;
    {
        public PijushUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _name=textBox1.Text;
            _email=textBox2.Text;

            MessageBox.Show("Success");


        }
    }
}
