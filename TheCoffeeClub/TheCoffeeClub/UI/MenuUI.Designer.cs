namespace TheCoffeeClub.UI
{
    partial class MenuUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flwCheckBox = new System.Windows.Forms.FlowLayoutPanel();
            this.gvOrder = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnResert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.flwCheckBox);
            this.panel1.Controls.Add(this.gvOrder);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnTotal);
            this.panel1.Controls.Add(this.btnResert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 472);
            this.panel1.TabIndex = 0;
            // 
            // flwCheckBox
            // 
            this.flwCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flwCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flwCheckBox.BackgroundImage")));
            this.flwCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flwCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flwCheckBox.Location = new System.Drawing.Point(0, 0);
            this.flwCheckBox.Name = "flwCheckBox";
            this.flwCheckBox.Size = new System.Drawing.Size(265, 472);
            this.flwCheckBox.TabIndex = 10;
            // 
            // gvOrder
            // 
            this.gvOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Coffee,
            this.Price,
            this.Qty});
            this.gvOrder.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gvOrder.Location = new System.Drawing.Point(271, 12);
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.Size = new System.Drawing.Size(444, 202);
            this.gvOrder.TabIndex = 8;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Coffee
            // 
            this.Coffee.HeaderText = "Coffee";
            this.Coffee.Name = "Coffee";
            this.Coffee.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.txtTax);
            this.panel2.Controls.Add(this.txtSubTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(271, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 165);
            this.panel2.TabIndex = 6;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(141, 22);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 5;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(141, 72);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SUB TOTAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAX";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(141, 122);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(0, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(730, 71);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "                                          Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.Orange;
            this.btnTotal.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnTotal.Location = new System.Drawing.Point(589, 220);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(126, 71);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnResert
            // 
            this.btnResert.BackColor = System.Drawing.Color.Orange;
            this.btnResert.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnResert.Location = new System.Drawing.Point(589, 313);
            this.btnResert.Name = "btnResert";
            this.btnResert.Size = new System.Drawing.Size(126, 71);
            this.btnResert.TabIndex = 1;
            this.btnResert.Text = "Resert";
            this.btnResert.UseVisualStyleBackColor = false;
            this.btnResert.Click += new System.EventHandler(this.btnResert_Click);
            // 
            // MenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 472);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuUI";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuUI_FormClosing);
            this.Load += new System.EventHandler(this.MenuUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnResert;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.DataGridView gvOrder;
        private System.Windows.Forms.FlowLayoutPanel flwCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}