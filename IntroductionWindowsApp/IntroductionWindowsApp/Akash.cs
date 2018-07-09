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
    public partial class Akash : Form
    {
        public Akash()
        {
            InitializeComponent();
        }

        List<string> _studentNameList = new List<string>();
        List<int> _studentRegNoList = new List<int>();


        private void studentNameTextBox_TextChanged(object sender, EventArgs e)
        {
            listView.Items.Clear();
            string inputName = studentNameTextBox.Text;
            foreach (string getname in _studentNameList)
            {
                if (getname.Contains(inputName) && inputName != "")
                {
                    int nameIndex = _studentNameList.IndexOf(getname);
                    int id = _studentRegNoList[nameIndex];
                    ListViewItem item = new ListViewItem(Convert.ToString(id), getname);
                    //  listView1.Items.Clear();
                    item.SubItems.Add(getname);
                    listView.Items.Add(item);

                }



            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (studentNameTextBox.Text != "" && regNoTextBox.Text != "")
            {

                _studentNameList.Add(studentNameTextBox.Text);
                _studentRegNoList.Add(Convert.ToInt32(regNoTextBox.Text));

            }
            else
            {
                MessageBox.Show("You've must fill both boxes");
            }

            studentNameTextBox.Text = null;
            regNoTextBox.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string studentName = "";
            int regNo = 0;

            if (studentNameTextBox.Text != "")
            {
                studentName = studentNameTextBox.Text;
                foreach (string searchName in _studentNameList)
                {

                    if (searchName == studentName)
                    {
                        int index = _studentNameList.IndexOf(searchName);
                        int regNum = _studentRegNoList[index];
                        ListViewItem item = new ListViewItem(Convert.ToString(regNum), searchName);
                        listView.Items.Clear();
                        item.SubItems.Add(searchName);
                        listView.Items.Add(item);

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
                        listView.Items.Clear();
                        item.SubItems.Add(name);
                        listView.Items.Add(item);

                    }
                }
            }
        }
    }
}
