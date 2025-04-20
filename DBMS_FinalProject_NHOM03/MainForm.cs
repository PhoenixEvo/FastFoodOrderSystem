using DBMS_FinalProject_NHOM03.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FinalProject_NHOM03
{
    public partial class MainForm : Form
    {
        private bool isLogin = false;
        Database db = new Database();
        string _sessionID = SessionManager.SessionID;
        private BLMenu blMenu;
        string productName;
        private string selectedFoodId = "";
        private string selectedFoodName = "";
        private decimal selectedFoodPrice = 0;
        private bool isMenuItemSelected = false;

        private string selectedComboId = "";
        private string selectedComboName = "";
        private decimal selectedComboPrice = 0;
        private bool isComboSelected = false;
        public MainForm()
        {
            InitializeComponent();
            ConfigureUIByUserRole(CurrentUser.Role);
            blMenu = new BLMenu(db);
            txtid.Text = _sessionID;
            ShowMenu();
            GetCombo();
        }
        private void CustomerFormShow()
        {
            isLogin = false;
            btnTrackOrStt.Visible = false;
            btnMenuManagement.Visible = false;
            btnComboManagement.Visible = false;
            btnOrderM.Visible = false;
        }
        private void ShowMenu()
        {
            DataSet ds = blMenu.LoadMenu();
            DataTable dt = ds.Tables[0];
            dgvMenu.DataSource = dt;
            dgvMenu.Columns["Price"].DefaultCellStyle.Format = "N0";
        }
        private void GetCombo()
        {
            DataTable cb = blMenu.GetCombo();
            dgvCombo.DataSource = cb;
            dgvCombo.Columns["Price"].DefaultCellStyle.Format = "N0";
        }

        private void btnOrderM_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderManagementForm frmOrderManage = new OrderManagementForm();
            frmOrderManage.Show();
        }

        private void btnTrackOrStt_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackingOrderStatusForm frmTrackingOrder = new TrackingOrderStatusForm();
            frmTrackingOrder.Show();
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedFoodId = dgvMenu.Rows[e.RowIndex].Cells["FoodID"].Value?.ToString() ?? "";
                selectedFoodName = dgvMenu.Rows[e.RowIndex].Cells["FoodName"].Value?.ToString() ?? "";
                if (decimal.TryParse(dgvMenu.Rows[e.RowIndex].Cells["Price"].Value?.ToString(), out decimal price))
                {
                    selectedFoodPrice = price;
                }
                isMenuItemSelected = true;

            }
        }

        private void dgvCombo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedComboId = dgvCombo.Rows[e.RowIndex].Cells["ComboID"].Value?.ToString() ?? "";
                selectedComboName = dgvCombo.Rows[e.RowIndex].Cells["ComboName"].Value?.ToString() ?? "";
                if (decimal.TryParse(dgvCombo.Rows[e.RowIndex].Cells["Price"].Value?.ToString(), out decimal price))
                {
                    selectedComboPrice = price;
                }
                isComboSelected = true;
            }
        }

        private void pn_cart_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartCustomer cart = new CartCustomer();
            cart.Show();
        }
        private void pn_cart_MouseEnter(object sender, EventArgs e)
        {
            pn_cart.BackColor = ColorTranslator.FromHtml("#219ebc");
        }
        private void pn_cart_MouseLeave(object sender, EventArgs e)
        {
            pn_cart.BackColor = Color.FromArgb(195, 227, 235);
        }
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (!isMenuItemSelected && !isComboSelected)
            {
                MessageBox.Show("Please select a food item or a combo before adding to the cart.");
                return;
            }
            string sessionID = _sessionID.ToString();
            string fid = isMenuItemSelected ? selectedFoodId.ToString() : null;
            string cid = isComboSelected ? selectedComboId.ToString() : null;
            int quantity = 1;
            DataSet crt = blMenu.AddFoodToCart(sessionID, fid, cid, quantity);

            if (crt != null) MessageBox.Show("Added successfully");
            else MessageBox.Show("Failed to add!");
        }

        private void btnMenuManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_ManagementForm Menu_manage = new Menu_ManagementForm();
            Menu_manage.Show();
        }

        private void btnComboManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Combo_Management cm = new Combo_Management();
            cm.Show();
        }
        public void ConfigureUIByUserRole(string role)
        {
            bool isAdmin = (role == "Admin");


            btnMenuManagement.Visible = true;
            btnComboManagement.Visible = true;
            btnOrderM.Visible = true;
            btnTrackOrStt.Visible = true;

            // Các chức năng chỉ dành cho admin
            btnMenuManagement.Visible = isAdmin;
            btnComboManagement.Visible = isAdmin;
            btnOrderM.Visible = isAdmin;
            btnTrackOrStt.Visible = isAdmin;

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
