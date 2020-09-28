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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
           
            lbEmployees.Items.Clear();
            //DateTime time = Convert.ToDateTime(dtpEmployee.Value); //Date time picker
            employeeManagement.AddEmployeeTest(tbFirstName.Text, tbLastName.Text);
            
            
        }
    }
}
