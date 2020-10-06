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
    public partial class Form1 : Form
    {
        Stock stock;

        public Form1()
        {
            InitializeComponent();
            stock = new Stock();
            
        }
        


        public void hideSubmenus() //method for hiding submenus
        {
            panelStatisticsSubmenu.Visible = false;
            panelDepSubmenu.Visible = false;
            panelEmpSubmenu.Visible = false;
            panelStockSubmenu.Visible = false;
        }

        public void showSubmenus(Panel subMenu) //method for controlling the dropdown menu visibility
        {
            if (subMenu.Visible == false) //opens selected dropdown submenu and closes all other submenus
            {
                hideSubmenus();
                subMenu.Visible = true;
            }
            else //closes active submenu by clicking again
                subMenu.Visible = false;
        }

        private void BtnEmpMan_Click(object sender, EventArgs e) 
        {
            showSubmenus(panelEmpSubmenu);
        }
        #region EmpSub 
        private void BtnModEmp_Click(object sender, EventArgs e) //when programming submenu buttons, always leave hideSubmenus() method as last line of code
        {
            openChildForm(new AddEmployee()); //create new form object
            hideSubmenus();
        }

        private void BtnEmpInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new AllEmployees()); 
            hideSubmenus();
        }

        private void BtnRemoveEmp_Click(object sender, EventArgs e)
        {
            openChildForm(new RemoveEmployee());

            hideSubmenus();
        }
        private void BtnEmpStatus_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeChangeStatus());
            hideSubmenus();
        }

        private void BtnDep_Click(object sender, EventArgs e)
        {
            hideSubmenus();
        }
        #endregion
        private void BtnStockMan_Click(object sender, EventArgs e)
        {
            showSubmenus(panelStockSubmenu);
        }
        #region StockSub
        private void BtnModStock_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStock()); // creates and opens add stock form
            hideSubmenus();
        }
        #endregion
        private void BtnDepMan_Click(object sender, EventArgs e)
        {
            showSubmenus(panelDepSubmenu);
        }
        #region DepSub
        private void BtnModDep_Click(object sender, EventArgs e)
        {
            openChildForm(new AddDepartment());
            hideSubmenus();

        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            openChildForm(new RemoveDepartment());
            hideSubmenus();
        }
        #endregion
        private void BtnStats_Click(object sender, EventArgs e)
        {
            showSubmenus(panelStatisticsSubmenu);
        }
        #region StatSub
        private void BtnViewStats_Click(object sender, EventArgs e)
        {
            hideSubmenus();
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm) //method that creates a new Form object when switching between pages 
        {
            if(activeForm != null)
            
                activeForm.Close(); //close active child form
                activeForm = childForm; //store active form object
                childForm.TopLevel = false; //child form will behave like a control
                childForm.FormBorderStyle = FormBorderStyle.None; //turn off borders
                childForm.Dock = DockStyle.Fill; //set dock to fill to fill out entire panel
                panelChildForm.Controls.Add(childForm); //add child form to panel
                panelChildForm.Tag = childForm; //assign tag to Form object
                childForm.BringToFront(); //bring to front to cover logo on home page
                childForm.Show(); //
            
        }

        private void BtnCloseApp_Click(object sender, EventArgs e) //close application
        {
            Application.Exit();
        }

        private void PanelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BtnRemoveStock_Click_1(object sender, EventArgs e)
        {
            openChildForm(new RemoveStock()); // creates and opens Remove Stock form
            hideSubmenus();
        }

        private void BtnStockInfo_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Stock_information()); // creates and opens stock info
            hideSubmenus();
        }

        private void BtnDepStatus_Click(object sender, EventArgs e)
        {
            openChildForm(new DepartmentInfo());
            hideSubmenus();
        }

        private void btnShitManager_Click(object sender, EventArgs e)
        {
            openChildForm(new AddShift());
            hideSubmenus();
        }
    }
}
