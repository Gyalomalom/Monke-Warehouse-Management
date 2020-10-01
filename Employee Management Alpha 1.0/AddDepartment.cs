using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0
{
    public partial class AddDepartment : Form
    {
        Department_Management departmentManagement;
        public AddDepartment()
        {
            InitializeComponent();
            departmentManagement = new Department_Management();
            UpdateInfo();

        }

        public void UpdateInfo()
        {
            departmentManagement = new Department_Management();
            if (departmentManagement.FindAllDep() is null)
            {
                MessageBox.Show("Database is empty.");
            }
            else
            {
                for (int i = 0; i < departmentManagement.FindAllDep().Count(); i++)
                {
                    lbDepartments.Items.Add(departmentManagement.FindAllDep()[i].GetDepInfo());
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddDep_Click(object sender, EventArgs e)
        {
            lbDepartments.Items.Clear();
            departmentManagement.AddDepartment(tbName.Text, tbHead.Text, tbAddress.Text, tbPhone.Text, tbEmail.Text, tbLanguage.Text, Convert.ToString(DepartmentStatus.Active));

        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
