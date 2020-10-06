using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Employee_Management_Alpha_1._0
{
    public partial class RemoveDepartment : Form
    {
        Department_Management departmentManagement;
        const string pattern = @"([^\s]+)";
        public RemoveDepartment()
        {
            InitializeComponent();
            UpdateList();
            
            
        }
        private void UpdateList()
        {
            lbDepartmentInfo.Items.Clear();
            departmentManagement = new Department_Management();
            if(departmentManagement.FindAllDep() is null)
            {
                MessageBox.Show("Database is empty.");
            }
            else
            {
                for(int i = 0; i < departmentManagement.FindAllDep().Count(); i++)
                {
                    lbDepartmentInfo.Items.Add(departmentManagement.FindAllDep()[i].GetDepInfo());
                }
            }


        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string id = lbDepartmentInfo.SelectedItem.ToString();
            Match match = Regex.Match(id, pattern);

            if (match.Success)
            {
                departmentManagement.RemoveDepartment(match.Value);
                UpdateList();
            }
        }

        private void RemoveDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
