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
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Khaki;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new System.Drawing.Point(20, 19);
            panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1848, 942);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(52, 26);
            pictureBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(205, 147);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox1.Location = new System.Drawing.Point(296, 75);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1544, 860);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.Snow;
            button1.Location = new System.Drawing.Point(-15, 182);
            button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(318, 78);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Red;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.Snow;
            button2.Location = new System.Drawing.Point(-15, 317);
            button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(318, 78);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Red;
            ClientSize = new System.Drawing.Size(1887, 981);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
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
    }
}

