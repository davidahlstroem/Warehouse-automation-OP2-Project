namespace OP2_Project_Group_AB5_.Forms
{
    partial class ProductForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdStock = new System.Windows.Forms.TextBox();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.DTimeFirstAvailable = new System.Windows.Forms.DateTimePicker();
            this.DTimeNextStocking = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // txtProdStock
            // 
            this.txtProdStock.Location = new System.Drawing.Point(149, 92);
            this.txtProdStock.Name = "txtProdStock";
            this.txtProdStock.Size = new System.Drawing.Size(100, 20);
            this.txtProdStock.TabIndex = 12;
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Location = new System.Drawing.Point(149, 66);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(100, 20);
            this.txtProdPrice.TabIndex = 11;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(149, 40);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 20);
            this.txtProdName.TabIndex = 10;
            // 
            // DTimeFirstAvailable
            // 
            this.DTimeFirstAvailable.Location = new System.Drawing.Point(109, 129);
            this.DTimeFirstAvailable.Name = "DTimeFirstAvailable";
            this.DTimeFirstAvailable.Size = new System.Drawing.Size(200, 20);
            this.DTimeFirstAvailable.TabIndex = 16;
            // 
            // DTimeNextStocking
            // 
            this.DTimeNextStocking.Location = new System.Drawing.Point(111, 165);
            this.DTimeNextStocking.Name = "DTimeNextStocking";
            this.DTimeNextStocking.Size = new System.Drawing.Size(200, 20);
            this.DTimeNextStocking.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "First available:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Next Stocking:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddProduct.Location = new System.Drawing.Point(111, 192);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(118, 35);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 239);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTimeNextStocking);
            this.Controls.Add(this.DTimeFirstAvailable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProdStock);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.txtProdName);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdStock;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.DateTimePicker DTimeFirstAvailable;
        private System.Windows.Forms.DateTimePicker DTimeNextStocking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddProduct;
    }
}