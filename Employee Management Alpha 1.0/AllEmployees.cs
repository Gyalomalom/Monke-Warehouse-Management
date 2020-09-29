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
    public partial class AllEmployees : Form
    {
        Employee_Management employeeManagement;
        public AllEmployees()
        {
            InitializeComponent();
            UpdateList();
        }

        private void UpdateList()
        {
            lbViewEmployees.Items.Clear();
            employeeManagement = new Employee_Management();
            if (employeeManagement.GetAllEmployees() is null)
            {
                MessageBox.Show("The database is empty!");
                lbViewEmployees.Items.Add("The database is empty!");
            }
            else
            {
                for (int i = 0; i < employeeManagement.GetAllEmployees().Count(); i++)
                {

                    lbViewEmployees.Items.Add(employeeManagement.GetAllEmployees()[i].GetEmployeeInfo());

                }
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            Employee employee;
            employee = new Employee();
            employee = employeeManagement.GetEmployeebyID(Convert.ToInt32(tbID.Text));
            tbFirstName.Text = employee.Firstname;
            tbLastName.Text = employee.Lastname;
            //dtpEmployee.Value = employee.date_of_birth;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            employeeManagement.ChangeEmployeeTest(tbID.Text, tbFirstName.Text, tbLastName.Text);
            UpdateList();
        }
    }
}
