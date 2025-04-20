namespace DBMS_FinalProject_NHOM03
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new System.Windows.Forms.Panel();
            btnLogin = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnCreateUser = new System.Windows.Forms.Button();
            txtPass = new System.Windows.Forms.TextBox();
            txtUsername = new System.Windows.Forms.TextBox();
            pc_exit = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_exit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(195, 227, 235);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCreateUser);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new System.Drawing.Point(12, 13);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(625, 257);
            panel1.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.Location = new System.Drawing.Point(361, 176);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(141, 44);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(145, 117);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 21);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(131, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 21);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(267, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 32);
            label1.TabIndex = 12;
            label1.Text = "LOGIN";
            // 
            // btnCreateUser
            // 
            btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCreateUser.Location = new System.Drawing.Point(131, 176);
            btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new System.Drawing.Size(141, 44);
            btnCreateUser.TabIndex = 8;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new System.Drawing.Point(231, 114);
            txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(182, 27);
            txtPass.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(223, 69);
            txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(246, 27);
            txtUsername.TabIndex = 1;
            // 
            // pc_exit
            // 
            pc_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            pc_exit.Image = (System.Drawing.Image)resources.GetObject("pc_exit.Image");
            pc_exit.Location = new System.Drawing.Point(637, -1);
            pc_exit.Name = "pc_exit";
            pc_exit.Size = new System.Drawing.Size(20, 20);
            pc_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pc_exit.TabIndex = 4;
            pc_exit.TabStop = false;
            pc_exit.Click += pc_exit_Click;
            // 
            // frmStaffLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Navy;
            ClientSize = new System.Drawing.Size(656, 285);
            Controls.Add(pc_exit);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmStaffLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmStaffLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_exit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtComboID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pc_exit;
        private System.Windows.Forms.Button btnLogin;
    }
}