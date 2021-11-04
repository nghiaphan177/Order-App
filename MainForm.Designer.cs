
namespace BaiThucHanh2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.ButtonTransactionHistory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LinkLabelName = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(0, 60);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1918, 990);
            this.panelContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.ButtonAddProduct);
            this.panel1.Controls.Add(this.ButtonTransactionHistory);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LinkLabelName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 52);
            this.panel1.TabIndex = 2;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonAddProduct.FlatAppearance.BorderSize = 0;
            this.ButtonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddProduct.ForeColor = System.Drawing.Color.White;
            this.ButtonAddProduct.Location = new System.Drawing.Point(1590, 8);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(212, 36);
            this.ButtonAddProduct.TabIndex = 10;
            this.ButtonAddProduct.Text = "Button VIP";
            this.ButtonAddProduct.UseVisualStyleBackColor = false;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // ButtonTransactionHistory
            // 
            this.ButtonTransactionHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonTransactionHistory.FlatAppearance.BorderSize = 0;
            this.ButtonTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTransactionHistory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTransactionHistory.ForeColor = System.Drawing.Color.White;
            this.ButtonTransactionHistory.Location = new System.Drawing.Point(1362, 8);
            this.ButtonTransactionHistory.Name = "ButtonTransactionHistory";
            this.ButtonTransactionHistory.Size = new System.Drawing.Size(196, 38);
            this.ButtonTransactionHistory.TabIndex = 9;
            this.ButtonTransactionHistory.Text = "Transacton History";
            this.ButtonTransactionHistory.UseVisualStyleBackColor = false;
            this.ButtonTransactionHistory.Click += new System.EventHandler(this.ButtonTransactionHistory_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.button1.BackgroundImage = global::BaiThucHanh2.Properties.Resources.sign_out_right_white;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(1868, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LinkLabelName
            // 
            this.LinkLabelName.AutoSize = true;
            this.LinkLabelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LinkLabelName.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinkLabelName.Location = new System.Drawing.Point(131, 12);
            this.LinkLabelName.Name = "LinkLabelName";
            this.LinkLabelName.Size = new System.Drawing.Size(187, 28);
            this.LinkLabelName.TabIndex = 6;
            this.LinkLabelName.TabStop = true;
            this.LinkLabelName.Text = "Phan Thanh Nghia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(28, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome,";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunny";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel LinkLabelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.Button ButtonTransactionHistory;
    }
}

