using System.Windows.Forms;

namespace DBMS_FinalProject_NHOM03
{
    partial class OrderManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagementForm));
            label4 = new Label();
            btnSearch = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            label2 = new Label();
            dgvOrderItems = new DataGridView();
            InformationGrBox = new GroupBox();
            btnUpdate = new Button();
            Status_cbx = new ComboBox();
            txtNotes = new TextBox();
            label12 = new Label();
            dateOrderPicker = new DateTimePicker();
            txtTotalAmount = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCustomerName = new TextBox();
            txtOrderID = new TextBox();
            PaymentMethod_cbx = new ComboBox();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            OrderDate = new Label();
            label11 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            txtPaymentMethod = new TextBox();
            txtStatus = new TextBox();
            dgvOrders = new DataGridView();
            toolStrip_Filter = new ToolStrip();
            toolStripButton1 = new ToolStripDropDownButton();
            byDateToolStripMenuItem = new ToolStripMenuItem();
            byPriceToolStripMenuItem = new ToolStripMenuItem();
            txtSearchPrice1 = new TextBox();
            From = new Label();
            To = new Label();
            txtSearchPrice2 = new TextBox();
            dateTimePicker_FromDate = new DateTimePicker();
            dateTimePicker_ToDate = new DateTimePicker();
            closeButton = new Panel();
            minimizeButton = new Panel();
            movePanel = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            logo_picture = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            InformationGrBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            toolStrip_Filter.SuspendLayout();
            movePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(18, 305);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 18);
            label4.TabIndex = 17;
            label4.Text = "Order List:";
            label4.Click += label4_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSearch.Location = new System.Drawing.Point(408, 47);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(100, 36);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(33, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 28);
            label1.TabIndex = 14;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(122, 51);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(266, 27);
            txtSearch.TabIndex = 13;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRefresh.Location = new System.Drawing.Point(1137, 98);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(100, 36);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(967, 152);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 18);
            label2.TabIndex = 16;
            label2.Text = "List OrderItem:";
            label2.Click += label2_Click;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dgvOrderItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrderItems.BackgroundColor = System.Drawing.Color.White;
            dgvOrderItems.BorderStyle = BorderStyle.Fixed3D;
            dgvOrderItems.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvOrderItems.Location = new System.Drawing.Point(958, 174);
            dgvOrderItems.Margin = new Padding(4);
            dgvOrderItems.MultiSelect = false;
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersVisible = false;
            dgvOrderItems.RowHeadersWidth = 82;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.Size = new System.Drawing.Size(401, 589);
            dgvOrderItems.TabIndex = 10;
            dgvOrderItems.CellContentClick += dgvOrderItems_CellContentClick;
            // 
            // InformationGrBox
            // 
            InformationGrBox.AutoSize = true;
            InformationGrBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            InformationGrBox.Controls.Add(btnUpdate);
            InformationGrBox.Controls.Add(Status_cbx);
            InformationGrBox.Controls.Add(txtNotes);
            InformationGrBox.Controls.Add(label12);
            InformationGrBox.Controls.Add(dateOrderPicker);
            InformationGrBox.Controls.Add(txtTotalAmount);
            InformationGrBox.Controls.Add(txtAddress);
            InformationGrBox.Controls.Add(txtPhoneNumber);
            InformationGrBox.Controls.Add(txtCustomerName);
            InformationGrBox.Controls.Add(txtOrderID);
            InformationGrBox.Controls.Add(PaymentMethod_cbx);
            InformationGrBox.Controls.Add(label8);
            InformationGrBox.Controls.Add(label10);
            InformationGrBox.Controls.Add(label9);
            InformationGrBox.Controls.Add(OrderDate);
            InformationGrBox.Controls.Add(label11);
            InformationGrBox.Controls.Add(label7);
            InformationGrBox.Controls.Add(label6);
            InformationGrBox.Controls.Add(label3);
            InformationGrBox.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            InformationGrBox.Location = new System.Drawing.Point(14, 99);
            InformationGrBox.Margin = new Padding(2);
            InformationGrBox.Name = "InformationGrBox";
            InformationGrBox.Padding = new Padding(2);
            InformationGrBox.Size = new System.Drawing.Size(938, 201);
            InformationGrBox.TabIndex = 18;
            InformationGrBox.TabStop = false;
            InformationGrBox.Text = "Order Information";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpdate.Location = new System.Drawing.Point(795, 142);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(120, 32);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update Status";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Status_cbx
            // 
            Status_cbx.FormattingEnabled = true;
            Status_cbx.Items.AddRange(new object[] { "Pending", "Order Confirmed", "In Preparation", "Cancelled", "Out for Delivery" });
            Status_cbx.Location = new System.Drawing.Point(593, 74);
            Status_cbx.Margin = new Padding(2);
            Status_cbx.Name = "Status_cbx";
            Status_cbx.Size = new System.Drawing.Size(114, 28);
            Status_cbx.TabIndex = 17;
            Status_cbx.SelectedIndexChanged += Status_cbx_SelectedIndexChanged;
            // 
            // txtNotes
            // 
            txtNotes.AllowDrop = true;
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.Location = new System.Drawing.Point(795, 50);
            txtNotes.Margin = new Padding(2);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.Size = new System.Drawing.Size(131, 88);
            txtNotes.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(795, 28);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(57, 20);
            label12.TabIndex = 19;
            label12.Text = "Notes:";
            // 
            // dateOrderPicker
            // 
            dateOrderPicker.Enabled = false;
            dateOrderPicker.Format = DateTimePickerFormat.Short;
            dateOrderPicker.Location = new System.Drawing.Point(629, 40);
            dateOrderPicker.Margin = new Padding(2);
            dateOrderPicker.Name = "dateOrderPicker";
            dateOrderPicker.Size = new System.Drawing.Size(142, 28);
            dateOrderPicker.TabIndex = 16;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new System.Drawing.Point(498, 141);
            txtTotalAmount.Margin = new Padding(2);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new System.Drawing.Size(257, 28);
            txtTotalAmount.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(92, 67);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new System.Drawing.Size(433, 28);
            txtAddress.TabIndex = 12;
            txtAddress.TextChanged += textBox5_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(140, 141);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new System.Drawing.Size(226, 28);
            txtPhoneNumber.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(140, 102);
            txtCustomerName.Margin = new Padding(2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new System.Drawing.Size(388, 28);
            txtCustomerName.TabIndex = 10;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(95, 32);
            txtOrderID.Margin = new Padding(2);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new System.Drawing.Size(433, 28);
            txtOrderID.TabIndex = 8;
            // 
            // PaymentMethod_cbx
            // 
            PaymentMethod_cbx.FormattingEnabled = true;
            PaymentMethod_cbx.Items.AddRange(new object[] { "Cash" });
            PaymentMethod_cbx.Location = new System.Drawing.Point(672, 104);
            PaymentMethod_cbx.Margin = new Padding(2);
            PaymentMethod_cbx.Name = "PaymentMethod_cbx";
            PaymentMethod_cbx.Size = new System.Drawing.Size(99, 28);
            PaymentMethod_cbx.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(381, 144);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(116, 20);
            label8.TabIndex = 7;
            label8.Text = "Total Amount:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(530, 108);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(140, 20);
            label10.TabIndex = 5;
            label10.Text = "Payment Method:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(538, 76);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(59, 20);
            label9.TabIndex = 6;
            label9.Text = "Status:";
            // 
            // OrderDate
            // 
            OrderDate.AutoSize = true;
            OrderDate.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            OrderDate.Location = new System.Drawing.Point(538, 42);
            OrderDate.Margin = new Padding(2, 0, 2, 0);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new System.Drawing.Size(90, 20);
            OrderDate.TabIndex = 1;
            OrderDate.Text = "OrderDate:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(17, 67);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(74, 20);
            label11.TabIndex = 4;
            label11.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(17, 142);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(120, 20);
            label7.TabIndex = 3;
            label7.Text = "PhoneNumber:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(17, 104);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(126, 20);
            label6.TabIndex = 2;
            label6.Text = "CustomerName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(17, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 20);
            label3.TabIndex = 0;
            label3.Text = "Order ID:";
            // 
            // txtPaymentMethod
            // 
            txtPaymentMethod.Location = new System.Drawing.Point(797, 35);
            txtPaymentMethod.Margin = new Padding(2);
            txtPaymentMethod.Name = "txtPaymentMethod";
            txtPaymentMethod.ReadOnly = true;
            txtPaymentMethod.Size = new System.Drawing.Size(99, 27);
            txtPaymentMethod.TabIndex = 22;
            txtPaymentMethod.Visible = false;
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(797, 66);
            txtStatus.Margin = new Padding(2);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new System.Drawing.Size(143, 27);
            txtStatus.TabIndex = 21;
            txtStatus.Visible = false;
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle5;
            dgvOrders.Location = new System.Drawing.Point(21, 329);
            dgvOrders.Margin = new Padding(2);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 82;
            dgvOrders.Size = new System.Drawing.Size(898, 446);
            dgvOrders.TabIndex = 20;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            dgvOrders.CellValueChanged += dgvOrders_CellValueChanged;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // toolStrip_Filter
            // 
            toolStrip_Filter.Anchor = AnchorStyles.None;
            toolStrip_Filter.Dock = DockStyle.None;
            toolStrip_Filter.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toolStrip_Filter.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip_Filter.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip_Filter.Location = new System.Drawing.Point(512, 51);
            toolStrip_Filter.Name = "toolStrip_Filter";
            toolStrip_Filter.Size = new System.Drawing.Size(79, 30);
            toolStrip_Filter.TabIndex = 23;
            toolStrip_Filter.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { byDateToolStripMenuItem, byPriceToolStripMenuItem });
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(66, 27);
            toolStripButton1.Text = "Filter";
            // 
            // byDateToolStripMenuItem
            // 
            byDateToolStripMenuItem.Name = "byDateToolStripMenuItem";
            byDateToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
            byDateToolStripMenuItem.Text = "by Date";
            byDateToolStripMenuItem.Click += byDateToolStripMenuItem_Click;
            // 
            // byPriceToolStripMenuItem
            // 
            byPriceToolStripMenuItem.Name = "byPriceToolStripMenuItem";
            byPriceToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
            byPriceToolStripMenuItem.Text = "by Price";
            byPriceToolStripMenuItem.Click += byPriceToolStripMenuItem_Click;
            // 
            // txtSearchPrice1
            // 
            txtSearchPrice1.Location = new System.Drawing.Point(163, 51);
            txtSearchPrice1.Margin = new Padding(4);
            txtSearchPrice1.Name = "txtSearchPrice1";
            txtSearchPrice1.Size = new System.Drawing.Size(83, 27);
            txtSearchPrice1.TabIndex = 24;
            txtSearchPrice1.Visible = false;
            // 
            // From
            // 
            From.AutoSize = true;
            From.BackColor = System.Drawing.SystemColors.ButtonFace;
            From.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            From.Location = new System.Drawing.Point(111, 54);
            From.Margin = new Padding(2, 0, 2, 0);
            From.Name = "From";
            From.Size = new System.Drawing.Size(46, 20);
            From.TabIndex = 23;
            From.Text = "from";
            From.Visible = false;
            // 
            // To
            // 
            To.AutoSize = true;
            To.BackColor = System.Drawing.SystemColors.ButtonFace;
            To.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            To.Location = new System.Drawing.Point(262, 55);
            To.Margin = new Padding(2, 0, 2, 0);
            To.Name = "To";
            To.Size = new System.Drawing.Size(25, 20);
            To.TabIndex = 25;
            To.Text = "to";
            To.Visible = false;
            // 
            // txtSearchPrice2
            // 
            txtSearchPrice2.Location = new System.Drawing.Point(299, 51);
            txtSearchPrice2.Margin = new Padding(4);
            txtSearchPrice2.Name = "txtSearchPrice2";
            txtSearchPrice2.Size = new System.Drawing.Size(83, 27);
            txtSearchPrice2.TabIndex = 26;
            txtSearchPrice2.Visible = false;
            // 
            // dateTimePicker_FromDate
            // 
            dateTimePicker_FromDate.Format = DateTimePickerFormat.Short;
            dateTimePicker_FromDate.Location = new System.Drawing.Point(161, 53);
            dateTimePicker_FromDate.Margin = new Padding(2);
            dateTimePicker_FromDate.Name = "dateTimePicker_FromDate";
            dateTimePicker_FromDate.Size = new System.Drawing.Size(97, 27);
            dateTimePicker_FromDate.TabIndex = 27;
            dateTimePicker_FromDate.Visible = false;
            // 
            // dateTimePicker_ToDate
            // 
            dateTimePicker_ToDate.Format = DateTimePickerFormat.Short;
            dateTimePicker_ToDate.Location = new System.Drawing.Point(291, 53);
            dateTimePicker_ToDate.Margin = new Padding(2);
            dateTimePicker_ToDate.Name = "dateTimePicker_ToDate";
            dateTimePicker_ToDate.Size = new System.Drawing.Size(106, 27);
            dateTimePicker_ToDate.TabIndex = 28;
            dateTimePicker_ToDate.Visible = false;
            // 
            // closeButton
            // 
            closeButton.BackColor = System.Drawing.Color.OrangeRed;
            closeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.Location = new System.Drawing.Point(1308, -1);
            closeButton.Margin = new Padding(2);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(54, 34);
            closeButton.TabIndex = 30;
            closeButton.Click += closeButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.BackColor = System.Drawing.Color.LimeGreen;
            minimizeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("minimizeButton.BackgroundImage");
            minimizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            minimizeButton.Location = new System.Drawing.Point(1256, -1);
            minimizeButton.Margin = new Padding(2);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new System.Drawing.Size(54, 34);
            minimizeButton.TabIndex = 32;
            minimizeButton.Click += minimizeButton_Click;
            minimizeButton.MouseClick += minimizeButton_MouseClick;
            // 
            // movePanel
            // 
            movePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            movePanel.BackColor = System.Drawing.Color.Navy;
            movePanel.Controls.Add(pictureBox2);
            movePanel.Controls.Add(label5);
            movePanel.Location = new System.Drawing.Point(-1, -1);
            movePanel.Margin = new Padding(2);
            movePanel.Name = "movePanel";
            movePanel.Size = new System.Drawing.Size(1263, 34);
            movePanel.TabIndex = 34;
            movePanel.Click += movePanel_Click;
            movePanel.Paint += movePanel_Paint;
            movePanel.MouseDown += movePanel_MouseDown;
            movePanel.MouseMove += movePanel_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Navy;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(2, 1);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(34, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label5.Location = new System.Drawing.Point(36, 2);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(238, 29);
            label5.TabIndex = 35;
            label5.Text = "Order Management";
            // 
            // logo_picture
            // 
            logo_picture.BackgroundImageLayout = ImageLayout.None;
            logo_picture.Image = (System.Drawing.Image)resources.GetObject("logo_picture.Image");
            logo_picture.Location = new System.Drawing.Point(1116, 36);
            logo_picture.Margin = new Padding(2);
            logo_picture.Name = "logo_picture";
            logo_picture.Size = new System.Drawing.Size(248, 135);
            logo_picture.SizeMode = PictureBoxSizeMode.Zoom;
            logo_picture.TabIndex = 35;
            logo_picture.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(7, 42);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(27, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1362, 780);
            Controls.Add(pictureBox1);
            Controls.Add(logo_picture);
            Controls.Add(minimizeButton);
            Controls.Add(closeButton);
            Controls.Add(dateTimePicker_ToDate);
            Controls.Add(dateTimePicker_FromDate);
            Controls.Add(txtPaymentMethod);
            Controls.Add(To);
            Controls.Add(txtSearchPrice2);
            Controls.Add(From);
            Controls.Add(txtSearchPrice1);
            Controls.Add(toolStrip_Filter);
            Controls.Add(dgvOrders);
            Controls.Add(txtStatus);
            Controls.Add(InformationGrBox);
            Controls.Add(label4);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(dgvOrderItems);
            Controls.Add(movePanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "OrderManagementForm";
            Text = "OrderManagementForm";
            Load += OrderManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            InformationGrBox.ResumeLayout(false);
            InformationGrBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            toolStrip_Filter.ResumeLayout(false);
            toolStrip_Filter.PerformLayout();
            movePanel.ResumeLayout(false);
            movePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.GroupBox InformationGrBox;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateOrderPicker;
        private System.Windows.Forms.ComboBox PaymentMethod_cbx;
        private System.Windows.Forms.ComboBox Status_cbx;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ToolStrip toolStrip_Filter;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem byDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPriceToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearchPrice1;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.TextBox txtSearchPrice2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ToDate;
        private System.Windows.Forms.Panel closeButton;
        private System.Windows.Forms.Panel minimizeButton;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.Label label5;
        private PictureBox logo_picture;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}