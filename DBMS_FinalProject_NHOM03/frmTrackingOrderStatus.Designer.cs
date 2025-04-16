namespace DBMS_FinalProject_NHOM03
{
    partial class TrackingOrderStatusForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackingOrderStatusForm));
            lblOrderID = new System.Windows.Forms.Label();
            DisplayOrderIn = new System.Windows.Forms.RichTextBox();
            txtOrderID = new System.Windows.Forms.TextBox();
            btnTrack = new System.Windows.Forms.Button();
            rtb_Dis = new System.Windows.Forms.RichTextBox();
            OrderIn4Grbx = new System.Windows.Forms.GroupBox();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label13 = new System.Windows.Forms.Label();
            minimizeButton = new System.Windows.Forms.Panel();
            closeButton = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            OrderIn4Grbx.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOrderID.Location = new System.Drawing.Point(36, 67);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new System.Drawing.Size(73, 20);
            lblOrderID.TabIndex = 1;
            lblOrderID.Text = "Order ID:";
            // 
            // DisplayOrderIn
            // 
            DisplayOrderIn.Location = new System.Drawing.Point(32, 113);
            DisplayOrderIn.Name = "DisplayOrderIn";
            DisplayOrderIn.Size = new System.Drawing.Size(776, 426);
            DisplayOrderIn.TabIndex = 0;
            DisplayOrderIn.Text = "fsdfdsfdssdf";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(110, 65);
            txtOrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(300, 27);
            txtOrderID.TabIndex = 2;
            // 
            // btnTrack
            // 
            btnTrack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnTrack.Location = new System.Drawing.Point(425, 58);
            btnTrack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new System.Drawing.Size(100, 38);
            btnTrack.TabIndex = 3;
            btnTrack.Text = "Search";
            btnTrack.UseVisualStyleBackColor = true;
            btnTrack.Click += btnTrack_Click;
            // 
            // rtb_Dis
            // 
            rtb_Dis.ForeColor = System.Drawing.Color.Black;
            rtb_Dis.Location = new System.Drawing.Point(17, 31);
            rtb_Dis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            rtb_Dis.Name = "rtb_Dis";
            rtb_Dis.ReadOnly = true;
            rtb_Dis.Size = new System.Drawing.Size(525, 278);
            rtb_Dis.TabIndex = 7;
            rtb_Dis.Text = "";
            rtb_Dis.TextChanged += richTextBox1_TextChanged;
            // 
            // OrderIn4Grbx
            // 
            OrderIn4Grbx.AutoSize = true;
            OrderIn4Grbx.Controls.Add(rtb_Dis);
            OrderIn4Grbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            OrderIn4Grbx.Location = new System.Drawing.Point(19, 119);
            OrderIn4Grbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            OrderIn4Grbx.Name = "OrderIn4Grbx";
            OrderIn4Grbx.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            OrderIn4Grbx.Size = new System.Drawing.Size(551, 333);
            OrderIn4Grbx.TabIndex = 6;
            OrderIn4Grbx.TabStop = false;
            OrderIn4Grbx.Text = "Order Information";
            OrderIn4Grbx.Enter += OrderIn4Grbx_Enter_1;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label13);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(525, 34);
            panel1.TabIndex = 37;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(4, -1);
            pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            label13.Location = new System.Drawing.Point(37, 1);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(190, 29);
            label13.TabIndex = 35;
            label13.Text = "Tracking Order";
            // 
            // minimizeButton
            // 
            minimizeButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            minimizeButton.BackColor = System.Drawing.Color.LimeGreen;
            minimizeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("minimizeButton.BackgroundImage");
            minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            minimizeButton.Location = new System.Drawing.Point(525, 0);
            minimizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new System.Drawing.Size(39, 34);
            minimizeButton.TabIndex = 39;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            closeButton.BackColor = System.Drawing.Color.OrangeRed;
            closeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            closeButton.Location = new System.Drawing.Point(564, 0);
            closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(39, 34);
            closeButton.TabIndex = 38;
            closeButton.Click += closeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(8, 58);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(27, 40);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // TrackingOrderStatusForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(600, 458);
            Controls.Add(pictureBox1);
            Controls.Add(minimizeButton);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            Controls.Add(OrderIn4Grbx);
            Controls.Add(btnTrack);
            Controls.Add(txtOrderID);
            Controls.Add(lblOrderID);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "TrackingOrderStatusForm";
            Text = "Tracking Order";
            OrderIn4Grbx.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.RichTextBox DisplayOrderIn;

        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.RichTextBox rtb_Dis;
        private System.Windows.Forms.GroupBox OrderIn4Grbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel minimizeButton;
        private System.Windows.Forms.Panel closeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}