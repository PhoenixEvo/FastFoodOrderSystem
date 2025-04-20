namespace DBMS_FinalProject_NHOM03
{
    partial class CartCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            btnRemove = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            pn_conf = new System.Windows.Forms.Panel();
            btnConfirmOrder = new System.Windows.Forms.Button();
            pc_back = new System.Windows.Forms.PictureBox();
            dgvCart = new System.Windows.Forms.DataGridView();
            pn_cart = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            closeButton = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(195, 227, 235);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(pn_conf);
            panel1.Controls.Add(btnConfirmOrder);
            panel1.Controls.Add(pc_back);
            panel1.Controls.Add(dgvCart);
            panel1.Controls.Add(pn_cart);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1049, 366);
            panel1.TabIndex = 3;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = System.Drawing.Color.Navy;
            btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemove.Font = new System.Drawing.Font("Vinhan", 13F, System.Drawing.FontStyle.Bold);
            btnRemove.ForeColor = System.Drawing.Color.Snow;
            btnRemove.Location = new System.Drawing.Point(157, 312);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(110, 43);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove";
            btnRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.Navy;
            btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Vinhan", 13F, System.Drawing.FontStyle.Bold);
            btnClear.ForeColor = System.Drawing.Color.Snow;
            btnClear.Location = new System.Drawing.Point(16, 312);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(107, 43);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pn_conf
            // 
            pn_conf.BackColor = System.Drawing.Color.Navy;
            pn_conf.BackgroundImage = (System.Drawing.Image)resources.GetObject("pn_conf.BackgroundImage");
            pn_conf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pn_conf.Cursor = System.Windows.Forms.Cursors.Hand;
            pn_conf.Location = new System.Drawing.Point(848, 312);
            pn_conf.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            pn_conf.Name = "pn_conf";
            pn_conf.Size = new System.Drawing.Size(47, 47);
            pn_conf.TabIndex = 11;
            pn_conf.Click += pn_conf_Click;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.BackColor = System.Drawing.Color.Navy;
            btnConfirmOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnConfirmOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmOrder.Font = new System.Drawing.Font("Vinhan", 13F, System.Drawing.FontStyle.Bold);
            btnConfirmOrder.ForeColor = System.Drawing.Color.Snow;
            btnConfirmOrder.Location = new System.Drawing.Point(843, 308);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new System.Drawing.Size(193, 55);
            btnConfirmOrder.TabIndex = 12;
            btnConfirmOrder.Text = "Place Order";
            btnConfirmOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += pn_conf_Click;
            // 
            // pc_back
            // 
            pc_back.BackColor = System.Drawing.Color.FromArgb(195, 227, 235);
            pc_back.Cursor = System.Windows.Forms.Cursors.Hand;
            pc_back.Image = (System.Drawing.Image)resources.GetObject("pc_back.Image");
            pc_back.Location = new System.Drawing.Point(16, 17);
            pc_back.Name = "pc_back";
            pc_back.Size = new System.Drawing.Size(32, 32);
            pc_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pc_back.TabIndex = 10;
            pc_back.TabStop = false;
            pc_back.Click += pc_back_Click;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToResizeColumns = false;
            dgvCart.AllowUserToResizeRows = false;
            dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new System.Drawing.Point(16, 64);
            dgvCart.Name = "dgvCart";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new System.Drawing.Size(1020, 238);
            dgvCart.TabIndex = 9;
            dgvCart.CellBeginEdit += dgvCart_CellBeginEdit;
            dgvCart.CellClick += dgvCart_CellClick;
            dgvCart.CellValueChanged += dgvCart_CellValueChanged;
            // 
            // pn_cart
            // 
            pn_cart.BackColor = System.Drawing.Color.Khaki;
            pn_cart.BackgroundImage = (System.Drawing.Image)resources.GetObject("pn_cart.BackgroundImage");
            pn_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pn_cart.Location = new System.Drawing.Point(1108, 3);
            pn_cart.Name = "pn_cart";
            pn_cart.Size = new System.Drawing.Size(60, 44);
            pn_cart.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Vinhan", 20F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(467, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 46);
            label1.TabIndex = 5;
            label1.Text = "CART";
            // 
            // closeButton
            // 
            closeButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            closeButton.BackColor = System.Drawing.Color.OrangeRed;
            closeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            closeButton.Location = new System.Drawing.Point(1062, 0);
            closeButton.Margin = new System.Windows.Forms.Padding(2);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(20, 20);
            closeButton.TabIndex = 39;
            closeButton.Click += closeButton_Click;
            // 
            // CartCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Navy;
            ClientSize = new System.Drawing.Size(1081, 394);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "CartCustomer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CartCustomer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pn_conf;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.PictureBox pc_back;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel pn_cart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel closeButton;
    }
}