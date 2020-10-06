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
    public partial class DepartmentInfo : Form
    {
        Department_Management departmentManagement;
        Employee_Management employeeManagement;
        const string pattern = @"([^\s]+)";
        const string patternName = @"(?<=^(\S+\s){1})\S+";
        public DepartmentInfo()
        {
            InitializeComponent();
            UpdateDepList();
            UpdateEmpList();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDepList()
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
        private void UpdateEmpList()
        {
            lbEmployeeInfo.Items.Clear();
            employeeManagement = new Employee_Management();

            if(employeeManagement.GetAllEmployees() is null)
            {
                MessageBox.Show("Database is empty.");
            }
            else
            {
                for(int i = 0; i < employeeManagement.GetAllEmployees().Count(); i++)
                {
                    lbEmployeeInfo.Items.Add(employeeManagement.GetAllEmployees()[i].GetEmployeeInfo());
                }
            }
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            string id = lbDepartmentInfo.SelectedItem.ToString();
            Match match = Regex.Match(id, pattern);

            if (match.Success)
            {
                departmentManagement.UpdateStatus(match.Value, DepartmentStatus.Active);
                UpdateDepList();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string id = lbDepartmentInfo.SelectedIndex.ToString();
            Match match = Regex.Match(id, pattern);
            

            if (match.Success)
            {
                departmentManagement.UpdateStatus(id, DepartmentStatus.Inactive);
                UpdateDepList();
            }
        }

        private void LbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAssignEmp_Click(object sender, EventArgs e)
        {
            string name = lbDepartmentInfo.SelectedItem.ToString();
            Match match = Regex.Match(name, patternName);
            string id = lbEmployeeInfo.SelectedItem.ToString();
            Match matchid = Regex.Match(id, pattern);

            if (match.Success && matchid.Success)
            {
                departmentManagement.AssignEmployee(match.Value, matchid.Value);
                UpdateDepList();
                UpdateEmpList();
            }
        }
    }
}
