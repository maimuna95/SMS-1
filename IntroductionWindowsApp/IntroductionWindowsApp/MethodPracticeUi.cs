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
    public partial class MethodPracticeUi : Form
    {
        private string _firstName = "";
        private string _lastName = "";
        public MethodPracticeUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            List<string> nameList= new List<string>{"C","B","A"};
            nameList.Sort();

            foreach (var name in nameList)
            {
                MessageBox.Show(name);
            }
            

            //AddEmployeeName(firstNameTextBox.Text, lastNameTextBox.Text);
        }


        public void AddEmployeeName(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string fullName = GetFullName();
            MessageBox.Show(fullName);
        }


        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }



       
    }
}
