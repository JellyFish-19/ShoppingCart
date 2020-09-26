namespace ShoppingCart
{
    partial class frmShoppingCart
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabOrderForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblItemsOrdered = new System.Windows.Forms.Label();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.labalCC = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMailingLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabOrderForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ShoppingCart.Properties.Resources.wallpaper;
            this.pictureBox1.Image = global::ShoppingCart.Properties.Resources.techShopLogo;
            this.pictureBox1.Location = new System.Drawing.Point(199, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabOrderForm
            // 
            this.tabOrderForm.Controls.Add(this.tabPage1);
            this.tabOrderForm.Controls.Add(this.tabPage2);
            this.tabOrderForm.Controls.Add(this.tabPage3);
            this.tabOrderForm.Location = new System.Drawing.Point(199, 145);
            this.tabOrderForm.Name = "tabOrderForm";
            this.tabOrderForm.SelectedIndex = 0;
            this.tabOrderForm.Size = new System.Drawing.Size(566, 403);
            this.tabOrderForm.TabIndex = 1;
            this.tabOrderForm.SelectedIndexChanged += new System.EventHandler(this.tabShoppingCart_selectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbProduct);
            this.tabPage1.Controls.Add(this.cbProducts);
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.btnNewOrder);
            this.tabPage1.Controls.Add(this.lblItemsOrdered);
            this.tabPage1.Controls.Add(this.buttonAddOrder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbProduct
            // 
            this.pbProduct.ImageLocation = "";
            this.pbProduct.Location = new System.Drawing.Point(34, 134);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(437, 237);
            this.pbProduct.TabIndex = 6;
            this.pbProduct.TabStop = false;
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(156, 21);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(244, 21);
            this.cbProducts.TabIndex = 5;
            this.cbProducts.SelectedValueChanged += new System.EventHandler(this.cbProducts_SelectedValueChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(477, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(477, 305);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 3;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lblItemsOrdered
            // 
            this.lblItemsOrdered.AutoSize = true;
            this.lblItemsOrdered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblItemsOrdered.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemsOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblItemsOrdered.Location = new System.Drawing.Point(216, 98);
            this.lblItemsOrdered.Name = "lblItemsOrdered";
            this.lblItemsOrdered.Size = new System.Drawing.Size(108, 18);
            this.lblItemsOrdered.TabIndex = 2;
            this.lblItemsOrdered.Text = "Items Ordered: 0";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(216, 60);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(108, 23);
            this.buttonAddOrder.TabIndex = 1;
            this.buttonAddOrder.Text = "Add to Order";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCC);
            this.tabPage2.Controls.Add(this.labalCC);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.lblAddress);
            this.tabPage2.Controls.Add(this.txtPostcode);
            this.tabPage2.Controls.Add(this.lblPostcode);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.lblTotalCost);
            this.tabPage2.Controls.Add(this.lstProducts);
            this.tabPage2.Controls.Add(this.lblAdress);
            this.tabPage2.Controls.Add(this.txtFullName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shopping Cart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCC
            // 
            this.txtCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCC.Location = new System.Drawing.Point(324, 309);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(172, 20);
            this.txtCC.TabIndex = 10;
            // 
            // labalCC
            // 
            this.labalCC.AutoSize = true;
            this.labalCC.Location = new System.Drawing.Point(321, 293);
            this.labalCC.Name = "labalCC";
            this.labalCC.Size = new System.Drawing.Size(65, 13);
            this.labalCC.TabIndex = 9;
            this.labalCC.Text = "City/Country";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(47, 309);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(172, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(44, 293);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address line:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostcode.Location = new System.Drawing.Point(324, 249);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(172, 20);
            this.txtPostcode.TabIndex = 6;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(321, 233);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(55, 13);
            this.lblPostcode.TabIndex = 5;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 231);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Full name:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblTotalCost.Location = new System.Drawing.Point(47, 159);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(105, 24);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(47, 31);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(467, 108);
            this.lstProducts.TabIndex = 2;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblAdress.Location = new System.Drawing.Point(44, 208);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(106, 13);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "Delivery Address:";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Location = new System.Drawing.Point(47, 247);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(172, 22);
            this.txtFullName.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtMailingLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(558, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mailing Label";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShoppingCart.Properties.Resources.thanks;
            this.pictureBox2.Location = new System.Drawing.Point(38, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(495, 44);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.brnExitSecondButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "New Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NewOrderSecondButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shipped to:";
            // 
            // txtMailingLabel
            // 
            this.txtMailingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMailingLabel.Enabled = false;
            this.txtMailingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtMailingLabel.Location = new System.Drawing.Point(35, 39);
            this.txtMailingLabel.Multiline = true;
            this.txtMailingLabel.Name = "txtMailingLabel";
            this.txtMailingLabel.Size = new System.Drawing.Size(377, 75);
            this.txtMailingLabel.TabIndex = 0;
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::ShoppingCart.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(983, 578);
            this.Controls.Add(this.tabOrderForm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Shop";
            this.Load += new System.EventHandler(this.frmShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabOrderForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabOrderForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Label lblItemsOrdered;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TextBox txtMailingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label labalCC;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

