namespace DBMS_FinalProject_NHOM03
{
    partial class frmCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckOut));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label13 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            minimizeButton = new System.Windows.Forms.Panel();
            closeButton = new System.Windows.Forms.Panel();
            txtName = new System.Windows.Forms.TextBox();
            lblOrderID = new System.Windows.Forms.Label();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtHouseNumber = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtStreet = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtWard = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtDistrict = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            btnConfirm = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            cboPaymentMethod = new System.Windows.Forms.ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(609, 34);
            panel1.TabIndex = 38;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(2, 2);
            pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(27, 35);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            label13.Location = new System.Drawing.Point(37, -71);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(190, 29);
            label13.TabIndex = 35;
            label13.Text = "Tracking Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.CornflowerBlue;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(167, 2);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(346, 29);
            label2.TabIndex = 46;
            label2.Text = "CUSTOMER INFORMATION";
            // 
            // minimizeButton
            // 
            minimizeButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            minimizeButton.BackColor = System.Drawing.Color.LimeGreen;
            minimizeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("minimizeButton.BackgroundImage");
            minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            minimizeButton.Location = new System.Drawing.Point(603, 0);
            minimizeButton.Margin = new System.Windows.Forms.Padding(2);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new System.Drawing.Size(39, 34);
            minimizeButton.TabIndex = 41;
            minimizeButton.Click += minimizeButton_Click;
            minimizeButton.MouseDown += minimizeButton_MouseDown;
            minimizeButton.MouseMove += minimizeButton_MouseMove;
            // 
            // closeButton
            // 
            closeButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            closeButton.BackColor = System.Drawing.Color.OrangeRed;
            closeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            closeButton.Location = new System.Drawing.Point(645, 0);
            closeButton.Margin = new System.Windows.Forms.Padding(2);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(39, 34);
            closeButton.TabIndex = 40;
            closeButton.Click += closeButton_Click;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(216, 112);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(300, 27);
            txtName.TabIndex = 43;
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOrderID.Location = new System.Drawing.Point(132, 119);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new System.Drawing.Size(55, 20);
            lblOrderID.TabIndex = 42;
            lblOrderID.Text = "Name:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(216, 174);
            txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(300, 27);
            txtPhoneNumber.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(67, 177);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 20);
            label1.TabIndex = 44;
            label1.Text = "Phone Number:";
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.Location = new System.Drawing.Point(216, 241);
            txtHouseNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.Size = new System.Drawing.Size(300, 27);
            txtHouseNumber.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(67, 244);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(120, 20);
            label3.TabIndex = 47;
            label3.Text = "House Number:";
            // 
            // txtStreet
            // 
            txtStreet.Location = new System.Drawing.Point(216, 311);
            txtStreet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new System.Drawing.Size(300, 27);
            txtStreet.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(132, 314);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 20);
            label4.TabIndex = 49;
            label4.Text = "Street:";
            // 
            // txtWard
            // 
            txtWard.Location = new System.Drawing.Point(216, 381);
            txtWard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtWard.Name = "txtWard";
            txtWard.Size = new System.Drawing.Size(300, 27);
            txtWard.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(137, 384);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 20);
            label5.TabIndex = 51;
            label5.Text = "Ward:";
            // 
            // txtDistrict
            // 
            txtDistrict.Location = new System.Drawing.Point(216, 447);
            txtDistrict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDistrict.Name = "txtDistrict";
            txtDistrict.Size = new System.Drawing.Size(300, 27);
            txtDistrict.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(123, 447);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(64, 20);
            label6.TabIndex = 53;
            label6.Text = "District:";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnConfirm.Location = new System.Drawing.Point(205, 539);
            btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(100, 38);
            btnConfirm.TabIndex = 55;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(398, 539);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(100, 38);
            btnClear.TabIndex = 56;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(167, 500);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(134, 20);
            label7.TabIndex = 57;
            label7.Text = "Payment Method:";
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Items.AddRange(new object[] { "Cash" });
            cboPaymentMethod.Location = new System.Drawing.Point(322, 497);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new System.Drawing.Size(116, 28);
            cboPaymentMethod.TabIndex = 58;
            // 
            // frmCheckOut
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(684, 614);
            Controls.Add(cboPaymentMethod);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(btnConfirm);
            Controls.Add(txtDistrict);
            Controls.Add(label6);
            Controls.Add(txtWard);
            Controls.Add(label5);
            Controls.Add(txtStreet);
            Controls.Add(label4);
            Controls.Add(txtHouseNumber);
            Controls.Add(label3);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(lblOrderID);
            Controls.Add(minimizeButton);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmCheckOut";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCheckOut";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel minimizeButton;
        private System.Windows.Forms.Panel closeButton;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHouseNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
    }
}