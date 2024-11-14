namespace Final_Project
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procossingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.procossingToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // procossingToolStripMenuItem
            // 
            this.procossingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.newOrderToolStripMenuItem});
            this.procossingToolStripMenuItem.Name = "procossingToolStripMenuItem";
            this.procossingToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.procossingToolStripMenuItem.Text = "Manage";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductsToolStripMenuItem,
            this.editProductsToolStripMenuItem,
            this.deleteProductsToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // addProductsToolStripMenuItem
            // 
            this.addProductsToolStripMenuItem.Name = "addProductsToolStripMenuItem";
            this.addProductsToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.addProductsToolStripMenuItem.Text = "Add products";
            this.addProductsToolStripMenuItem.Click += new System.EventHandler(this.addProductsToolStripMenuItem_Click);
            // 
            // editProductsToolStripMenuItem
            // 
            this.editProductsToolStripMenuItem.Name = "editProductsToolStripMenuItem";
            this.editProductsToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.editProductsToolStripMenuItem.Text = "Edit products";
            this.editProductsToolStripMenuItem.Click += new System.EventHandler(this.editProductsToolStripMenuItem_Click);
            // 
            // deleteProductsToolStripMenuItem
            // 
            this.deleteProductsToolStripMenuItem.Name = "deleteProductsToolStripMenuItem";
            this.deleteProductsToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.deleteProductsToolStripMenuItem.Text = "Delete products";
            this.deleteProductsToolStripMenuItem.Click += new System.EventHandler(this.deleteProductsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomersToolStripMenuItem,
            this.editCustomersToolStripMenuItem,
            this.deleteCustomersToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // addCustomersToolStripMenuItem
            // 
            this.addCustomersToolStripMenuItem.Name = "addCustomersToolStripMenuItem";
            this.addCustomersToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.addCustomersToolStripMenuItem.Text = "Add customers";
            this.addCustomersToolStripMenuItem.Click += new System.EventHandler(this.addCustomersToolStripMenuItem_Click);
            // 
            // editCustomersToolStripMenuItem
            // 
            this.editCustomersToolStripMenuItem.Name = "editCustomersToolStripMenuItem";
            this.editCustomersToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.editCustomersToolStripMenuItem.Text = "Edit customers";
            this.editCustomersToolStripMenuItem.Click += new System.EventHandler(this.editCustomersToolStripMenuItem_Click);
            // 
            // deleteCustomersToolStripMenuItem
            // 
            this.deleteCustomersToolStripMenuItem.Name = "deleteCustomersToolStripMenuItem";
            this.deleteCustomersToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.deleteCustomersToolStripMenuItem.Text = "Delete Customers";
            this.deleteCustomersToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomersToolStripMenuItem_Click);
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newOrderToolStripMenuItem.Text = "New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem1,
            this.orderReportToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.systemToolStripMenuItem.Text = "Reports";
            // 
            // productsToolStripMenuItem1
            // 
            this.productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            this.productsToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.productsToolStripMenuItem1.Text = "Product Report";
            this.productsToolStripMenuItem1.Click += new System.EventHandler(this.productsToolStripMenuItem1_Click);
            // 
            // orderReportToolStripMenuItem
            // 
            this.orderReportToolStripMenuItem.Name = "orderReportToolStripMenuItem";
            this.orderReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.orderReportToolStripMenuItem.Text = "Bill Report";
            this.orderReportToolStripMenuItem.Click += new System.EventHandler(this.orderReportToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.ebc586cadc96876179ca2c459210908a1;
            this.pictureBox1.Location = new System.Drawing.Point(380, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 378);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.ebc586cadc96876179ca2c459210908a;
            this.pictureBox2.Location = new System.Drawing.Point(147, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 62);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Final_Project.Properties.Resources.ebc586cadc96876179ca2c459210908a1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(435, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 279);
            this.button1.TabIndex = 3;
            this.button1.Text = "Manage your things from here";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::Final_Project.Properties.Resources.ebc586cadc96876179ca2c459210908a1;
            this.label3.Location = new System.Drawing.Point(110, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 190);
            this.label3.TabIndex = 9;
            this.label3.Text = "   The \r\nGallery";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.ebc586cadc96876179ca2c459210908a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 491);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Order Processing Systerm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procossingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomersToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}