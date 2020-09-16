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
    public partial class EmpManagementScreen : Form
    {
        Employee_Management employeeManagement;
        public EmpManagementScreen()
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
            DateTime time = Convert.ToDateTime(dtpEmployee.Value);
            employeeManagement.AddEmployee(tbFirstName.Text, tbLastName.Text, time, tbBSN.Text,
                tbPhoneNumber.Text, tbContractType.Text);
            List<string> EmployeeInfo = new List<string>();
            EmployeeInfo = employeeManagement.ReturnBasicEmployeeInfo();
            for (int i = 0; i< EmployeeInfo.Count; i++)
            {
                lbEmployees.Items.Add(EmployeeInfo[i]);
            }
        }
    }
}
