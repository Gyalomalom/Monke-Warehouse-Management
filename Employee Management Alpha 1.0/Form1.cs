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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        //Lists for storing stock information data
        public static List<string> Items = new List<string>();
        public static List<double> PricePerUnit = new List<double>();
        public static List<int> Quantity = new List<int>();
        public static List<int> Amount = new List<int>();

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
            openChildForm(new Form2()); //create new form object
            hideSubmenus();
        }
        
        private void BtnShift_Click(object sender, EventArgs e)
        {
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
            openChildForm(new Stock_information()); // creates and opens stock info
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
            hideSubmenus();

        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
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
    }
}
