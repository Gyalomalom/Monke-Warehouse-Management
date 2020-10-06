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
            lbDepartments.Items.Clear();
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
            bool errorfound = false;
            string[] infoFields = new string[6] { tbName.Text, tbHead.Text, tbAddress.Text, tbPhone.Text, tbEmail.Text, tbLanguage.Text };
            foreach(string Item in infoFields)
            { if (!(errorfound))
                if (string.IsNullOrEmpty(Item))
                {
                    MessageBox.Show($"One or more fields was empty. Please fill out all the fields.");
                    errorfound = true;
                }
            }
            if (!(errorfound))
            {
                departmentManagement.AddDepartment(tbName.Text, tbHead.Text, tbAddress.Text, tbPhone.Text, tbEmail.Text, tbLanguage.Text, Convert.ToString(DepartmentStatus.Active));
                UpdateInfo();
            }
            else
            {
                errorfound = false;
            }

        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {

        }

        //private void AddDepartment_Load(object sender, EventArgs e)
        //{

        //}
    }
}
