using DBMS_FinalProject_NHOM03.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DBMS_FinalProject_NHOM03.MainForm;

namespace DBMS_FinalProject_NHOM03.DB_Layer
{
    public partial class CartForCustomer : Form
    {
        private BLMenu blMenu;
        private string _sessionID;
        private int selectedproduct = -1;
        public CartForCustomer()
        {
            InitializeComponent();
            blMenu = new BLMenu(new DBMain());
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

        private void pn_conf_Click(object sender, EventArgs e)
        {
            try
            {
                Guid? orderID = null;
                DataSet result = blMenu.ProcessCart(
                    "CONFIRM",     // action
                    _sessionID,    // sessionID
                    null,          // foodID
                    null,          // comboID
                    0,             // quantity
                    0,             // price
                    out orderID,   // output parameter cho orderID
                    null,          // phoneNumber
                    null,          // customerName
                    null,          // district
                    null,          // ward
                    null,          // street
                    null           // houseNumber
                );

                if (orderID.HasValue)
                {
                    MessageBox.Show($"Đơn hàng đã được xác nhận thành công. Mã đơn hàng: {orderID.Value}",
                                   "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mã đơn hàng được trả về, bạn có thể sử dụng nó để mở form khách hàng hoặc xử lý tiếp theo
                    // OpenCustomerInfoForm(orderID.Value);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi xác nhận đơn hàng hoặc giỏ hàng trống.",
                                   "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pc_back_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void pc_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                        break;
                    }
                }
                selectedproduct = -1;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!");
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
    }
}
