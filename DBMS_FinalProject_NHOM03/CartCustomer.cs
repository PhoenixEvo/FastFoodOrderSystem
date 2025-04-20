using DBMS_FinalProject_NHOM03.BS_layer;
using DBMS_FinalProject_NHOM03.DB_layer;
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
    public partial class CartCustomer : Form
    {
        private BLMenu blMenu;
        private string _sessionID;
        private int selectedproduct = -1;
        public CartCustomer()
        {
            InitializeComponent();
            blMenu = new BLMenu(new Database());
            _sessionID = SessionManager.SessionID;
            ShowCart();
        }
        private void ShowCart()
        {
            DataSet dataSet = blMenu.ViewCart(_sessionID);
            DataTable dt = dataSet.Tables[0];
            dgvCart.DataSource = dt;
            dgvCart.Columns["FoodID"].Visible = false;
            dgvCart.Columns["ComboID"].Visible = false;

            dgvCart.Columns["Price"].DefaultCellStyle.Format = "N0";
            dgvCart.Columns["TotalPrice"].DefaultCellStyle.Format = "N0";
        }
        private void pc_back_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            blMenu.ClearCart(_sessionID);
            ShowCart();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedproduct != -1)
            {
                blMenu.RemoveFoodFromCart(_sessionID, selectedproduct.ToString());
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ProductID"].Value) == selectedproduct)
                    {
                        dgvCart.Rows.Remove(row);
                        MessageBox.Show("Deleted seleced item!!");
                        break;
                    }
                }
                selectedproduct = -1;
            }
            else
            {
                MessageBox.Show("You have not chose an item to delete!");
            }
        }

        private void pn_conf_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCheckOut mf = new frmCheckOut();
            mf.Show();
        }


        private void dgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns["Quantity"].Index)
            {
                int newQuantity = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["Quantity"].Value);
                int productID = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["ProductID"].Value);
                string sessionID = _sessionID;
                decimal newTotalPrice = blMenu.CalCulaTotalPrice(sessionID, productID, newQuantity);
                dgvCart.Rows[e.RowIndex].Cells["TotalPrice"].Value = newTotalPrice;
                blMenu.UpdateCartItemTotalPrice(sessionID, productID, newQuantity, newTotalPrice);
            }
        }

        private void dgvCart_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvCart.Columns[e.ColumnIndex].Name != "Quantity")
            {
                e.Cancel = true;
            }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedproduct = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["ProductID"].Value);
                dgvCart.Rows[e.RowIndex].Selected = true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
