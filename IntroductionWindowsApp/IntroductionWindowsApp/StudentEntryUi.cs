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
    public partial class StudentEntryUi : Form
    {
        string _name = String.Empty;
        string _phoneNo = String.Empty;
        string _email = String.Empty;
        string _address = String.Empty;

        public StudentEntryUi()
        {
            InitializeComponent();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            _name = nameTextBox.Text;
            if (_name.Length < 3)
            {
                MessageBox.Show("Sorry.....");
                return;
            }

            _phoneNo = phoneNoTextBox.Text;
            _email = emailTextBox.Text;
            _address = addressRichTextBox.Text;

            MessageBox.Show("Success");

            nameTextBox.Text = String.Empty;
            phoneNoTextBox.Text = "";
            emailTextBox.Text = "";
            addressRichTextBox.Text = "";



        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = _name;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            //string userInput = textBox1.Text;

            char c = 'A';
            string b = c.ToString();

            MessageBox.Show(b);




            //int number = int.Parse(userInput);
            //MessageBox.Show(number.ToString());


            //double b = 10.50;
            //int a = (int)b;
            //MessageBox.Show(a.ToString());

        }

        static int count = 5;
        List<string> nameList = new List<string>();
        private void AddButton_Click(object sender, EventArgs e)
        {
            nameList.Add(nameTextBox.Text);
        }

        private void NameListShowButton_Click(object sender, EventArgs e)
        {
            string names = "";
            //for (int i = 0; i < nameList.Count; i++)
            //{
            //    names += nameList[i] + "\n";
            //}


            foreach (var name in nameList)
            {
                names += name + "\n";
            }

            MessageBox.Show(names);

        }




    }
}
