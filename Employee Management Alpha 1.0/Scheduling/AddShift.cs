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
    public partial class AddShift : Form
    {
        Employee_Management employeeManagement;
        ShiftManagement shiftManagement;
        const string pattern = @"([^\s]+)"; //pattern to get the first string before a space
        Regex rg = new Regex(pattern);
        public AddShift()
        {
            InitializeComponent();
            UpdateListEmployees();
            UpdateListShifts();
        }

        private void UpdateListEmployees()
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

        private void UpdateListShifts()
        {
            lbShifts.Items.Clear();
            shiftManagement = new ShiftManagement();
            if (shiftManagement.GetAllShifts() is null)
            {
                MessageBox.Show("The database is empty!");
                lbShifts.Items.Add("The database is empty!");
            }
            else
            {
                for (int i = 0; i < shiftManagement.GetAllShifts().Count(); i++)
                {

                    lbShifts.Items.Add(shiftManagement.GetAllShifts()[i].GetShiftInfo());

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbEmployees_Click(object sender, EventArgs e)
        {
            if (!(lbEmployees.SelectedIndex.Equals(null)))
            {
                string ID = lbEmployees.SelectedItem.ToString();
                Match match = Regex.Match(ID, pattern);
                if (match.Success)
                {
                    tbEmpID.Text = match.Value;

                }
            }
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            Tod.TryParse(cbtod.Text.ToString(), out Tod tod);
            DateTime dateOfShift = dtpShift.Value.Date;
            int empID = Convert.ToInt32(tbEmpID.Text);
            shiftManagement.AddShift(empID, dateOfShift.Date, tod);
            UpdateListShifts();
        }
    }
}
