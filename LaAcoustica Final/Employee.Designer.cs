﻿namespace LaAcoustica_Final
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cashier = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totPrice = new System.Windows.Forms.Label();
            this.storageData = new System.Windows.Forms.DataGridView();
            this.cart = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Q = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.prodN = new System.Windows.Forms.Label();
            this.priceN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.brandN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.subcategory = new System.Windows.Forms.ComboBox();
            this.refresh = new FontAwesome.Sharp.IconButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.items = new System.Windows.Forms.Label();
            this.Acc = new System.Windows.Forms.Label();
            this.resetBill = new LaAcoustica_Final.CButton();
            this.printR = new LaAcoustica_Final.CButton();
            this.logout = new LaAcoustica_Final.CButton();
            this.delete = new LaAcoustica_Final.CButton();
            this.edit = new LaAcoustica_Final.CButton();
            this.add = new LaAcoustica_Final.CButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.cashier);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.min);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 37);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseUp);
            // 
            // cashier
            // 
            this.cashier.AutoSize = true;
            this.cashier.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier.ForeColor = System.Drawing.Color.Gold;
            this.cashier.Location = new System.Drawing.Point(283, 2);
            this.cashier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cashier.Name = "cashier";
            this.cashier.Size = new System.Drawing.Size(25, 22);
            this.cashier.TabIndex = 39;
            this.cashier.Text = "   ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(2, 2);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 22);
            this.label10.TabIndex = 38;
            this.label10.Text = "La Acoustica Cashier:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(902, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // min
            // 
            this.min.Image = ((System.Drawing.Image)(resources.GetObject("min.Image")));
            this.min.Location = new System.Drawing.Point(877, 2);
            this.min.Margin = new System.Windows.Forms.Padding(2);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(20, 24);
            this.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min.TabIndex = 2;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(926, 2);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 24);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 1;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(108, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Client\'s Bill";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(9, 492);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(85, 492);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 17;
            // 
            // totPrice
            // 
            this.totPrice.AutoSize = true;
            this.totPrice.BackColor = System.Drawing.Color.AliceBlue;
            this.totPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totPrice.Location = new System.Drawing.Point(121, 492);
            this.totPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totPrice.Name = "totPrice";
            this.totPrice.Size = new System.Drawing.Size(54, 20);
            this.totPrice.TabIndex = 18;
            this.totPrice.Text = "P 0.00";
            // 
            // storageData
            // 
            this.storageData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storageData.BackgroundColor = System.Drawing.Color.LightCoral;
            this.storageData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.storageData.DefaultCellStyle = dataGridViewCellStyle1;
            this.storageData.Location = new System.Drawing.Point(339, 188);
            this.storageData.Margin = new System.Windows.Forms.Padding(2);
            this.storageData.Name = "storageData";
            this.storageData.ReadOnly = true;
            this.storageData.RowHeadersWidth = 51;
            this.storageData.RowTemplate.Height = 24;
            this.storageData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storageData.Size = new System.Drawing.Size(601, 289);
            this.storageData.TabIndex = 19;
            this.storageData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // cart
            // 
            this.cart.BackgroundColor = System.Drawing.Color.LightCoral;
            this.cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart.Location = new System.Drawing.Point(12, 188);
            this.cart.Margin = new System.Windows.Forms.Padding(2);
            this.cart.Name = "cart";
            this.cart.ReadOnly = true;
            this.cart.RowHeadersWidth = 51;
            this.cart.RowTemplate.Height = 24;
            this.cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cart.Size = new System.Drawing.Size(322, 289);
            this.cart.TabIndex = 20;
            this.cart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, -70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(684, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity:";
            // 
            // Q
            // 
            this.Q.Location = new System.Drawing.Point(811, 102);
            this.Q.Margin = new System.Windows.Forms.Padding(2);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(57, 20);
            this.Q.TabIndex = 21;
            this.Q.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(343, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product:";
            // 
            // prodN
            // 
            this.prodN.AutoSize = true;
            this.prodN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodN.ForeColor = System.Drawing.Color.White;
            this.prodN.Location = new System.Drawing.Point(460, 71);
            this.prodN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prodN.Name = "prodN";
            this.prodN.Size = new System.Drawing.Size(0, 19);
            this.prodN.TabIndex = 25;
            // 
            // priceN
            // 
            this.priceN.AutoSize = true;
            this.priceN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceN.ForeColor = System.Drawing.Color.White;
            this.priceN.Location = new System.Drawing.Point(460, 101);
            this.priceN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceN.Name = "priceN";
            this.priceN.Size = new System.Drawing.Size(0, 19);
            this.priceN.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(343, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Price:";
            // 
            // brandN
            // 
            this.brandN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.brandN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandN.FormattingEnabled = true;
            this.brandN.Items.AddRange(new object[] {
            "Squire",
            "Valencia ",
            "Mahalo",
            "Jackson",
            "Gretsch",
            "Fender",
            "Fernando",
            "Zoom",
            "Laney",
            "RockJam",
            "Aguilar",
            "Marshall",
            "Pearl",
            "Gibraltar",
            "Remo",
            "Zildjian",
            "Alesis",
            "M-Audio",
            "Novation",
            "Akai"});
            this.brandN.Location = new System.Drawing.Point(346, 156);
            this.brandN.Margin = new System.Windows.Forms.Padding(2);
            this.brandN.Name = "brandN";
            this.brandN.Size = new System.Drawing.Size(156, 21);
            this.brandN.TabIndex = 28;
            this.brandN.SelectionChangeCommitted += new System.EventHandler(this.FilterData);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(344, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Brand:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(527, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Category:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(700, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "Sub-Category:";
            // 
            // category
            // 
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Guitar",
            "Amplifier",
            "Drums",
            "Keyboards",
            "Others"});
            this.category.Location = new System.Drawing.Point(530, 156);
            this.category.Margin = new System.Windows.Forms.Padding(2);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(156, 21);
            this.category.TabIndex = 34;
            this.category.SelectionChangeCommitted += new System.EventHandler(this.FilterData);
            // 
            // subcategory
            // 
            this.subcategory.AutoCompleteCustomSource.AddRange(new string[] {
            "Guitar"});
            this.subcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.subcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.subcategory.FormattingEnabled = true;
            this.subcategory.Items.AddRange(new object[] {
            "Bass Guitar",
            "Electric Guitar",
            "Acoustic Guitar",
            "Ukulele",
            "Guitar Amplifier",
            "Bass Amplifier",
            "Drum Essentials",
            "Accessories",
            "Drum Kits",
            "Percussions",
            "Cymbals",
            "Digital Pianos",
            "MIDI Controllers",
            "Earphones",
            "Speaker",
            ""});
            this.subcategory.Location = new System.Drawing.Point(703, 156);
            this.subcategory.Margin = new System.Windows.Forms.Padding(2);
            this.subcategory.Name = "subcategory";
            this.subcategory.Size = new System.Drawing.Size(156, 21);
            this.subcategory.TabIndex = 35;
            this.subcategory.SelectionChangeCommitted += new System.EventHandler(this.FilterData);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.White;
            this.refresh.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.refresh.IconColor = System.Drawing.Color.Black;
            this.refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.refresh.IconSize = 35;
            this.refresh.Location = new System.Drawing.Point(873, 133);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(49, 44);
            this.refresh.TabIndex = 37;
            this.refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Location = new System.Drawing.Point(9, 521);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Total Items:";
            // 
            // items
            // 
            this.items.AutoSize = true;
            this.items.BackColor = System.Drawing.Color.AliceBlue;
            this.items.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.items.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.items.Location = new System.Drawing.Point(121, 521);
            this.items.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(54, 20);
            this.items.TabIndex = 39;
            this.items.Text = "P 0.00";
            // 
            // Acc
            // 
            this.Acc.AutoSize = true;
            this.Acc.BackColor = System.Drawing.Color.White;
            this.Acc.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc.ForeColor = System.Drawing.Color.Maroon;
            this.Acc.Location = new System.Drawing.Point(5, 39);
            this.Acc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Acc.Name = "Acc";
            this.Acc.Size = new System.Drawing.Size(25, 22);
            this.Acc.TabIndex = 40;
            this.Acc.Text = "   ";
            // 
            // resetBill
            // 
            this.resetBill.BackColor = System.Drawing.Color.Crimson;
            this.resetBill.BackgroundColor = System.Drawing.Color.Crimson;
            this.resetBill.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.resetBill.BorderRadius = 20;
            this.resetBill.BorderSize = 0;
            this.resetBill.FlatAppearance.BorderSize = 0;
            this.resetBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBill.ForeColor = System.Drawing.Color.White;
            this.resetBill.Location = new System.Drawing.Point(650, 482);
            this.resetBill.Margin = new System.Windows.Forms.Padding(2);
            this.resetBill.Name = "resetBill";
            this.resetBill.Size = new System.Drawing.Size(94, 42);
            this.resetBill.TabIndex = 36;
            this.resetBill.Text = "Reset";
            this.resetBill.TextColor = System.Drawing.Color.White;
            this.resetBill.UseVisualStyleBackColor = false;
            this.resetBill.Click += new System.EventHandler(this.resetBill_Click);
            // 
            // printR
            // 
            this.printR.BackColor = System.Drawing.Color.Crimson;
            this.printR.BackgroundColor = System.Drawing.Color.Crimson;
            this.printR.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.printR.BorderRadius = 20;
            this.printR.BorderSize = 0;
            this.printR.FlatAppearance.BorderSize = 0;
            this.printR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printR.ForeColor = System.Drawing.Color.White;
            this.printR.Location = new System.Drawing.Point(748, 482);
            this.printR.Margin = new System.Windows.Forms.Padding(2);
            this.printR.Name = "printR";
            this.printR.Size = new System.Drawing.Size(94, 42);
            this.printR.TabIndex = 14;
            this.printR.Text = "Print Reciept";
            this.printR.TextColor = System.Drawing.Color.White;
            this.printR.UseVisualStyleBackColor = false;
            this.printR.Click += new System.EventHandler(this.printR_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Crimson;
            this.logout.BackgroundColor = System.Drawing.Color.Crimson;
            this.logout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.logout.BorderRadius = 20;
            this.logout.BorderSize = 0;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(846, 482);
            this.logout.Margin = new System.Windows.Forms.Padding(2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(94, 42);
            this.logout.TabIndex = 13;
            this.logout.Text = "Logout";
            this.logout.TextColor = System.Drawing.Color.White;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Crimson;
            this.delete.BackgroundColor = System.Drawing.Color.Crimson;
            this.delete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.delete.BorderRadius = 20;
            this.delete.BorderSize = 0;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(453, 482);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 42);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete Item";
            this.delete.TextColor = System.Drawing.Color.White;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Crimson;
            this.edit.BackgroundColor = System.Drawing.Color.Crimson;
            this.edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.edit.BorderRadius = 20;
            this.edit.BorderSize = 0;
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(551, 482);
            this.edit.Margin = new System.Windows.Forms.Padding(2);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(94, 42);
            this.edit.TabIndex = 8;
            this.edit.Text = "Update";
            this.edit.TextColor = System.Drawing.Color.White;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Crimson;
            this.add.BackgroundColor = System.Drawing.Color.Crimson;
            this.add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add.BorderRadius = 20;
            this.add.BorderSize = 0;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(355, 482);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 42);
            this.add.TabIndex = 7;
            this.add.Text = "Add to List";
            this.add.TextColor = System.Drawing.Color.White;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(949, 561);
            this.Controls.Add(this.Acc);
            this.Controls.Add(this.items);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.resetBill);
            this.Controls.Add(this.subcategory);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brandN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceN);
            this.Controls.Add(this.prodN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Q);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.storageData);
            this.Controls.Add(this.totPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.printR);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee";
            this.Text = "La Acoustica";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Employee_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CButton add;
        private CButton edit;
        private CButton delete;
        private System.Windows.Forms.Label label4;
        private CButton logout;
        private CButton printR;
        private CButton reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totPrice;
        private System.Windows.Forms.DataGridView storageData;
        private System.Windows.Forms.DataGridView cart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Q;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prodN;
        private System.Windows.Forms.Label priceN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox brandN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.ComboBox subcategory;
        private CButton resetBill;
        private FontAwesome.Sharp.IconButton refresh;
        private System.Windows.Forms.Label label10;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label items;
        private System.Windows.Forms.Label cashier;
        private System.Windows.Forms.Label Acc;
    }
}