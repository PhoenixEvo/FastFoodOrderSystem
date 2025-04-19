using DBMS_FinalProject_NHOM03.BS_Layer;
using DBMS_FinalProject_NHOM03.DB_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMS_FinalProject_NHOM03
{
    public partial class Menu_ManagementForm : Form
    {
        DBMain daaa = new DBMain();
        string _sessionID = SessionManager.SessionID;
        private BLMenu blMenu;
        public Menu_ManagementForm()
        {
            InitializeComponent();
            blMenu = new BLMenu(daaa);
            GetMenuManagement();
            cbStatus.Items.AddRange(new[] { "Available", "Out of Stock" });
            cbCategory.Items.AddRange(new[] { "Main course", "Drinks", "Apetizer", "Combo" });
        }
        private void GetMenuManagement()
        {
            DataSet ds = blMenu.GetMenuForManagement();
            DataTable dt = ds.Tables[0];
            dgvMenu.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mid = txtMenuID.Text;
            string fid = txtFoodID.Text;
            string cid = string.IsNullOrEmpty(txtComboID.Text) ? null : txtComboID.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            string category = cbCategory.Text;
            int availableQuantity = int.Parse(txtQuantity.Text);
            string status = cbStatus.Text;
            DataSet success = blMenu.AddSingleDish(mid, fid, cid, price, category, availableQuantity, status);
            if (success != null)
            {
                MessageBox.Show("Adding Successfully!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetMenuManagement();
            }
            else
            {
                MessageBox.Show("Failed to add item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMenuID.Text))
            {
                MessageBox.Show("MenuID cannot be blank!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string menuID = txtMenuID.Text;
            decimal? price = string.IsNullOrEmpty(txtPrice.Text) ? (decimal?)null : decimal.Parse(txtPrice.Text);
            string category = string.IsNullOrEmpty(cbCategory.Text) ? null : cbCategory.Text;
            int? quantity = string.IsNullOrEmpty(txtQuantity.Text) ? (int?)null : int.Parse(txtQuantity.Text);
            string status = string.IsNullOrEmpty(cbStatus.Text) ? null : cbStatus.Text;
            DataSet success = blMenu.UpdateMenuItem(menuID, price, category, quantity, status);

            if (success != null)
            {
                MessageBox.Show("Update Successfully!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetMenuManagement();
            }
            else
            {
                MessageBox.Show("Failed to update item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMenuID.Text))
            {
                MessageBox.Show("MenuID cannot be blank!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataSet success = blMenu.RemoveFoodInMenu(txtMenuID.Text);

                if (success!=null)
                {
                    MessageBox.Show("Deleting Successfully!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetMenuManagement();
                }
                else
                {
                    MessageBox.Show("Failed to delete item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetMenuManagement();
        }
        private void pc_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMenu.Rows[e.RowIndex];
                txtMenuID.Text = row.Cells["MenuID"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtQuantity.Text = row.Cells["AvailableQuantity"].Value.ToString();
                cbCategory.Text = row.Cells["Category"].Value.ToString();
                cbStatus.Text = row.Cells["Status"].Value.ToString();
                if (row.Cells["FoodID"].Value != null && !string.IsNullOrEmpty(row.Cells["FoodID"].Value.ToString()))
                {
                    txtFoodID.Text = row.Cells["FoodID"].Value.ToString();
                    txtComboID.Clear();
                }
                if (row.Cells["ComboID"].Value != null && !string.IsNullOrEmpty(row.Cells["ComboID"].Value.ToString()))
                {
                    txtComboID.Text = row.Cells["ComboID"].Value.ToString();
                    txtFoodID.Clear();
                }
            }
        }
    }
}
