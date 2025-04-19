using System.Drawing;
using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvMenu = new DataGridView();
            btnAddCart = new Button();
            pn_cart = new Panel();
            dgvCombo = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pc_exit = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_exit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(195, 227, 235);
            panel1.Controls.Add(dgvMenu);
            panel1.Controls.Add(btnAddCart);
            panel1.Controls.Add(pn_cart);
            panel1.Controls.Add(dgvCombo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(15, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 589);
            panel1.TabIndex = 0;
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(190, 190, 190);
            dgvMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMenu.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMenu.BorderStyle = BorderStyle.None;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Location = new Point(246, 53);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(5, 10, 5, 10);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMenu.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(204, 119, 34);
            dgvMenu.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvMenu.Size = new Size(914, 234);
            dgvMenu.TabIndex = 11;
            dgvMenu.CellClick += dgvMenu_CellClick;
            // 
            // btnAddCart
            // 
            btnAddCart.BackColor = Color.Navy;
            btnAddCart.Font = new Font("Vinhan", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCart.ForeColor = Color.White;
            btnAddCart.Location = new Point(1026, 517);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(134, 44);
            btnAddCart.TabIndex = 1;
            btnAddCart.Text = "Add to Cart";
            btnAddCart.UseVisualStyleBackColor = false;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // pn_cart
            // 
            pn_cart.BackColor = Color.FromArgb(195, 227, 235);
            pn_cart.BackgroundImage = (Image)resources.GetObject("pn_cart.BackgroundImage");
            pn_cart.BackgroundImageLayout = ImageLayout.Zoom;
            pn_cart.Cursor = Cursors.Hand;
            pn_cart.Location = new Point(1100, 3);
            pn_cart.Name = "pn_cart";
            pn_cart.Size = new Size(60, 40);
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
            dataGridViewCellStyle4.BackColor = Color.FromArgb(190, 190, 190);
            dgvCombo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCombo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCombo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCombo.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCombo.BorderStyle = BorderStyle.None;
            dgvCombo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombo.Location = new Point(296, 325);
            dgvCombo.Name = "dgvCombo";
            dgvCombo.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(5, 10, 5, 10);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCombo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCombo.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(204, 119, 34);
            dgvCombo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCombo.Size = new Size(819, 171);
            dgvCombo.TabIndex = 7;
            dgvCombo.CellClick += dgvCombo_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Vinhan", 15F, FontStyle.Bold);
            label2.Location = new Point(161, 290);
            label2.Name = "label2";
            label2.Size = new Size(96, 34);
            label2.TabIndex = 6;
            label2.Text = "Combo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vinhan", 15F, FontStyle.Bold);
            label1.Location = new Point(161, 53);
            label1.Name = "label1";
            label1.Size = new Size(79, 34);
            label1.TabIndex = 5;
            label1.Text = "Menu";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(23, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(155, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1014, 539);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Vinhan", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(-9, 114);
            button1.Name = "button1";
            button1.Size = new Size(169, 49);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Vinhan", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(-9, 198);
            button2.Name = "button2";
            button2.Size = new Size(169, 49);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // pc_exit
            // 
            pc_exit.Cursor = Cursors.Hand;
            pc_exit.Image = (Image)resources.GetObject("pc_exit.Image");
            pc_exit.Location = new Point(1188, -1);
            pc_exit.Name = "pc_exit";
            pc_exit.Size = new Size(24, 24);
            pc_exit.SizeMode = PictureBoxSizeMode.StretchImage;
            pc_exit.TabIndex = 0;
            pc_exit.TabStop = false;
            pc_exit.Click += pc_exit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1212, 634);
            Controls.Add(pc_exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_exit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCombo;
        private System.Windows.Forms.Panel pn_cart;
        private System.Windows.Forms.PictureBox pc_exit;
        private System.Windows.Forms.Button btnAddCart;
        private DataGridView dgvMenu;
    }
}

