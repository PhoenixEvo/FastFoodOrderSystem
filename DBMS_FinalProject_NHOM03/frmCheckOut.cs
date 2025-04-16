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
    public partial class frmCheckOut : Form
    {
        private BLCustomer customerBL;

        public frmCheckOut()
        {
            InitializeComponent();
            Database db = new Database(); 
            customerBL = new BLCustomer(db);
        }


        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhoneNumber.Text;
            string house = txtHouseNumber.Text;
            string street = txtStreet.Text;
            string ward = txtWard.Text;
            string district = txtDistrict.Text;

            try
            {
                customerBL.AddNewCustomer(phone, name, district, ward, street, house);

                customerBL.AddOrderWithAddress(phone);

                MessageBox.Show("Customer and order saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
    }
}
