namespace DBMS_FinalProject_NHOM03
{
    partial class Test_CaiDatC_TuSQL
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
this.btnTestCustomer = new System.Windows.Forms.Button();
            this.btnTestOrder = new System.Windows.Forms.Button();
            this.btnTestInventory = new System.Windows.Forms.Button();
            this.btnTestCombo = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.btnRunAllTests = new System.Windows.Forms.Button();
            this.cmbViews = new System.Windows.Forms.ComboBox();
            this.btnTestView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTestCustomer
            // 
            this.btnTestCustomer.Location = new System.Drawing.Point(12, 12);
            this.btnTestCustomer.Name = "btnTestCustomer";
            this.btnTestCustomer.Size = new System.Drawing.Size(150, 40);
            this.btnTestCustomer.TabIndex = 0;
            this.btnTestCustomer.Text = "Test Customer";
            this.btnTestCustomer.UseVisualStyleBackColor = true;
            //this.btnTestCustomer.Click += new System.EventHandler(this.btnTestCustomer_Click);
            // 
            // btnTestOrder
            // 
            this.btnTestOrder.Location = new System.Drawing.Point(168, 12);
            this.btnTestOrder.Name = "btnTestOrder";
            this.btnTestOrder.Size = new System.Drawing.Size(150, 40);
            this.btnTestOrder.TabIndex = 1;
            this.btnTestOrder.Text = "Test Order";
            this.btnTestOrder.UseVisualStyleBackColor = true;
            //this.btnTestOrder.Click += new System.EventHandler(this.btnTestOrder_Click);
            // 
            // btnTestInventory
            // 
            this.btnTestInventory.Location = new System.Drawing.Point(12, 58);
            this.btnTestInventory.Name = "btnTestInventory";
            this.btnTestInventory.Size = new System.Drawing.Size(150, 40);
            this.btnTestInventory.TabIndex = 2;
            this.btnTestInventory.Text = "Test Inventory";
            this.btnTestInventory.UseVisualStyleBackColor = true;
            //this.btnTestInventory.Click += new System.EventHandler(this.btnTestInventory_Click);
            // 
            // btnTestCombo
            // 
            this.btnTestCombo.Location = new System.Drawing.Point(168, 58);
            this.btnTestCombo.Name = "btnTestCombo";
            this.btnTestCombo.Size = new System.Drawing.Size(150, 40);
            this.btnTestCombo.TabIndex = 3;
            this.btnTestCombo.Text = "Test Combo";
            this.btnTestCombo.UseVisualStyleBackColor = true;
            //this.btnTestCombo.Click += new System.EventHandler(this.btnTestCombo_Click);
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(12, 156);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(776, 482);
            this.txtResults.TabIndex = 4;
            this.txtResults.Text = "";
            // 
            // btnRunAllTests
            // 
            this.btnRunAllTests.Location = new System.Drawing.Point(324, 12);
            this.btnRunAllTests.Name = "btnRunAllTests";
            this.btnRunAllTests.Size = new System.Drawing.Size(150, 86);
            this.btnRunAllTests.TabIndex = 5;
            this.btnRunAllTests.Text = "Run All Tests";
            this.btnRunAllTests.UseVisualStyleBackColor = true;
            //this.btnRunAllTests.Click += new System.EventHandler(this.btnRunAllTests_Click);
            // 
            // cmbViews
            // 
            this.cmbViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViews.FormattingEnabled = true;
            this.cmbViews.Location = new System.Drawing.Point(12, 119);
            this.cmbViews.Name = "cmbViews";
            this.cmbViews.Size = new System.Drawing.Size(150, 24);
            this.cmbViews.TabIndex = 6;
            // 
            // btnTestView
            // 
            this.btnTestView.Location = new System.Drawing.Point(168, 112);
            this.btnTestView.Name = "btnTestView";
            this.btnTestView.Size = new System.Drawing.Size(150, 35);
            this.btnTestView.TabIndex = 7;
            this.btnTestView.Text = "Test View";
            this.btnTestView.UseVisualStyleBackColor = true;
            //this.btnTestView.Click += new System.EventHandler(this.btnTestView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Views:";
            // 
            // Test_CaiDatCSharpTuSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestView);
            this.Controls.Add(this.cmbViews);
            this.Controls.Add(this.btnRunAllTests);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnTestCombo);
            this.Controls.Add(this.btnTestInventory);
            this.Controls.Add(this.btnTestOrder);
            this.Controls.Add(this.btnTestCustomer);
            this.Name = "Test_CaiDatCSharpTuSQL";
            this.Text = "SQL Procedure and Function Tester";
            //this.Load += new System.EventHandler(this.Test_CaiDatCSharpTuSQL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnTestCustomer;
        private System.Windows.Forms.Button btnTestOrder;
        private System.Windows.Forms.Button btnTestInventory;
        private System.Windows.Forms.Button btnTestCombo;
        private System.Windows.Forms.RichTextBox txtResults;
        private System.Windows.Forms.Button btnRunAllTests;
        private System.Windows.Forms.ComboBox cmbViews;
        private System.Windows.Forms.Button btnTestView;
        private System.Windows.Forms.Label label1;
        }

        #endregion
    }