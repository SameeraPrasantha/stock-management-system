
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
            this.lblMakeBill = new System.Windows.Forms.Label();
            this.picBill = new System.Windows.Forms.PictureBox();
            this.picGRN = new System.Windows.Forms.PictureBox();
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
            // lblMakeBill
            // 
            this.lblMakeBill.AutoSize = true;
            this.lblMakeBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeBill.ForeColor = System.Drawing.Color.White;
            this.lblMakeBill.Location = new System.Drawing.Point(352, 212);
            this.lblMakeBill.Name = "lblMakeBill";
            this.lblMakeBill.Size = new System.Drawing.Size(109, 25);
            this.lblMakeBill.TabIndex = 7;
            this.lblMakeBill.Text = "Make Bill";
            this.lblMakeBill.Click += new System.EventHandler(this.lblMakeBill_Click);
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
            this.picBill.Click += new System.EventHandler(this.picBill_Click);
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
            this.ClientSize = new System.Drawing.Size(556, 287);
            this.ControlBox = false;
            this.Controls.Add(this.picBill);
            this.Controls.Add(this.lblMakeBill);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.picGRN);
            this.Controls.Add(this.lblGRN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGRN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGRN;
        private System.Windows.Forms.PictureBox picGRN;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblMakeBill;
        private System.Windows.Forms.PictureBox picBill;
    }
}