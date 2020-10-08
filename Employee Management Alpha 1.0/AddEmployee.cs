using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0
{
    public partial class AddEmployee : Form
    {
        
        Employee_Management employeeManagement;
        public AddEmployee()
        {
            InitializeComponent();
            employeeManagement = new Employee_Management();
            UpdateList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateList()
        {
            lbEmployees.Items.Clear();
            employeeManagement = new Employee_Management();
            if (employeeManagement.GetAllEmployees() is null)
            {
                MessageBox.Show("The database is empty!");
                lbEmployees.Items.Add("The database is empty!");
            }
            else
            {
                for (int i = 0; i < employeeManagement.GetAllEmployees().Count(); i++)
                {

                    lbEmployees.Items.Add(employeeManagement.GetAllEmployees()[i].GetEmployeeInfo());

                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
           
            lbEmployees.Items.Clear();
            //DateTime time = Convert.ToDateTime(dtpEmployee.Value); //Date time picker
            employeeManagement.AddEmployeeTest(tbFirstName.Text, tbLastName.Text);

            lbEmployees.Items.Clear();
            employeeManagement = new Employee_Management();
            if (employeeManagement.GetAllEmployees() is null)
            {
                MessageBox.Show("The database is empty!");
                lbEmployees.Items.Add("The database is empty!");
            }
            else
            {
                for (int i = 0; i < employeeManagement.GetAllEmployees().Count(); i++)
                {

                    lbEmployees.Items.Add(employeeManagement.GetAllEmployees()[i].GetEmployeeInfo());

                }
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        
    }
}
