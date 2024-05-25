using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_HomePage1.Visible = true;
            btnHomePage.PerformClick();
        }
        //các nút button
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            uC_HomePage1.Visible = true;
            uC_HomePage1.BringToFront();
        }
        
        private void btnCategory_Click_1(object sender, EventArgs e)
        {
            uC_Category1.Visible = true;
            uC_Category1.BringToFront();
        }
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            uC_Menu1.Visible = true;
            uC_Menu1.BringToFront();
        }
        
        private void btnRevenue_Click(object sender, EventArgs e)
        {
            uC_Revenue1.Visible = true;
            uC_Revenue1.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            uC_User1.Visible = true;
            uC_User1.BringToFront();
        }

        private void btnTableList_Click_1(object sender, EventArgs e)
        {
            uC_TableList1.Visible = true;
            uC_TableList1.BringToFront();
        }

        private void btnBill_Click_1(object sender, EventArgs e)
        {
            uC_Bill1.Visible = true;
            uC_Bill1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Các mục không tác dụng k động đến======================
        private void btnCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnTableList_Click(object sender, EventArgs e)
        {

        }
        
        private void btnBill_Click(object sender, EventArgs e)
        {

        }

        //========================================================
    }
}
