namespace DBMS_MenuManagement
{
    partial class RevenueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueForm));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnExportToExcel = new System.Windows.Forms.Button();
            btnShowChart = new System.Windows.Forms.Button();
            lblTotalRevenue = new System.Windows.Forms.Label();
            dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnViewRevenue = new System.Windows.Forms.Button();
            dataGridRevenue = new System.Windows.Forms.DataGridView();
            closeButton = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRevenue).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(195, 227, 235);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExportToExcel);
            panel1.Controls.Add(btnShowChart);
            panel1.Controls.Add(lblTotalRevenue);
            panel1.Controls.Add(dateTimePickerEnd);
            panel1.Controls.Add(dateTimePickerStart);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnViewRevenue);
            panel1.Controls.Add(dataGridRevenue);
            panel1.Location = new System.Drawing.Point(12, 15);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1143, 645);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(3, 4);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(30, 38);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExportToExcel.Location = new System.Drawing.Point(611, 41);
            btnExportToExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new System.Drawing.Size(105, 141);
            btnExportToExcel.TabIndex = 25;
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // btnShowChart
            // 
            btnShowChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnShowChart.Location = new System.Drawing.Point(343, 119);
            btnShowChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnShowChart.Name = "btnShowChart";
            btnShowChart.Size = new System.Drawing.Size(262, 64);
            btnShowChart.TabIndex = 24;
            btnShowChart.Text = "Show Chart";
            btnShowChart.UseVisualStyleBackColor = true;
            btnShowChart.Click += btnShowChart_Click;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalRevenue.Location = new System.Drawing.Point(3, 148);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new System.Drawing.Size(62, 28);
            lblTotalRevenue.TabIndex = 23;
            lblTotalRevenue.Text = "Total";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new System.Drawing.Point(124, 105);
            dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            dateTimePickerEnd.TabIndex = 21;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new System.Drawing.Point(124, 41);
            dateTimePickerStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new System.Drawing.Size(200, 27);
            dateTimePickerStart.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(31, 41);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(83, 21);
            label8.TabIndex = 19;
            label8.Text = "Start Day:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(35, 105);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 21);
            label7.TabIndex = 18;
            label7.Text = "End Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(476, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 28);
            label1.TabIndex = 12;
            label1.Text = "REVENUE";
            // 
            // btnViewRevenue
            // 
            btnViewRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnViewRevenue.Location = new System.Drawing.Point(343, 41);
            btnViewRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnViewRevenue.Name = "btnViewRevenue";
            btnViewRevenue.Size = new System.Drawing.Size(262, 64);
            btnViewRevenue.TabIndex = 8;
            btnViewRevenue.Text = "View Revenue";
            btnViewRevenue.UseVisualStyleBackColor = true;
            btnViewRevenue.Click += btnViewRevenue_Click;
            // 
            // dataGridRevenue
            // 
            dataGridRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRevenue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRevenue.Location = new System.Drawing.Point(3, 190);
            dataGridRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridRevenue.Name = "dataGridRevenue";
            dataGridRevenue.RowHeadersWidth = 51;
            dataGridRevenue.RowTemplate.Height = 24;
            dataGridRevenue.Size = new System.Drawing.Size(713, 451);
            dataGridRevenue.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            closeButton.BackColor = System.Drawing.Color.OrangeRed;
            closeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            closeButton.Location = new System.Drawing.Point(1157, -2);
            closeButton.Margin = new System.Windows.Forms.Padding(2);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(20, 20);
            closeButton.TabIndex = 40;
            closeButton.Click += closeButton_Click;
            // 
            // RevenueForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Navy;
            ClientSize = new System.Drawing.Size(1175, 675);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "RevenueForm";
            Text = "RevenueForm";
            Load += RevenueForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRevenue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewRevenue;
        private System.Windows.Forms.DataGridView dataGridRevenue;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Button btnShowChart;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel closeButton;
    }
}