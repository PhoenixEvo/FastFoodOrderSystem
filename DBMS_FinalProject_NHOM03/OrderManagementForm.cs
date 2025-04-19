using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_FinalProject_NHOM03.BS_layer;
namespace DBMS_FinalProject_NHOM03
{
    public partial class OrderManagementForm : Form
    {
        private bool byDateclicked = false;
        private bool byPricelicked = false;
        private readonly Database _database;
        private readonly BLOrder _orderBL;
        private DataGridViewComboBoxColumn statusColumn;
        private DataGridViewComboBoxColumn paymentMethodColumn;
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public OrderManagementForm()
        {
            InitializeComponent();
            _database = new Database();
            _orderBL = new BLOrder(_database);
            //SetupDataGridView();\

            LoadOrders();
        }

        private void LoadOrders()
        {
            byDateclicked = false;
            byPricelicked = false;
            From.Visible = false;
            To.Visible = false;
            txtSearch.Visible = true;
            txtSearchPrice1.Visible = false;
            txtSearchPrice2.Visible = false;
            txtSearchPrice1.Visible = false;
            txtSearchPrice2.Visible = false;
            txtSearchPrice2.Clear();
            txtSearchPrice1.Clear();
            dateTimePicker_FromDate.Value = DateTime.Now;
            dateTimePicker_FromDate.Value = DateTime.Now;
            txtSearch.Clear();
            try
            {
                DataSet ds = _orderBL.GetOrderSummary();
                if (ds == null)
                {
                    MessageBox.Show("DataSet returned from GetOrderSummary is null.");
                    return;
                }
                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("No tables found in the DataSet returned from GetOrderSummary.");
                    return;
                }
                DataTable dt = ds.Tables[0];
                if (dt == null)
                {
                    MessageBox.Show("DataTable is null in the DataSet.");
                    return;
                }

                //dgvOrders.Columns.Clear();
                dgvOrders.DataSource = dt;
    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading orders: " + ex.Message);
            }
        }
        private void LoadOrderItems(String OrderID)
        {
            try
            {
                DataSet ds = _orderBL.GetOrderItems(OrderID);
                //MessageBox.Show("CC");
                if (ds == null)
                {
                    MessageBox.Show("DataSet returned from GetOrderItems is null.");
                    return;
                }
                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("No tables found in the DataSet returned from GetOrderItems.");
                    return;
                }
                DataTable dt = ds.Tables[0];
                if (dt == null)
                {
                    MessageBox.Show("DataTable is null in the DataSet.");
                    return;
                }
                dgvOrderItems.DataSource = dt;
                dgvOrderItems.Columns["OrderID"].Visible = false;
                //dgvOrderItems.Columns["O"]

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void SetUpData_StatusColumn()
        {
            statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.HeaderText = "Status";
            statusColumn.Name = "Status";
            statusColumn.DataPropertyName = "Status";
            statusColumn.Items.AddRange("Pending", "Order Confirmed", "In Preparation", "Cancelled", "Out for Delivery");
            statusColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            statusColumn.DisplayIndex = 2;
            statusColumn.Width = 150;
            statusColumn.FlatStyle = FlatStyle.Flat;

            dgvOrders.Columns.Add(statusColumn);
        }
        private void SetUpData_PaymentMethodColumn()
        {
            paymentMethodColumn = new DataGridViewComboBoxColumn();
            paymentMethodColumn.HeaderText = "PaymentMethod";
            paymentMethodColumn.Name = "PaymentMethod";
            paymentMethodColumn.DataPropertyName = "Status";
            paymentMethodColumn.Items.AddRange("Cash");
            //paymentMethodColumn.
            dgvOrders.Columns.Add(paymentMethodColumn);
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0 && dgvOrders.SelectedRows[0].Cells["OrderID"].Value != null)
            {
                String orderId = (String)dgvOrders.SelectedRows[0].Cells["OrderID"].Value;
                //MessageBox.Show("CC");

                LoadOrderItems(orderId);
            }
        }

