
namespace stock_management_system
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblGRN = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picReport = new System.Windows.Forms.PictureBox();
            this.picWarranty = new System.Windows.Forms.PictureBox();
            this.picBill = new System.Windows.Forms.PictureBox();
            this.picGRN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarranty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGRN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGRN
            // 
            this.lblGRN.AutoSize = true;
            this.lblGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRN.ForeColor = System.Drawing.Color.White;
            this.lblGRN.Location = new System.Drawing.Point(89, 212);
            this.lblGRN.Name = "lblGRN";
            this.lblGRN.Size = new System.Drawing.Size(61, 25);
            this.lblGRN.TabIndex = 0;
            this.lblGRN.Text = "GRN";
            this.lblGRN.Click += new System.EventHandler(this.lblGRN_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(12, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(77, 32);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(352, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Make Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Warranty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(366, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Report";
            // 
            // picReport
            // 
            this.picReport.Image = global::stock_management_system.Properties.Resources.icons8_report_100;
            this.picReport.Location = new System.Drawing.Point(343, 298);
            this.picReport.Name = "picReport";
            this.picReport.Size = new System.Drawing.Size(131, 127);
            this.picReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReport.TabIndex = 12;
            this.picReport.TabStop = false;
            // 
            // picWarranty
            // 
            this.picWarranty.Image = global::stock_management_system.Properties.Resources.icons8_warranty_period_100;
            this.picWarranty.Location = new System.Drawing.Point(60, 298);
            this.picWarranty.Name = "picWarranty";
            this.picWarranty.Size = new System.Drawing.Size(131, 127);
            this.picWarranty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWarranty.TabIndex = 10;
            this.picWarranty.TabStop = false;
            // 
            // picBill
            // 
            this.picBill.Image = global::stock_management_system.Properties.Resources.icons8_bill_100;
            this.picBill.Location = new System.Drawing.Point(343, 82);
            this.picBill.Name = "picBill";
            this.picBill.Size = new System.Drawing.Size(131, 127);
            this.picBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBill.TabIndex = 8;
            this.picBill.TabStop = false;
            // 
            // picGRN
            // 
            this.picGRN.Image = global::stock_management_system.Properties.Resources.icons8_receive_goods_100__1_;
            this.picGRN.Location = new System.Drawing.Point(60, 82);
            this.picGRN.Name = "picGRN";
            this.picGRN.Size = new System.Drawing.Size(131, 127);
            this.picGRN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGRN.TabIndex = 1;
            this.picGRN.TabStop = false;
            this.picGRN.Click += new System.EventHandler(this.picGRN_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(556, 477);
            this.ControlBox = false;
            this.Controls.Add(this.picReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picWarranty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.picGRN);
            this.Controls.Add(this.lblGRN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarranty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGRN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGRN;
        private System.Windows.Forms.PictureBox picGRN;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBill;
        private System.Windows.Forms.PictureBox picWarranty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picReport;
        private System.Windows.Forms.Label label4;
    }
}