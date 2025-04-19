namespace DBMS_FinalProject_NHOM03
{
    partial class Combo_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Combo_Management));
            pc_exit = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            txtcbname = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            dgvComboItem = new System.Windows.Forms.DataGridView();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnRefresh = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtFoodID = new System.Windows.Forms.TextBox();
            txtComboID = new System.Windows.Forms.TextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            dgvCombo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)pc_exit).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComboItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).BeginInit();
            SuspendLayout();
            // 
            // pc_exit
            // 
            pc_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            pc_exit.Image = (System.Drawing.Image)resources.GetObject("pc_exit.Image");
            pc_exit.Location = new System.Drawing.Point(809, -1);
            pc_exit.Name = "pc_exit";
            pc_exit.Size = new System.Drawing.Size(20, 20);
            pc_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pc_exit.TabIndex = 4;
            pc_exit.TabStop = false;
            pc_exit.Click += pc_exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(195, 227, 235);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtcbname);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dgvComboItem);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtFoodID);
            panel1.Controls.Add(txtComboID);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(dgvCombo);
            panel1.Location = new System.Drawing.Point(11, 13);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(797, 475);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(29, 352);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(107, 21);
            label2.TabIndex = 24;
            label2.Text = "ComboName";
            // 
            // txtcbname
            // 
            txtcbname.Location = new System.Drawing.Point(143, 349);
            txtcbname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtcbname.Name = "txtcbname";
            txtcbname.Size = new System.Drawing.Size(153, 27);
            txtcbname.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(532, 83);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(141, 21);
            label10.TabIndex = 22;
            label10.Text = "ComboItem Table";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(153, 83);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(106, 21);
            label9.TabIndex = 21;
            label9.Text = "Combo Table";
            // 
            // dgvComboItem
            // 
            dgvComboItem.AllowUserToAddRows = false;
            dgvComboItem.AllowUserToDeleteRows = false;
            dgvComboItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvComboItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvComboItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComboItem.Location = new System.Drawing.Point(412, 108);
            dgvComboItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvComboItem.Name = "dgvComboItem";
            dgvComboItem.ReadOnly = true;
            dgvComboItem.RowHeadersWidth = 51;
            dgvComboItem.RowTemplate.Height = 24;
            dgvComboItem.Size = new System.Drawing.Size(378, 155);
            dgvComboItem.TabIndex = 20;
            dgvComboItem.CellClick += dgvComboItem_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(439, 305);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 21);
            label6.TabIndex = 17;
            label6.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(610, 302);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(48, 21);
            label5.TabIndex = 16;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(29, 306);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 21);
            label4.TabIndex = 15;
            label4.Text = "ComboID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(248, 306);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 21);
            label3.TabIndex = 14;
            label3.Text = "FoodID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(258, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(296, 32);
            label1.TabIndex = 12;
            label1.Text = "COMBO MANAGEMENT";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            btnRefresh.Location = new System.Drawing.Point(706, 406);
            btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(83, 41);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            btnDelete.Location = new System.Drawing.Point(455, 406);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(245, 41);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete in Combo or ComboItem";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            btnUpdate.Location = new System.Drawing.Point(199, 406);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(249, 41);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update in Combo or ComboItem";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            btnAdd.Location = new System.Drawing.Point(7, 406);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(188, 41);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add new combo or item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(319, 302);
            txtFoodID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new System.Drawing.Size(100, 27);
            txtFoodID.TabIndex = 5;
            // 
            // txtComboID
            // 
            txtComboID.Location = new System.Drawing.Point(117, 303);
            txtComboID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtComboID.Name = "txtComboID";
            txtComboID.Size = new System.Drawing.Size(100, 27);
            txtComboID.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(522, 302);
            txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(76, 27);
            txtQuantity.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(664, 299);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(107, 27);
            txtPrice.TabIndex = 2;
            // 
            // dgvCombo
            // 
            dgvCombo.AllowUserToAddRows = false;
            dgvCombo.AllowUserToDeleteRows = false;
            dgvCombo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCombo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombo.Location = new System.Drawing.Point(11, 108);
            dgvCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvCombo.Name = "dgvCombo";
            dgvCombo.ReadOnly = true;
            dgvCombo.RowHeadersWidth = 51;
            dgvCombo.RowTemplate.Height = 24;
            dgvCombo.Size = new System.Drawing.Size(391, 155);
            dgvCombo.TabIndex = 0;
            dgvCombo.CellClick += dgvCombo_CellClick;
            // 
            // Combo_Management
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Navy;
            ClientSize = new System.Drawing.Size(828, 503);
            Controls.Add(panel1);
            Controls.Add(pc_exit);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Combo_Management";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Combo_Management";
            ((System.ComponentModel.ISupportInitialize)pc_exit).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComboItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pc_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvComboItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtComboID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dgvCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcbname;
    }
}