        private void ShowOrderDetailsGroupBox(String orderId)
        {
            try
            {
                DataSet ds = _orderBL.GetOrderDetails(orderId);
                if (ds.Tables[0].Rows.Count > 0)
                {
            
                    DataRow row = ds.Tables[0].Rows[0];
    
                    txtAddress.Text = row["FullAddress"].ToString();
                    Status_cbx.SelectedItem = row["Status"];
                    txtCustomerName.Text = row["CustomerName"].ToString();
                    txtOrderID.Text = row["OrderID"].ToString();
                    txtPhoneNumber.Text = row["PhoneNumber"].ToString();
                    txtTotalAmount.Text = row["TotalAmount"].ToString();
                    txtNotes.Text = row["Notes"].ToString();
                    dateOrderPicker.Value = Convert.ToDateTime(row["OrderDate"]);
                    PaymentMethod_cbx.SelectedItem = row["PaymentMethod"];
                    //txtPaymentMethod.Text = row["PaymentMethod"].ToString();
                    //txtStatus.Text = row["Status"].ToString();
                    //rtb.Text = details;
                    //detailForm.Controls.Add(rtb);
                    //detailForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading order details: " + ex.Message);
            }
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Status_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = dgvOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (cellValue != null)
                {
                    if (dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value != null)
                    {
                        String orderId = dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                        LoadOrderItems(orderId);
                        ShowOrderDetailsGroupBox(orderId);
                    }
                }
            }
        }

        private void dgvOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (_orderBL.UpdateOrderStatus(txtOrderID.Text.Trim(), Status_cbx.SelectedItem.ToString()))
                {
                    LoadOrders();
                    MessageBox.Show("Sucssfully update the status!!");
                }
                else MessageBox.Show("Failed to Update the Status!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            From.Visible = false;
            To.Visible = false;
            txtSearch.Visible = true;
            txtSearchPrice1.Visible = false;
            txtSearchPrice2.Visible = false;
            dateTimePicker_FromDate.Visible = false;
            dateTimePicker_ToDate.Visible = false;
            string searchValue = txtSearch.Text.Trim();
            DataSet ds = null;
            if (byDateclicked == true)
            {
                ds = _orderBL.SearchOrders(fromDate: Convert.ToDateTime(dateTimePicker_FromDate.Value), toDate: Convert.ToDateTime(dateTimePicker_ToDate.Value));
                dgvOrders.DataSource = ds.Tables[0];
                return;
            }
            else if (byPricelicked == true)
            {
                ds = _orderBL.SearchOrders(minTotalAmount: Convert.ToDecimal(txtSearchPrice1.Text), maxTotalAmount: Convert.ToDecimal(txtSearchPrice2.Text));
                dgvOrders.DataSource = ds.Tables[0];
                return;
            }
            else if (!string.IsNullOrEmpty(searchValue))
            {
                try
                {
                    ds = _orderBL.SearchOrders(phoneNumber: searchValue);

                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dgvOrders.DataSource = ds.Tables[0];
                        return;
                    }
                    ds = _orderBL.SearchOrders(orderID: searchValue);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dgvOrders.DataSource = ds.Tables[0];
                        return;
                    }
                    ds = _orderBL.SearchOrders(customerName: searchValue);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dgvOrders.DataSource = ds.Tables[0];
                        return;
                    }
                    ds = _orderBL.SearchOrders(status: searchValue);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dgvOrders.DataSource = ds.Tables[0];
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while searching Orders: " + ex.Message);
                }
            }
            else
            {
                LoadOrders();
            }
        }

        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byDateclicked = true;
            From.Visible = true;
            To.Visible = true;
            txtSearch.Visible = false;
            txtSearchPrice1.Visible = false;
            txtSearchPrice2.Visible = false;

            dateTimePicker_FromDate.Visible = true;
            dateTimePicker_ToDate.Visible = true;

            txtSearchPrice2.Clear();
            txtSearchPrice1.Clear();
        }

        private void byPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byPricelicked = true;
            From.Visible = true;
            To.Visible = true;
            txtSearch.Visible = false;
            dateTimePicker_FromDate.Visible = false;
            dateTimePicker_ToDate.Visible = false;

            txtSearchPrice1.Visible = true;
            txtSearchPrice2.Visible = true;

            dateTimePicker_FromDate.Value = DateTime.Now;
            dateTimePicker_FromDate.Value = DateTime.Now;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void movePanel_Paint(object sender, PaintEventArgs e)
        {
            //if (e.movePanel == MouseButtons.Left)
            //{

            //    Point loc1 = MousePosition;
            //    this.Location = loc1;
            //}
        }

        private void movePanel_Click(object sender, EventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{

            //    Point loc1 = MousePosition;
            //    this.Location = loc1;
            //}
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

        private void minimizeButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minimizeButton_MouseClick(object sender, MouseEventArgs e)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
;