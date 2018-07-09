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
    public partial class ArifUddinForm : Form
    {
        List<string> _studentNameList = new List<string>();
        List<int> _studentRegNoList = new List<int>();
        public ArifUddinForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && regNoTextBox.Text != "")
            {

                _studentNameList.Add(nameTextBox.Text);
                _studentRegNoList.Add(Convert.ToInt32(regNoTextBox.Text));

            }
            else
            {
                MessageBox.Show("Fill both boxes please");
            }

            nameTextBox.Text = null;
            regNoTextBox.Text = "";
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            finalListView.Items.Clear();
            string inputName = nameTextBox.Text;
            foreach (string getname in _studentNameList)
            {
                if (getname.Contains(inputName) && inputName != "")
                {
                    int nameIndex = _studentNameList.IndexOf(getname);
                    int id = _studentRegNoList[nameIndex];
                    ListViewItem item = new ListViewItem(Convert.ToString(id), getname);
                    item.SubItems.Add(getname);
                    finalListView.Items.Add(item);

                }



            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string studentName = "";
            int regNo = 0;

            if (nameTextBox.Text != "")
            {
                studentName = nameTextBox.Text;
                foreach (string searchName in _studentNameList)
                {

                    if (searchName == studentName)
                    {
                        int index = _studentNameList.IndexOf(searchName);
                        int regNum = _studentRegNoList[index];
                        ListViewItem item = new ListViewItem(Convert.ToString(regNum), searchName);
                        finalListView.Items.Clear();
                        item.SubItems.Add(searchName);
                        finalListView.Items.Add(item);

                    }
                }
            }
            else if (regNoTextBox.Text != "")
            {
                regNo = Convert.ToInt32(regNoTextBox.Text);
                foreach (int searchReg in _studentRegNoList)
                {

                    if (searchReg == regNo)
                    {
                        int index = _studentRegNoList.IndexOf(regNo);
                        string name = _studentNameList[index];
                        ListViewItem item = new ListViewItem(Convert.ToString(regNo), name);
                        finalListView.Items.Clear();
                        item.SubItems.Add(name);
                        finalListView.Items.Add(item);

                    }
                }
            }
        }
    }
}
