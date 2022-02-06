using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
/// <summary>
/// 2020-10-26
/// Group AB5 -
/// André Normann
/// Viktor Klang
/// Denise Peterson
/// David Ahlström
/// </summary>
namespace OP2_Project_Group_AB5_.Forms
{
    public partial class ProductForm : Form
    {
        private Product Product;
        private Manager<Product> prodlist;
        private bool ChangeProduct;

        /// <summary>
        /// Add product form
        /// </summary>
        /// <param name="prodList"></param>
        public ProductForm(Manager<Product> prodList)
        {
            CenterToScreen();
            ChangeProduct = false;
            prodlist = prodList;
            InitializeComponent();
        }

        /// <summary>
        /// sets form to be a change product form
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="prodList"></param>
        public ProductForm(Product prod, Manager<Product> prodList)
        {
            CenterToScreen();
            InitializeComponent();
            ChangeProduct = true;
            Product = prod;
            prodlist = prodList;
            btnAddProduct.Text = "Change product";
        }

        /// <summary>
        /// Adds a product to the prodlist object and then closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtProdName.Text;
                double price = double.Parse(txtProdPrice.Text);
                int stock = int.Parse(txtProdStock.Text);
                DateTime firstAvailable = DTimeFirstAvailable.Value;
                DateTime nextStocking = DTimeNextStocking.Value;

                if (!ChangeProduct)
                {
                    int number;
                    do
                    {
                        number = Methods.GetRandomNumber();
                    } while (!Methods.CheckForUniqueNumber(number, prodlist.GetList().Select(x => x.Code)));

                    prodlist.Add(new Product(number, name, price, stock, firstAvailable, nextStocking));
                }
                else
                {
                    prodlist.Change(Product, new Product(Product.Code, name, price, stock, firstAvailable, nextStocking));
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
