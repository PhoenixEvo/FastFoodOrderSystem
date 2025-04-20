using System.Windows.Forms;

namespace DBMS_FinalProject_NHOM03
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            dgvInventory = new DataGridView();
            btnLoad = new PictureBox();
            btnAdd = new Button();
            label5 = new Label();
            movePanel = new Panel();
            minimizeButton = new Panel();
            pictureBox2 = new PictureBox();
            closeButton = new Panel();
            txtFoodName = new TextBox();
            txtFoodID = new TextBox();
            nudQuantity = new NumericUpDown();
            dtpRestockDate = new DateTimePicker();
            cbStatus = new ComboBox();
            txtCostPrice = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLoad).BeginInit();
            movePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new System.Drawing.Point(21, 240);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new System.Drawing.Size(750, 386);
            dgvInventory.TabIndex = 0;
            dgvInventory.SelectionChanged += dgvInventory_SelectionChanged;
            // 
            // btnLoad
            // 
            btnLoad.Image = (System.Drawing.Image)resources.GetObject("btnLoad.Image");
            btnLoad.Location = new System.Drawing.Point(863, 20);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(63, 55);
            btnLoad.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLoad.TabIndex = 2;
            btnLoad.TabStop = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(825, 493);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(139, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label5.Location = new System.Drawing.Point(36, -160);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(238, 29);
            label5.TabIndex = 35;
            label5.Text = "Order Management";
            // 
            // movePanel
            // 
            movePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            movePanel.BackColor = System.Drawing.Color.Navy;
            movePanel.Controls.Add(minimizeButton);
            movePanel.Controls.Add(pictureBox2);
            movePanel.Controls.Add(closeButton);
            movePanel.Controls.Add(label5);
            movePanel.Location = new System.Drawing.Point(-158, 0);
            movePanel.Margin = new Padding(2);
            movePanel.Name = "movePanel";
            movePanel.Size = new System.Drawing.Size(1297, 34);
            movePanel.TabIndex = 35;
            movePanel.MouseDown += movePanel_MouseDown;
            movePanel.MouseMove += movePanel_MouseMove;
            // 
            // minimizeButton
            // 
            minimizeButton.BackColor = System.Drawing.Color.LimeGreen;
            minimizeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("minimizeButton.BackgroundImage");
            minimizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            minimizeButton.Location = new System.Drawing.Point(1038, -1);
            minimizeButton.Margin = new Padding(2);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new System.Drawing.Size(54, 34);
            minimizeButton.TabIndex = 52;
            minimizeButton.Click += minimizeButton_Click;
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
            // 
            // closeButton
            // 
            closeButton.BackColor = System.Drawing.Color.OrangeRed;
            closeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.Location = new System.Drawing.Point(1090, -1);
            closeButton.Margin = new Padding(2);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(54, 34);
            closeButton.TabIndex = 51;
            closeButton.Click += closeButton_Click;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new System.Drawing.Point(105, 29);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new System.Drawing.Size(159, 27);
            txtFoodName.TabIndex = 36;
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(105, 87);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new System.Drawing.Size(159, 27);
            txtFoodID.TabIndex = 37;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new System.Drawing.Point(356, 25);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new System.Drawing.Size(129, 27);
            nudQuantity.TabIndex = 38;
            // 
            // dtpRestockDate
            // 
            dtpRestockDate.CustomFormat = "dd/MM/yy";
            dtpRestockDate.Format = DateTimePickerFormat.Custom;
            dtpRestockDate.Location = new System.Drawing.Point(619, 25);
            dtpRestockDate.Name = "dtpRestockDate";
            dtpRestockDate.Size = new System.Drawing.Size(177, 27);
            dtpRestockDate.TabIndex = 39;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Available", "Unavailable" });
            cbStatus.Location = new System.Drawing.Point(619, 88);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new System.Drawing.Size(177, 28);
            cbStatus.TabIndex = 40;
            // 
            // txtCostPrice
            // 
            txtCostPrice.Location = new System.Drawing.Point(356, 89);
            txtCostPrice.Name = "txtCostPrice";
            txtCostPrice.Size = new System.Drawing.Size(129, 27);
            txtCostPrice.TabIndex = 41;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(825, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(139, 34);
            btnDelete.TabIndex = 45;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(825, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(139, 34);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 20);
            label1.TabIndex = 47;
            label1.Text = "Item Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 20);
            label2.TabIndex = 48;
            label2.Text = "Item ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(273, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 20);
            label3.TabIndex = 49;
            label3.Text = "Cost Price:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(dtpRestockDate);
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(nudQuantity);
            groupBox1.Controls.Add(txtFoodID);
            groupBox1.Controls.Add(txtCostPrice);
            groupBox1.Controls.Add(txtFoodName);
            groupBox1.Location = new System.Drawing.Point(21, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(955, 147);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(511, 32);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(93, 20);
            label7.TabIndex = 52;
            label7.Text = "Last Restock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(552, 90);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 20);
            label6.TabIndex = 51;
            label6.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(290, 27);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 20);
            label4.TabIndex = 50;
            label4.Text = "Stock:";
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(981, 666);
            Controls.Add(groupBox1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(movePanel);
            Controls.Add(btnAdd);
            Controls.Add(dgvInventory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInventory";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLoad).EndInit();
            movePanel.ResumeLayout(false);
            movePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.PictureBox btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DateTimePicker dtpRestockDate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel minimizeButton;
        private System.Windows.Forms.Panel closeButton;
    }
}