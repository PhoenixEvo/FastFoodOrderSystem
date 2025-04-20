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
    public partial class frmCheckOut : Form
    {
        string _sessionID = SessionManager.SessionID;
        private BLCustomer customerBL;
        //public frmCheckOut(string sessionId)
        //{
        //    InitializeComponent();
        //    Database db = new Database();
        //    customerBL = new BLCustomer(db);
        //}
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        

        public frmCheckOut()
        {
            InitializeComponent();
            Database db = new Database();
            customerBL = new BLCustomer(db);
            txtId.Text = _sessionID;
        }


        

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string house = txtHouseNumber.Text.Trim();
            string street = txtStreet.Text.Trim();
            string ward = txtWard.Text.Trim();
            string district = txtDistrict.Text.Trim();
            string paymentMethod = cboPaymentMethod.SelectedItem?.ToString();

            try
            {
                string orderId;
                string error;

                bool result = customerBL.ConfirmCart(_sessionID, phone, name, district, ward, street, house, paymentMethod, out orderId, out error);

                if (result)
                {
                    MessageBox.Show("Succesfully Creating The Order!\nOrderID: " + orderId,
                                    "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot confirm Order: " + error,
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhoneNumber.Clear();
            txtHouseNumber.Clear();
            txtStreet.Clear();
            txtWard.Clear();
            txtDistrict.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartCustomer crt= new CartCustomer();
            crt.Show();
        }

        private void minimizeButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point loc1 = MousePosition;
                this.Location = loc1;
            }
        }

        private void minimizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessge(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
