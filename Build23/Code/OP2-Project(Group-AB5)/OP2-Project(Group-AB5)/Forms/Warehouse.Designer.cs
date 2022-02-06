namespace OP2_Project_Group_AB5_
{
    partial class Warehouse
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
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerEMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.lstSelectedProducts = new System.Windows.Forms.ListBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnGetDispatchedOrders = new System.Windows.Forms.Button();
            this.btnGetPendingOrders = new System.Windows.Forms.Button();
            this.btnGetOrdersFromCustomer = new System.Windows.Forms.Button();
            this.btnSetDispatched = new System.Windows.Forms.Button();
            this.btnChangeCustomer = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnChangeProduct = new System.Windows.Forms.Button();
            this.btnArchivedOrders = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioAllProducts = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.radioZeroStock = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOrderProducts = new System.Windows.Forms.Button();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.lblRestockDate = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.Location = new System.Drawing.Point(145, 323);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(105, 41);
            this.btnAddNewOrder.TabIndex = 0;
            this.btnAddNewOrder.Text = "Add Order";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddOrder);
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.Location = new System.Drawing.Point(196, 16);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(514, 212);
            this.lstCustomer.TabIndex = 2;
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(7, 12);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(894, 303);
            this.lstOrders.TabIndex = 3;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(72, 16);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(118, 20);
            this.txtCustomerName.TabIndex = 4;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(72, 42);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(118, 20);
            this.txtCustomerPhone.TabIndex = 5;
            // 
            // txtCustomerEMail
            // 
            this.txtCustomerEMail.Location = new System.Drawing.Point(72, 68);
            this.txtCustomerEMail.Name = "txtCustomerEMail";
            this.txtCustomerEMail.Size = new System.Drawing.Size(118, 20);
            this.txtCustomerEMail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "E-Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(72, 94);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(118, 40);
            this.btnAddCustomer.TabIndex = 10;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(72, 186);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(118, 40);
            this.btnRemoveCustomer.TabIndex = 11;
            this.btnRemoveCustomer.Text = "Remove Selected ";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Delivery Address:";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Location = new System.Drawing.Point(7, 339);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(132, 20);
            this.txtDeliveryAddress.TabIndex = 12;
            // 
            // lstSelectedProducts
            // 
            this.lstSelectedProducts.FormattingEnabled = true;
            this.lstSelectedProducts.Location = new System.Drawing.Point(7, 12);
            this.lstSelectedProducts.Name = "lstSelectedProducts";
            this.lstSelectedProducts.Size = new System.Drawing.Size(243, 303);
            this.lstSelectedProducts.TabIndex = 16;
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(345, 12);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(243, 303);
            this.lstProducts.TabIndex = 17;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(256, 12);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(83, 61);
            this.btnAddItems.TabIndex = 18;
            this.btnAddItems.Text = "<-- Add";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(256, 79);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 61);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remove -->";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnGetDispatchedOrders
            // 
            this.btnGetDispatchedOrders.Location = new System.Drawing.Point(590, 323);
            this.btnGetDispatchedOrders.Name = "btnGetDispatchedOrders";
            this.btnGetDispatchedOrders.Size = new System.Drawing.Size(99, 41);
            this.btnGetDispatchedOrders.TabIndex = 20;
            this.btnGetDispatchedOrders.Text = "Get only dispatched orders";
            this.btnGetDispatchedOrders.UseVisualStyleBackColor = true;
            this.btnGetDispatchedOrders.Click += new System.EventHandler(this.btnGetDispatchedOrders_Click);
            // 
            // btnGetPendingOrders
            // 
            this.btnGetPendingOrders.Location = new System.Drawing.Point(695, 323);
            this.btnGetPendingOrders.Name = "btnGetPendingOrders";
            this.btnGetPendingOrders.Size = new System.Drawing.Size(93, 41);
            this.btnGetPendingOrders.TabIndex = 21;
            this.btnGetPendingOrders.Text = "Get only pending orders";
            this.btnGetPendingOrders.UseVisualStyleBackColor = true;
            this.btnGetPendingOrders.Click += new System.EventHandler(this.btnGetPendingOrders_Click);
            // 
            // btnGetOrdersFromCustomer
            // 
            this.btnGetOrdersFromCustomer.Location = new System.Drawing.Point(721, 80);
            this.btnGetOrdersFromCustomer.Name = "btnGetOrdersFromCustomer";
            this.btnGetOrdersFromCustomer.Size = new System.Drawing.Size(88, 69);
            this.btnGetOrdersFromCustomer.TabIndex = 22;
            this.btnGetOrdersFromCustomer.Text = "Get all orders from selected customer";
            this.btnGetOrdersFromCustomer.UseVisualStyleBackColor = true;
            this.btnGetOrdersFromCustomer.Click += new System.EventHandler(this.btnGetOrdersFromCustomer_Click);
            // 
            // btnSetDispatched
            // 
            this.btnSetDispatched.Location = new System.Drawing.Point(7, 323);
            this.btnSetDispatched.Name = "btnSetDispatched";
            this.btnSetDispatched.Size = new System.Drawing.Size(93, 41);
            this.btnSetDispatched.TabIndex = 23;
            this.btnSetDispatched.Text = "Dispatch Orders";
            this.btnSetDispatched.UseVisualStyleBackColor = true;
            this.btnSetDispatched.Click += new System.EventHandler(this.btnSetDispatched_Click);
            // 
            // btnChangeCustomer
            // 
            this.btnChangeCustomer.Location = new System.Drawing.Point(72, 140);
            this.btnChangeCustomer.Name = "btnChangeCustomer";
            this.btnChangeCustomer.Size = new System.Drawing.Size(118, 40);
            this.btnChangeCustomer.TabIndex = 24;
            this.btnChangeCustomer.Text = "Change Selected";
            this.btnChangeCustomer.UseVisualStyleBackColor = true;
            this.btnChangeCustomer.Click += new System.EventHandler(this.btnChangeCustomer_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(345, 323);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(115, 41);
            this.btnAddProduct.TabIndex = 25;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(118, 323);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(104, 41);
            this.btnPayment.TabIndex = 26;
            this.btnPayment.Text = "Complete Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnChangeProduct
            // 
            this.btnChangeProduct.Location = new System.Drawing.Point(479, 323);
            this.btnChangeProduct.Name = "btnChangeProduct";
            this.btnChangeProduct.Size = new System.Drawing.Size(109, 41);
            this.btnChangeProduct.TabIndex = 28;
            this.btnChangeProduct.Text = "Change Product";
            this.btnChangeProduct.UseVisualStyleBackColor = true;
            this.btnChangeProduct.Click += new System.EventHandler(this.btnChangeProduct_Click);
            // 
            // btnArchivedOrders
            // 
            this.btnArchivedOrders.Location = new System.Drawing.Point(721, 159);
            this.btnArchivedOrders.Name = "btnArchivedOrders";
            this.btnArchivedOrders.Size = new System.Drawing.Size(88, 69);
            this.btnArchivedOrders.TabIndex = 29;
            this.btnArchivedOrders.Text = "Get all archived orders of customer";
            this.btnArchivedOrders.UseVisualStyleBackColor = true;
            this.btnArchivedOrders.Click += new System.EventHandler(this.btnArchivedOrders_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnArchivedOrders);
            this.groupBox1.Controls.Add(this.btnChangeCustomer);
            this.groupBox1.Controls.Add(this.btnRemoveCustomer);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Controls.Add(this.btnGetOrdersFromCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomerEMail);
            this.groupBox1.Controls.Add(this.txtCustomerPhone);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.lstCustomer);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 243);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1540, 518);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioAllProducts);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.btnAddProduct);
            this.groupBox2.Controls.Add(this.radioZeroStock);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAddNewOrder);
            this.groupBox2.Controls.Add(this.btnChangeProduct);
            this.groupBox2.Controls.Add(this.btnAddItems);
            this.groupBox2.Controls.Add(this.lstProducts);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lstSelectedProducts);
            this.groupBox2.Controls.Add(this.txtDeliveryAddress);
            this.groupBox2.Location = new System.Drawing.Point(5, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 373);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // radioAllProducts
            // 
            this.radioAllProducts.AutoSize = true;
            this.radioAllProducts.Location = new System.Drawing.Point(256, 146);
            this.radioAllProducts.Name = "radioAllProducts";
            this.radioAllProducts.Size = new System.Drawing.Size(36, 17);
            this.radioAllProducts.TabIndex = 37;
            this.radioAllProducts.TabStop = true;
            this.radioAllProducts.Text = "All";
            this.radioAllProducts.UseVisualStyleBackColor = true;
            this.radioAllProducts.CheckedChanged += new System.EventHandler(this.radioAllProducts_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(4, 302);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "Total:";
            // 
            // radioZeroStock
            // 
            this.radioZeroStock.AutoSize = true;
            this.radioZeroStock.Location = new System.Drawing.Point(256, 169);
            this.radioZeroStock.Name = "radioZeroStock";
            this.radioZeroStock.Size = new System.Drawing.Size(86, 17);
            this.radioZeroStock.TabIndex = 38;
            this.radioZeroStock.TabStop = true;
            this.radioZeroStock.Text = "Non-stocked";
            this.radioZeroStock.UseVisualStyleBackColor = true;
            this.radioZeroStock.CheckedChanged += new System.EventHandler(this.radioZeroStock_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOrderProducts);
            this.groupBox4.Controls.Add(this.btnWriteToFile);
            this.groupBox4.Controls.Add(this.btnPayment);
            this.groupBox4.Controls.Add(this.btnSetDispatched);
            this.groupBox4.Controls.Add(this.btnGetPendingOrders);
            this.groupBox4.Controls.Add(this.btnGetDispatchedOrders);
            this.groupBox4.Controls.Add(this.lstOrders);
            this.groupBox4.Location = new System.Drawing.Point(606, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(911, 373);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order";
            // 
            // btnOrderProducts
            // 
            this.btnOrderProducts.Location = new System.Drawing.Point(243, 321);
            this.btnOrderProducts.Name = "btnOrderProducts";
            this.btnOrderProducts.Size = new System.Drawing.Size(92, 41);
            this.btnOrderProducts.TabIndex = 35;
            this.btnOrderProducts.Text = "Get Products In Selected Order";
            this.btnOrderProducts.UseVisualStyleBackColor = true;
            this.btnOrderProducts.Click += new System.EventHandler(this.btnOrderProducts_Click);
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.Location = new System.Drawing.Point(794, 323);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(107, 41);
            this.btnWriteToFile.TabIndex = 31;
            this.btnWriteToFile.Text = "Write orders to file";
            this.btnWriteToFile.UseVisualStyleBackColor = true;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // lblRestockDate
            // 
            this.lblRestockDate.AutoSize = true;
            this.lblRestockDate.Location = new System.Drawing.Point(347, 256);
            this.lblRestockDate.Name = "lblRestockDate";
            this.lblRestockDate.Size = new System.Drawing.Size(76, 13);
            this.lblRestockDate.TabIndex = 33;
            this.lblRestockDate.Text = "Restock Date:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(347, 272);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 36;
            this.lblStock.Text = "Stock:";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 662);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblRestockDate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerEMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.ListBox lstSelectedProducts;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnGetDispatchedOrders;
        private System.Windows.Forms.Button btnGetPendingOrders;
        private System.Windows.Forms.Button btnGetOrdersFromCustomer;
        private System.Windows.Forms.Button btnSetDispatched;
        private System.Windows.Forms.Button btnChangeCustomer;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnChangeProduct;
        private System.Windows.Forms.Button btnArchivedOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblRestockDate;
        private System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RadioButton radioAllProducts;
        private System.Windows.Forms.RadioButton radioZeroStock;
        private System.Windows.Forms.Button btnOrderProducts;
    }
}

