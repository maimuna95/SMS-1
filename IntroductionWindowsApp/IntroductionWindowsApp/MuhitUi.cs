﻿using System;
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
    public partial class MuhitUi : Form
    {
        public MuhitUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string student = studentTextBox.Text;
            MessageBox.Show(student);
        }
    }
}