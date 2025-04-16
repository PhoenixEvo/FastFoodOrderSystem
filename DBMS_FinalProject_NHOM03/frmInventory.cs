    using DBMS_FinalProject_NHOM03.BS_layer;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace DBMS_FinalProject_NHOM03
    {
        public partial class frmInventory : Form
        {
            private BLInventory inventoryBL;
            [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.dll", EntryPoint = "SendMessage")]
            private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
            public frmInventory()
            {
                InitializeComponent();
                Database db = new Database();
                inventoryBL = new BLInventory(db);

                LoadInventoryData();
            }
            private void frmInventory_Load(object fsender, EventArgs e)
            {

            }
            private void LoadInventoryData()
            {
                try
                {
                    DataSet ds = inventoryBL.GetInventoryDetails();
                    dgvInventory.AutoGenerateColumns = true;
                    dgvInventory.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading inventory: " + ex.Message);
                }
            }

            private void btnLoad_Click(object sender, EventArgs e)
            {
                LoadInventoryData();
            }

            private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                string id = txtFoodID.Text;
                string name = txtFoodName.Text;
                decimal cost = decimal.Parse(txtCostPrice.Text);
                int quantity = (int)nudQuantity.Value;
                DateTime restockDate = dtpRestockDate.Value;
                string status = cbStatus.SelectedItem.ToString();

                inventoryBL.AddNewFood(id, name, cost, quantity, restockDate, status);
                LoadInventoryData();
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                string id = txtFoodID.Text;
                string name = txtFoodName.Text;
                decimal cost = decimal.Parse(txtCostPrice.Text);
                int quantity = (int)nudQuantity.Value;
                DateTime restockDate = dtpRestockDate.Value;
                string status = cbStatus.SelectedItem.ToString();

                inventoryBL.UpdateFoodInfo(id, name, cost, quantity, restockDate, status);
                LoadInventoryData();
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (dgvInventory.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvInventory.SelectedRows[0];

                    // Lấy FoodID từ dòng được chọn (cột phải trùng tên trong DataTable)
                    string foodID = selectedRow.Cells["FoodID"].Value.ToString();

                    var confirm = MessageBox.Show("Bạn có chắc muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        string result = inventoryBL.DeleteFood(foodID);
                        MessageBox.Show(result);
                        LoadInventoryData();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng để xóa.");
                }
            }

            private void movePanel_Paint(object sender, PaintEventArgs e)
            {

            }
            public void DeleteTextBox()
            {
                txtCostPrice.Clear();
                txtFoodName.Clear();

            }
            private void movePanel_MouseMove(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point loc1 = MousePosition;
                    this.Location = loc1;
                }
            }

            private void movePanel_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessge(this.Handle, 0x112, 0xf012, 0);
            }

            private void closeButton_Paint(object sender, PaintEventArgs e)
            {

            }

            private void minimizeButton_Paint(object sender, PaintEventArgs e)
            {
            }

            private void closeButton_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void minimizeButton_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            private void dgvInventory_SelectionChanged(object sender, EventArgs e)
            {
                if (dgvInventory.SelectedRows.Count > 0)
                {
                    var row = dgvInventory.SelectedRows[0];
                    txtFoodID.Text = row.Cells["FoodID"].Value?.ToString();
                    txtFoodName.Text = row.Cells["FoodName"].Value?.ToString();
                    txtCostPrice.Text = row.Cells["Price_VND"].Value?.ToString();


                    if (int.TryParse(row.Cells["Current_Stock"].Value?.ToString(), out int stock))
                        nudQuantity.Value = stock;

                    if (DateTime.TryParse(row.Cells["LastRestockDate"].Value?.ToString(), out DateTime restockDate))
                        dtpRestockDate.Value = restockDate;

                    cbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
                }
            }
        }
    }
