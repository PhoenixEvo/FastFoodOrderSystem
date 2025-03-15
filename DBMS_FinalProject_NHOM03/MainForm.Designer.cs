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
            panel1 = new System.Windows.Forms.Panel();
            dgvCombo = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            dgvMenu = new System.Windows.Forms.DataGridView();
            col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Khaki;
            panel1.Controls.Add(dgvCombo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvMenu);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1137, 589);
            panel1.TabIndex = 0;
            // 
            // dgvCombo
            // 
            dgvCombo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCombo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvCombo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvCombo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn3 });
            dgvCombo.Location = new System.Drawing.Point(246, 293);
            dgvCombo.Name = "dgvCombo";
            dgvCombo.RowHeadersWidth = 51;
            dgvCombo.Size = new System.Drawing.Size(888, 238);
            dgvCombo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Vinhan", 15F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(157, 290);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 34);
            label2.TabIndex = 6;
            label2.Text = "Combo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Vinhan", 15F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(161, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 34);
            label1.TabIndex = 5;
            label1.Text = "Menu";
            // 
            // dgvMenu
            // 
            dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvMenu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col1, Col2, Col3, Col4 });
            dgvMenu.Location = new System.Drawing.Point(246, 49);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.RowHeadersWidth = 51;
            dgvMenu.Size = new System.Drawing.Size(888, 238);
            dgvMenu.TabIndex = 4;
            // 
            // col1
            // 
            col1.HeaderText = "ID";
            col1.MinimumWidth = 6;
            col1.Name = "col1";
            // 
            // Col2
            // 
            Col2.HeaderText = "Name";
            Col2.MinimumWidth = 6;
            Col2.Name = "Col2";
            // 
            // Col3
            // 
            Col3.HeaderText = "Price (VND)";
            Col3.MinimumWidth = 6;
            Col3.Name = "Col3";
            // 
            // Col4
            // 
            Col4.HeaderText = "Category";
            Col4.MinimumWidth = 6;
            Col4.Name = "Col4";
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
            pictureBox1.Location = new System.Drawing.Point(155, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(979, 539);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.Font = new System.Drawing.Font("Vinhan", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.Snow;
            button1.Location = new System.Drawing.Point(-9, 114);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(169, 49);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Red;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.Font = new System.Drawing.Font("Vinhan", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.Snow;
            button2.Location = new System.Drawing.Point(-9, 198);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(169, 49);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Includes";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Price (VND)";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Red;
            ClientSize = new System.Drawing.Size(1161, 613);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

