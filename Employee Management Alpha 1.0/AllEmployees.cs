using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0
{
    public partial class AllEmployees : Form
    {
        Employee_Management employeeManagement;
        const string pattern = @"([^\s]+)"; //pattern to get the first string before a space
        Regex rg = new Regex(pattern);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employeeManagement.ChangeEmployeeTest(tbID.Text, tbFirstName.Text, tbLastName.Text);
            UpdateList();
        }

        private void lbViewEmployees_Click(object sender, EventArgs e)
        {   
            if (!(lbViewEmployees.SelectedIndex.Equals(null)))
            {
                string ID = lbViewEmployees.SelectedItem.ToString();
                Match match = Regex.Match(ID, pattern);
                if (match.Success)
                {
                    tbID.Text = match.Value;

                }
            }
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            Employee employee;
            employee = new Employee();
            employee = employeeManagement.GetEmployeebyID(Convert.ToInt32(tbID.Text));
            tbFirstName.Text = employee.Firstname;
            tbLastName.Text = employee.Lastname;
        }

        private void AllEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
