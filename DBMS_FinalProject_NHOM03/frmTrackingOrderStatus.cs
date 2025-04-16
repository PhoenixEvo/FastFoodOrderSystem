// frmTrackingOrderStatus.cs
using DBMS_FinalProject_NHOM03.BS_layer;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBMS_FinalProject_NHOM03
{
    public partial class TrackingOrderStatusForm : Form
    {
        private readonly Database _database;
        private readonly BLTrackingOrder _trackingBL;
        //string connectionString
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public TrackingOrderStatusForm()
        {
            InitializeComponent();
            _database = new Database();
            _trackingBL = new BLTrackingOrder(_database);

        }


        private void btnTrack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                String orderId = (txtOrderID.Text.Trim());
                //string orderId = txtOrderID.Text.Trim();

                LoadOrderInfo(orderId);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã đơn hàng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrderInfo(String orderId)
        {
            StringBuilder orderItemsDetails = new StringBuilder();
            string details = string.Empty;
            try
            {
                DataSet ds2 = _trackingBL.GetOrderItems(orderId);
                if (ds2.Tables.Count > 0)
                {
                    foreach (DataRow itemRow in ds2.Tables[0].Rows)
                    {
                        string orderItem = itemRow["ItemID"].ToString();
                        string orderItemName = itemRow["ItemName"].ToString();
                        string quantity = itemRow["Quantity"].ToString();
                        orderItemsDetails.AppendLine($"{orderItemName}:_ {quantity}");
                    }
                }
                DataSet ds = _trackingBL.GetOrderDetails(orderId);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    Form detailForm = new Form();
                    details = $"OrderID: {row["OrderID"]}\n" +
                                $"Date Order: {Convert.ToDateTime(row["OrderDate"]):dd/MM/yyyy HH:mm}\n" +
                                $"Status: {row["Status"]}\n" +
                                $"Customer: {row["CustomerName"]}\n" +
                                $"PhoneNumber: {row["PhoneNumber"]}\n" +
                                $"Address: {row["FullAddress"]}\n\n" +
                                $"OrderItem Details:\n{orderItemsDetails.ToString()}" +
                                $"Total Amount: {Convert.ToDecimal(row["TotalAmount"]):N0} VND\n";
                }
                DisplayOrderDetails(details);
                //DisplayOrderIn4.Text = details;
                //DisplayOrderIn4.Select(0, "OrderItem".Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị chi tiết đơn hàng: " + ex.Message);
            }
        }
        private void AdjustRichTextBoxSize(RichTextBox rtb)
        {
            Size size = TextRenderer.MeasureText(rtb.Text, rtb.Font);
            Size size2 = rtb_Dis.Size;
            rtb.ClientSize = new Size(size2.Width, size.Height);
        }
        private void DisplayOrderDetails(string details)
        {
            rtb_Dis.Clear();
            rtb_Dis.AppendText(details);
            string[] keywords = { "OrderID:", "Date Order:", "Status:", "Customer:", "PhoneNumber:", "Address:", "OrderItem Details:", "Total Amount:" };
            foreach (string keyword in keywords)
            {
                int startIndex = rtb_Dis.Text.IndexOf(keyword);
                if (startIndex >= 0)
                {
                    rtb_Dis.Select(startIndex, keyword.Length);
                    rtb_Dis.SelectionFont = new Font(rtb_Dis.Font, FontStyle.Bold);
                }
            }
            AdjustRichTextBoxSize(rtb_Dis);
        }

        private void groupBoxInfo_Enter(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void PlaceDisplayIn4_Click(object sender, EventArgs e)
        {

        }

        private void OrderIn4Grbx_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void minimizeButton_Click(object sender, EventArgs e)//minimize place
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)//exit place
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)//move panel
        {
            ReleaseCapture();
            SendMessge(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)//move panel
        {
            if (e.Button == MouseButtons.Left)
            {
                Point loc1 = MousePosition;
                this.Location = loc1;
            }
        }

        private void closeButton_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}