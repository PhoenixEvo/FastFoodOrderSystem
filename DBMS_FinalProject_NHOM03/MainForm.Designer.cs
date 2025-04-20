namespace DBMS_FinalProject_NHOM03
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            btnLogin = new System.Windows.Forms.Button();
            btnComboManagement = new System.Windows.Forms.Button();
            btnMenuManagement = new System.Windows.Forms.Button();
            dgvMenu = new System.Windows.Forms.DataGridView();
            btnAddCart = new System.Windows.Forms.Button();
            pn_cart = new System.Windows.Forms.Panel();
            dgvCombo = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnOrderM = new System.Windows.Forms.Button();
            btnTrackOrStt = new System.Windows.Forms.Button();
            closeButton = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(195, 227, 235);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnComboManagement);
            panel1.Controls.Add(btnMenuManagement);
            panel1.Controls.Add(dgvMenu);
            panel1.Controls.Add(btnAddCart);
            panel1.Controls.Add(pn_cart);
            panel1.Controls.Add(dgvCombo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnOrderM);
            panel1.Controls.Add(btnTrackOrStt);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1210, 589);
            panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.Navy;
            btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.Font = new System.Drawing.Font("Vinhan", 10F, System.Drawing.FontStyle.Bold);
            btnLogin.ForeColor = System.Drawing.Color.Snow;
            btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            btnLogin.Location = new System.Drawing.Point(43, 514);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(93, 49);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnComboManagement
            // 
            btnComboManagement.BackColor = System.Drawing.Color.Navy;
            btnComboManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnComboManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            btnComboManagement.Font = new System.Drawing.Font("Vinhan", 10F, System.Drawing.FontStyle.Bold);
            btnComboManagement.ForeColor = System.Drawing.Color.Snow;
            btnComboManagement.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            btnComboManagement.Location = new System.Drawing.Point(0, 371);
            btnComboManagement.Name = "btnComboManagement";
            btnComboManagement.Size = new System.Drawing.Size(185, 49);
            btnComboManagement.TabIndex = 13;
            btnComboManagement.Text = "Combo Management";
            btnComboManagement.UseVisualStyleBackColor = false;
            btnComboManagement.Click += btnComboManagement_Click;
            // 
            // btnMenuManagement
            // 
            btnMenuManagement.BackColor = System.Drawing.Color.Navy;
            btnMenuManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnMenuManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuManagement.Font = new System.Drawing.Font("Vinhan", 10F, System.Drawing.FontStyle.Bold);
            btnMenuManagement.ForeColor = System.Drawing.Color.Snow;
            btnMenuManagement.Location = new System.Drawing.Point(1, 290);
            btnMenuManagement.Name = "btnMenuManagement";
            btnMenuManagement.Size = new System.Drawing.Size(184, 49);
            btnMenuManagement.TabIndex = 12;
            btnMenuManagement.Text = "Menu Management";
            btnMenuManagement.UseVisualStyleBackColor = false;
            btnMenuManagement.Click += btnMenuManagement_Click;
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
            dgvMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvMenu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Location = new System.Drawing.Point(284, 53);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMenu.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(204, 119, 34);
            dgvMenu.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvMenu.Size = new System.Drawing.Size(914, 234);
            dgvMenu.TabIndex = 11;
            dgvMenu.CellClick += dgvMenu_CellClick;
            // 
            // btnAddCart
            // 
            btnAddCart.BackColor = System.Drawing.Color.Navy;
            btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddCart.Font = new System.Drawing.Font("Vinhan", 10.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddCart.ForeColor = System.Drawing.Color.White;
            btnAddCart.Location = new System.Drawing.Point(1053, 519);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new System.Drawing.Size(134, 44);
            btnAddCart.TabIndex = 1;
            btnAddCart.Text = "Add to Cart";
            btnAddCart.UseVisualStyleBackColor = false;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // pn_cart
            // 
            pn_cart.BackColor = System.Drawing.Color.FromArgb(195, 227, 235);
            pn_cart.BackgroundImage = (System.Drawing.Image)resources.GetObject("pn_cart.BackgroundImage");
            pn_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pn_cart.Cursor = System.Windows.Forms.Cursors.Hand;
            pn_cart.Location = new System.Drawing.Point(1148, 3);
            pn_cart.Name = "pn_cart";
            pn_cart.Size = new System.Drawing.Size(60, 40);
            pn_cart.TabIndex = 8;
            pn_cart.Click += pn_cart_Click;
            pn_cart.MouseEnter += pn_cart_MouseEnter;
            pn_cart.MouseLeave += pn_cart_MouseLeave;
            // 
            // dgvCombo
            // 
            dgvCombo.AllowUserToAddRows = false;
            dgvCombo.AllowUserToDeleteRows = false;
            dgvCombo.AllowUserToResizeColumns = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
            dgvCombo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCombo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCombo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvCombo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvCombo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombo.Location = new System.Drawing.Point(326, 308);
            dgvCombo.Name = "dgvCombo";
            dgvCombo.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCombo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCombo.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(204, 119, 34);
            dgvCombo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCombo.Size = new System.Drawing.Size(819, 171);
            dgvCombo.TabIndex = 7;
            dgvCombo.CellClick += dgvCombo_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Vinhan", 15F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(193, 293);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 34);
            label2.TabIndex = 6;
            label2.Text = "Combo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Vinhan", 15F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(192, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 34);
            label1.TabIndex = 5;
            label1.Text = "Menu";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(23, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(126, 92);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox1.Location = new System.Drawing.Point(184, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1024, 539);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnOrderM
            // 
            btnOrderM.BackColor = System.Drawing.Color.Navy;
            btnOrderM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnOrderM.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOrderM.Font = new System.Drawing.Font("Vinhan", 10F, System.Drawing.FontStyle.Bold);
            btnOrderM.ForeColor = System.Drawing.Color.Snow;
            btnOrderM.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            btnOrderM.Location = new System.Drawing.Point(0, 126);
            btnOrderM.Name = "btnOrderM";
            btnOrderM.Size = new System.Drawing.Size(185, 49);
            btnOrderM.TabIndex = 1;
            btnOrderM.Text = "Order Management";
            btnOrderM.UseVisualStyleBackColor = false;
            btnOrderM.Click += btnOrderM_Click;
            // 
            // btnTrackOrStt
            // 
            btnTrackOrStt.BackColor = System.Drawing.Color.Navy;
            btnTrackOrStt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnTrackOrStt.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTrackOrStt.Font = new System.Drawing.Font("Vinhan", 10F, System.Drawing.FontStyle.Bold);
            btnTrackOrStt.ForeColor = System.Drawing.Color.Snow;
            btnTrackOrStt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            btnTrackOrStt.Location = new System.Drawing.Point(0, 210);
            btnTrackOrStt.Name = "btnTrackOrStt";
            btnTrackOrStt.Size = new System.Drawing.Size(185, 49);
            btnTrackOrStt.TabIndex = 2;
            btnTrackOrStt.Text = "Tracking Order Status";
            btnTrackOrStt.UseVisualStyleBackColor = false;
            btnTrackOrStt.Click += btnTrackOrStt_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            closeButton.BackColor = System.Drawing.Color.OrangeRed;
            closeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            closeButton.Location = new System.Drawing.Point(1223, -2);
            closeButton.Margin = new System.Windows.Forms.Padding(2);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(20, 20);
            closeButton.TabIndex = 41;
            closeButton.Click += closeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Navy;
            ClientSize = new System.Drawing.Size(1242, 614);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Panel pn_cart;
        private System.Windows.Forms.DataGridView dgvCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOrderM;
        private System.Windows.Forms.Button btnTrackOrStt;
        private System.Windows.Forms.Button btnComboManagement;
        private System.Windows.Forms.Button btnMenuManagement;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel closeButton;
    }
}

