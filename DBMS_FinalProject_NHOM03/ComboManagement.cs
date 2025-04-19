using DBMS_FinalProject_NHOM03.BS_Layer;
using DBMS_FinalProject_NHOM03.DB_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FinalProject_NHOM03
{
    public partial class Combo_Management : Form
    {
        DBMain dt = new DBMain();
        private BLMenu bl;
        private string ssid = SessionManager.SessionID;

        public Combo_Management()
        {
            InitializeComponent();
            bl = new BLMenu(dt);
            LoadComboandItemTable();
        }
        private void LoadComboandItemTable()
        {
            DataSet ds1 = bl.GetComboForManage();
            DataSet ds2 = bl.GetComboitem();
            DataTable dt1 = ds1.Tables[0];
            DataTable dt2 = ds2.Tables[0];
            dgvCombo.DataSource = dt1;
            dgvComboItem.DataSource = dt2;
            dgvCombo.Columns["Price"].DefaultCellStyle.Format = "N0";
        }
        private void pc_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvCombo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtFoodID.Clear();
                txtQuantity.Clear();
                DataGridViewRow row = dgvCombo.Rows[e.RowIndex];
                txtcbname.Text = row.Cells["ComboName"].Value.ToString();
                txtComboID.Text = row.Cells["ComboID"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string comboID = txtComboID.Text.Trim();
            string foodID = txtFoodID.Text.Trim();
            if (!string.IsNullOrEmpty(comboID) && !string.IsNullOrEmpty(foodID))
            {
                int? quantity = null;
                if (!string.IsNullOrEmpty(txtQuantity.Text.Trim()))
                {
                    if (int.TryParse(txtQuantity.Text.Trim(), out int parsedQuantity))
                    {
                        quantity = parsedQuantity;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid quantity (numeric value).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                DataSet result = bl.UpdateComboItem(comboID, foodID, quantity);
                if (result != null)
                {
                    MessageBox.Show("ComboItem updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadComboandItemTable();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Failed to update ComboItem. Please check your input or database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(comboID) && string.IsNullOrEmpty(foodID))
            {
                string comboName = txtcbname.Text.Trim();
                decimal? price = null;
                if (!string.IsNullOrEmpty(txtPrice.Text.Trim()))
                {
                    if (decimal.TryParse(txtPrice.Text.Trim(), out decimal parsedPrice))
                    {
                        price = parsedPrice;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid price (numeric value).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                DataSet result = bl.UpdateCombo(comboID, comboName, price);
                if (result != null)
                {
                    MessageBox.Show("Combo updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadComboandItemTable();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Failed to update Combo. Please check your input or database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ComboID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearTextBoxes()
        {
            txtComboID.Clear();
            txtFoodID.Clear();
            txtQuantity.Clear();
            txtcbname.Clear();
            txtPrice.Clear();
        }

        private void dgvComboItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPrice.Clear();
                txtcbname.Clear();
                DataGridViewRow row = dgvComboItem.Rows[e.RowIndex];
                txtComboID.Text = row.Cells[0].Value.ToString();
                txtFoodID.Text = row.Cells[1].Value.ToString();
                if (txtQuantity != null && row.Cells[2].Value != null)
                {
                    txtQuantity.Text = row.Cells[2].Value.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string comboID = txtComboID.Text;
            string foodID = txtFoodID.Text;
            string quantity = txtQuantity.Text;
            if (!string.IsNullOrEmpty(comboID) && !string.IsNullOrEmpty(foodID))
            {
                DataSet comboItemResult = bl.AddComboItem(comboID, foodID, quantity);
                if (comboItemResult != null)
                {
                    MessageBox.Show("Food item added to ComboItem successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadComboandItemTable();
                }
                else
                {
                    MessageBox.Show("Failed to add food item to ComboItem.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(comboID) && string.IsNullOrEmpty(foodID))
            {
                string comboName = txtcbname.Text;
                decimal price;
                if (decimal.TryParse(txtPrice.Text, out price))
                {
                    DataSet result = bl.AddCombo(comboID, comboName, price);
                    if (result != null)
                    {
                        MessageBox.Show("Combo added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadComboandItemTable();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add combo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ComboID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string comboID = txtComboID.Text;
            string foodID = txtFoodID.Text;
            if (!string.IsNullOrEmpty(comboID) && !string.IsNullOrEmpty(foodID))
            {
                DataSet result = bl.DeleteComboItem(comboID, foodID);
                if (result != null)
                {
                    MessageBox.Show("ComboItem deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadComboandItemTable();
                }
                else
                {
                    MessageBox.Show("Failed to delete combo item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(comboID) && string.IsNullOrEmpty(foodID))
            {
                DataSet result = bl.RemoveCombo(comboID);
                if (result != null)
                {
                    MessageBox.Show("Combo deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadComboandItemTable();
                }
                else
                {
                    MessageBox.Show("Failed to delete combo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ComboID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearItemTextBoxes()
        {
            txtComboID.Clear();
            txtFoodID.Clear();
            txtQuantity.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadComboandItemTable();
            ClearTextBoxes();
        }
    }
}
