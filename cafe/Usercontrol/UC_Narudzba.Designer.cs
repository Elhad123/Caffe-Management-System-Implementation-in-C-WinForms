namespace cafe.Usercontrol
{
    partial class UC_Narudzba
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtGrandTotal = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtNarudzba = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtFilterCategory = new System.Windows.Forms.Label();
            this.lbListItems = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnAddOrderItem = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderGrid
            // 
            this.OrderGrid.AllowUserToAddRows = false;
            this.OrderGrid.AllowUserToDeleteRows = false;
            this.OrderGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnUnitPrice,
            this.ColumnQuantity,
            this.ColumnPrice});
            this.OrderGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OrderGrid.Location = new System.Drawing.Point(294, 236);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.ReadOnly = true;
            this.OrderGrid.RowHeadersWidth = 45;
            this.OrderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGrid.Size = new System.Drawing.Size(488, 211);
            this.OrderGrid.TabIndex = 0;
            this.OrderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Naziv";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 110;
            // 
            // ColumnUnitPrice
            // 
            this.ColumnUnitPrice.HeaderText = "Cijena stavke";
            this.ColumnUnitPrice.MinimumWidth = 6;
            this.ColumnUnitPrice.Name = "ColumnUnitPrice";
            this.ColumnUnitPrice.ReadOnly = true;
            this.ColumnUnitPrice.Width = 110;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.HeaderText = "Količina";
            this.ColumnQuantity.MinimumWidth = 6;
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            this.ColumnQuantity.Width = 110;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Cijena";
            this.ColumnPrice.MinimumWidth = 6;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Width = 110;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(4)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(294, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(4)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(707, 484);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Printaj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.AutoSize = true;
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.ForeColor = System.Drawing.Color.White;
            this.txtGrandTotal.Location = new System.Drawing.Point(434, 480);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(150, 25);
            this.txtGrandTotal.TabIndex = 3;
            this.txtGrandTotal.Text = "Ukupno (KM): ";
            this.txtGrandTotal.Click += new System.EventHandler(this.txtGrandTotal_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtNarudzba
            // 
            this.txtNarudzba.AutoSize = true;
            this.txtNarudzba.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNarudzba.ForeColor = System.Drawing.Color.White;
            this.txtNarudzba.Location = new System.Drawing.Point(336, 19);
            this.txtNarudzba.Name = "txtNarudzba";
            this.txtNarudzba.Size = new System.Drawing.Size(132, 31);
            this.txtNarudzba.TabIndex = 4;
            this.txtNarudzba.Text = "Narudžbe";
            this.txtNarudzba.Click += new System.EventHandler(this.txtNarudzba_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.White;
            this.cbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(53, 131);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(148, 21);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtFilterCategory
            // 
            this.txtFilterCategory.AutoSize = true;
            this.txtFilterCategory.ForeColor = System.Drawing.Color.White;
            this.txtFilterCategory.Location = new System.Drawing.Point(50, 107);
            this.txtFilterCategory.Name = "txtFilterCategory";
            this.txtFilterCategory.Size = new System.Drawing.Size(79, 13);
            this.txtFilterCategory.TabIndex = 6;
            this.txtFilterCategory.Text = "Filter Kategorija";
            this.txtFilterCategory.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbListItems
            // 
            this.lbListItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbListItems.FormattingEnabled = true;
            this.lbListItems.Location = new System.Drawing.Point(53, 236);
            this.lbListItems.Name = "lbListItems";
            this.lbListItems.Size = new System.Drawing.Size(148, 277);
            this.lbListItems.TabIndex = 7;
            this.lbListItems.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Enabled = false;
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(294, 131);
            this.tbName.Margin = new System.Windows.Forms.Padding(0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(157, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.tbUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUnitPrice.Enabled = false;
            this.tbUnitPrice.ForeColor = System.Drawing.Color.White;
            this.tbUnitPrice.Location = new System.Drawing.Point(479, 132);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(157, 20);
            this.tbUnitPrice.TabIndex = 9;
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.tbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuantity.ForeColor = System.Drawing.Color.White;
            this.tbQuantity.Location = new System.Drawing.Point(294, 180);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(157, 20);
            this.tbQuantity.TabIndex = 10;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.tbTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotalPrice.Enabled = false;
            this.tbTotalPrice.ForeColor = System.Drawing.Color.White;
            this.tbTotalPrice.Location = new System.Drawing.Point(479, 180);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(157, 20);
            this.tbTotalPrice.TabIndex = 11;
            this.tbTotalPrice.TextChanged += new System.EventHandler(this.tbTotalPrice_TextChanged);
            // 
            // btnAddOrderItem
            // 
            this.btnAddOrderItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnAddOrderItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddOrderItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(82)))), ((int)(((byte)(4)))));
            this.btnAddOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrderItem.ForeColor = System.Drawing.Color.White;
            this.btnAddOrderItem.Location = new System.Drawing.Point(670, 174);
            this.btnAddOrderItem.Name = "btnAddOrderItem";
            this.btnAddOrderItem.Size = new System.Drawing.Size(112, 31);
            this.btnAddOrderItem.TabIndex = 12;
            this.btnAddOrderItem.Text = "Dodaj u narudžbu";
            this.btnAddOrderItem.UseVisualStyleBackColor = false;
            this.btnAddOrderItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.AutoSize = true;
            this.txtNaziv.ForeColor = System.Drawing.Color.White;
            this.txtNaziv.Location = new System.Drawing.Point(291, 107);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(34, 13);
            this.txtNaziv.TabIndex = 13;
            this.txtNaziv.Text = "Naziv";
            this.txtNaziv.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoSize = true;
            this.txtUnitPrice.ForeColor = System.Drawing.Color.White;
            this.txtUnitPrice.Location = new System.Drawing.Point(476, 107);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(71, 13);
            this.txtUnitPrice.TabIndex = 14;
            this.txtUnitPrice.Text = "Cijena stavke";
            this.txtUnitPrice.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.ForeColor = System.Drawing.Color.White;
            this.txtQuantity.Location = new System.Drawing.Point(291, 164);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(44, 13);
            this.txtQuantity.TabIndex = 15;
            this.txtQuantity.Text = "Količina";
            this.txtQuantity.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.ForeColor = System.Drawing.Color.White;
            this.txtTotalPrice.Location = new System.Drawing.Point(476, 164);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(77, 13);
            this.txtTotalPrice.TabIndex = 16;
            this.txtTotalPrice.Text = "Ukupna Cijena";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.White;
            this.lblGrandTotal.Location = new System.Drawing.Point(600, 480);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(36, 25);
            this.lblGrandTotal.TabIndex = 18;
            this.lblGrandTotal.Text = "12";
            this.lblGrandTotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // UC_Narudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnAddOrderItem);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbListItems);
            this.Controls.Add(this.txtFilterCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtNarudzba);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.OrderGrid);
            this.Name = "UC_Narudzba";
            this.Size = new System.Drawing.Size(830, 550);
            this.Load += new System.EventHandler(this.UC_Narudzba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label txtGrandTotal;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label txtNarudzba;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.Label txtFilterCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ListBox lbListItems;
        private System.Windows.Forms.Button btnAddOrderItem;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label txtNaziv;
        private System.Windows.Forms.Label txtUnitPrice;
        private System.Windows.Forms.Label txtQuantity;
        private System.Windows.Forms.Label txtTotalPrice;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}
