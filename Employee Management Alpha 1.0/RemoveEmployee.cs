﻿using System;
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
    public partial class RemoveEmployee : Form
    {
        Employee_Management employeeManagement;
        public RemoveEmployee()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;

            employeeManagement.RemoveEmployeebyId(id);
            UpdateList();
        }

        private void RemoveEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
