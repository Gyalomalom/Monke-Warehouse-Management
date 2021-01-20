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
            List<Employee> employees = new List<Employee>();
            employees = employeeManagement.GetAllActiveEmployees();

            if (employees is null)
            {
                MessageBox.Show("Database is empty.");
            }
            else
            {
                for(int i = 0; i < employees.Count(); i++)
                {
                    lbEmployeeInfo.Items.Add(employees[i].GetEmployeeFullName());
                }
            }
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (!(lbDepartmentInfo.SelectedItem == null))
            {
                string id = lbDepartmentInfo.SelectedItem.ToString();
                Match match = Regex.Match(id, pattern);

                if (match.Success)
                {
                    departmentManagement.UpdateStatus(match.Value, DepartmentStatus.Active);
                    UpdateDepList();
                }
            }
            else
            {
                MessageBox.Show("Please make sure you've selected a department.");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!(lbDepartmentInfo.SelectedItem == null))
            {
                string id = lbDepartmentInfo.SelectedItem.ToString();
                Match match = Regex.Match(id, pattern);


                if (match.Success)
                {
                    departmentManagement.UpdateStatus(match.Value, DepartmentStatus.Inactive);
                    UpdateDepList();
                }
            }
            else
            {
                MessageBox.Show("Please make sure you've selected a department.");
            }
        }

        private void LbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAssignEmp_Click(object sender, EventArgs e)
        {


            if ((!(lbEmployeeInfo.SelectedItem == null)) && (!(lbDepartmentInfo.SelectedItem == null)))
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
            else
            {
                MessageBox.Show("Please make sure you've selected both a department and an employee.");
            }
        }

        private void lbDepartmentInfo_Click(object sender, EventArgs e)
        {
        }

        private void btnViewEmployeesinDepartment_Click(object sender, EventArgs e)
        {   if (!(lbDepartmentInfo.SelectedItem == null))
            {
                string id = lbDepartmentInfo.SelectedItem.ToString();
                Match match = Regex.Match(id, pattern);

                if (match.Success)
                {
                    lbEmployeeInfo.Items.Clear();
                    departmentManagement = new Department_Management();
                    List<Employee> employees = new List<Employee>();
                    employees = departmentManagement.ReturnEmployeesByDepartment(departmentManagement.FindDepbyID(Convert.ToInt32(match.Value)).Name);

                    // Set cursor as hourglass
                    // Set cursor as hourglass
                    Cursor.Current = Cursors.WaitCursor;
                    Application.DoEvents();
                    if (employees is null)
                    {
                        MessageBox.Show("Database is empty.");
                    }
                    else
                    {
                        for (int i = 0; i < employees.Count(); i++)
                        {
                            lbEmployeeInfo.Items.Add(employees[i].GetEmployeeFullName());
                        }
                    }
                    // Set cursor as hourglass
                    Cursor.Current = Cursors.Default;
                    Application.DoEvents();
                }
            }
            else
            {
                MessageBox.Show("Please make sure you've selected a department.");
            }
        }

        private void btnViewAllEmployees_Click(object sender, EventArgs e)
        {
            UpdateEmpList();
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if ((!(lbEmployeeInfo.SelectedItem == null)) && (!(lbDepartmentInfo.SelectedItem == null)))
            {
                string name = lbDepartmentInfo.SelectedItem.ToString();
                Match match = Regex.Match(name, patternName);
                string id = lbEmployeeInfo.SelectedItem.ToString();
                Match matchid = Regex.Match(id, pattern);


                if (match.Success && matchid.Success)
                {
                    departmentManagement.UnassignEmployee(match.Value, matchid.Value);
                    UpdateDepList();
                    UpdateEmpList();
                }
            }
            else
            {
                MessageBox.Show("Please make sure you've selected both a department and an employee.");
            }
        }
    }
}
