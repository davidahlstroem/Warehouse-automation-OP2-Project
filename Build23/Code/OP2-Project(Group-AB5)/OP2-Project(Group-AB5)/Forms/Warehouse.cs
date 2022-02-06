using OP2_Project_Group_AB5_.Exceptions;
using OP2_Project_Group_AB5_.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;
/// <summary>
/// 2020-10-26
/// Group AB5 -
/// André Normann
/// Viktor Klang
/// Denise Peterson
/// David Ahlström
/// </summary>
namespace OP2_Project_Group_AB5_
{
    public partial class Warehouse : Form
    {
        Manager<Customer> customerManager = new Manager<Customer>();
        Manager<Order> orderManager = new Manager<Order>();
        Manager<Product> prodManager = new Manager<Product>();
        Func<Order> GetSelectedOrder;
        Func<Customer> GetSelectedCustomer;
        Func<Product> GetSelectedProduct;
        private double priceTotal;


        /// <summary>
        /// constructor for warehouse
        /// initiates all events and updates productslist
        /// </summary>
        public Warehouse()
        {
            InitializeComponent();
            customerManager.ListEvent += RefreshListboxes;
            orderManager.ListEvent += RefreshListboxes;
            Methods.SetProductsList(prodManager);
            Methods.SetCustomerList(customerManager);
            UpdateProductsList();
            WatchNewOrders();

            GetSelectedCustomer = () => lstCustomer.SelectedItem != null ? lstCustomer.SelectedItem as Customer : throw new NoSelectedItemException("No customer selected");
            GetSelectedOrder = () => lstOrders.SelectedItem != null ? lstOrders.SelectedItem as Order : throw new NoSelectedItemException("No Order selected");
            GetSelectedProduct = () => lstProducts.SelectedItem != null ? lstProducts.SelectedItem as Product : throw new NoSelectedItemException("No Product selected");
        }
        
        /// <summary>
        /// Clears and add all items in prodlist.productList into the lstProducts listbox
        /// </summary>
        private void UpdateProductsList()
        {

            lstProducts.Items.Clear();
            foreach (Product item in prodManager.GetList())
            
            {
                lstProducts.Items.Add(item);
            }
        }

        public void RefreshListboxes()
        {
            UpdateProductsList();
            PopulateListBox(lstCustomer, customerManager.GetList());
            PopulateListBox(lstOrders, orderManager.GetList());
        }

        

        /// <summary>
        /// takes information from textboxes and
        /// Adds a customer into the list inside customermanager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int number;
                do
                {
                    number = Methods.GetRandomNumber();
                } while (!Methods.CheckForUniqueNumber(number, customerManager.GetList().Select(x => x.IDNumber)));
                Customer customer = new Customer(number, txtCustomerName.Text, txtCustomerPhone.Text, txtCustomerEMail.Text);
                customerManager.Add(customer);
                txtCustomerName.Clear();
                txtCustomerPhone.Clear();
                txtCustomerEMail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        /// <summary>
        /// Adds an order with the selected customer, delivery adress textbox and selected products
        /// btn order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOrder(object sender, EventArgs e)
        {
            int number;
            do
            {
                number = Methods.GetRandomNumber();
            } while (!Methods.CheckForUniqueNumber(number, orderManager.GetList().Select(x => x.OrderNumber)));

            try
            {
                Customer customer = GetSelectedCustomer();
                List<Product> selectedItemsList = lstSelectedProducts.Items.Cast<Product>().ToList();

                if (selectedItemsList.Count <= 0)
                    throw new InvalidValueException("Please select a product");

                List<IGrouping<Product, Product>> groupedItemsList = Product.GetGroupedItemList(selectedItemsList);

                List<OrderLine> productsList = Product.GetProductList(groupedItemsList);

                orderManager.Add(new Order(number, customer, DateTime.Now, txtDeliveryAddress.Text, productsList));
                lstSelectedProducts.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtDeliveryAddress.Clear();
            priceTotal = 0;
            lblTotal.Text = "Total: $" + priceTotal;
            UpdateProductsList();

        }

        /// <summary>
        /// Adds selected item into the selected products listbox and reduces stock of item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnAddItems_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = GetSelectedProduct();
                if (prod == null) return;

                lstSelectedProducts.Items.Add(lstProducts.SelectedItem);
                priceTotal += prod.Price;
                
                lblTotal.Text = "Total: $" + priceTotal;
                lblRestockDate.Text = "Restock Date: ";
                lblStock.Text = "Stock: ";
                UpdateProductsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// removes the selected item from the selected products listbox and adds it back to the products list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lstProducts.Items.Add(lstSelectedProducts.SelectedItem);


                if (lstSelectedProducts.SelectedItem is Product prod)
                {
                    priceTotal -= prod.Price;
                    lblTotal.Text = "Total: $" + priceTotal;
                    lstSelectedProducts.Items.Remove(lstSelectedProducts.SelectedItem);
                    UpdateProductsList();
                }
                else
                {
                    MessageBox.Show("No selected product");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void btnChangeProduct_Click(object sender, EventArgs e)
        {
            
            Product selectedProduct = lstSelectedProducts.SelectedItem as Product;
            try
            {
                Product prod = GetSelectedProduct();
                if (!lstSelectedProducts.Items.Cast<object>().Any(x => x == prod))
                {
                    {
                        ProductForm changeProdForm = new ProductForm(prod, prodManager);
                        if (changeProdForm.ShowDialog() != DialogResult.OK) return;
                        UpdateProductsList();
                    }
                }
                else
                {
                    MessageBox.Show("Cannot change an already selected product, remove to change");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// adds new orders from file
        /// </summary>
        private void WatchNewOrders()
        {
            FileSystemWatcher fsw = new FileSystemWatcher("./neworders", "*.json");
            fsw.SynchronizingObject = this;
            fsw.Created += Fsw_Created;
            fsw.EnableRaisingEvents = true;
        }

        /// <summary>
        /// Logic for adding orders from file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                Thread.Sleep(500);
                string json = File.ReadAllText(e.FullPath);
                List<Order> readFromFileList = JsonSerializer.Deserialize<List<Order>>(json);

                foreach ((Order item, OrderLine items, Product prods) in readFromFileList.SelectMany(item => item.Items.SelectMany(items => prodManager.GetList().Select(prods => (item, items, prods)))))
                {
                    if (items.Product.Name == prods.Name) //Finds if the product exists in current catalogue and sets productExists to true if it exists
                    {
                        items.Product = prods;
                        items.Product.ProductExists = true;
                    }

                }

                foreach ((Order item, OrderLine items) in readFromFileList.SelectMany(item => item.Items.Where(items => !items.Product.ProductExists).Select(items => (item, items))))
                {
                    MessageBox.Show($"{items.Product.Name} does not exist in current catalogue. Payment refunded for order {item.OrderNumber}."); //refunds payment for orders with products that dont exist.
                    if (item.PaymentCompleted)
                    {
                        item.PaymentRefunded = true;
                    }
                }

                HashSet<int> sentIDs = new HashSet<int>(orderManager.GetList().Select(s => s.OrderNumber));


                readFromFileList.GroupBy(x => x.OrderNumber).SelectMany(g => g.Skip(1)).ToList().ForEach(x => readFromFileList.Remove(x)); // remove duplicates from orders


                readFromFileList.Where(m => !sentIDs.Contains(m.OrderNumber)).ToList().ForEach(x => orderManager.Add(x)); // add new orders


                sentIDs = new HashSet<int>(customerManager.GetList().Select(s => s.IDNumber));
                List<Order> customersToRemove = readFromFileList.GroupBy(x => x.Customer.IDNumber).SelectMany(g => g.Skip(1)).ToList(); // get duplicate customers
                readFromFileList.Select(x => x.Customer).Where(m => !sentIDs.Contains(m.IDNumber)).ToList().ForEach(p => customerManager.Add(p)); // add all customers
                customersToRemove.ForEach(x => customerManager.Remove(x.Customer)); //remove duplciate customers
                readFromFileList.Select(x => x.Items);


                customerManager.InvokeEvent();
                orderManager.InvokeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Gets all pending orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetPendingOrders_Click(object sender, EventArgs e)
        {
            lstOrders.Items.Clear();
            PopulateListBox(lstOrders, Order.GetDispatched(orderManager.GetList(), false));
        }

        /// <summary>
        /// Gets all dispatched orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetDispatchedOrders_Click(object sender, EventArgs e)
        {
            lstOrders.Items.Clear();
            PopulateListBox(lstOrders, Order.GetDispatched(orderManager.GetList(), true));
        }

        /// <summary>
        /// Gets all orders from the selected customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetOrdersFromCustomer_Click(object sender, EventArgs e)
        {
            lstOrders.Items.Clear();
            try
            {
                Customer customer = GetSelectedCustomer();
                PopulateListBox(lstOrders, customer.GetOrderFromCustomer(orderManager.GetList()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// sets the selected order to dispatched
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetDispatched_Click(object sender, EventArgs e)
        {

            foreach (Order order in Order.DispatchedOrderQuery(orderManager.GetList()))
            {
                order.Dispatched = true;
                try
                {
                    switch (order.Dispatched)
                    {
                        case true:
                            MessageBox.Show(order.OrderNumber + " was successfully dispatched.");
                            order.Customer.ArchivedOrders.Add(order);
                            break;
                        case false:
                            order.PaymentRefunded = true;
                            order.PaymentCompleted = false;
                            MessageBox.Show($"{order.OrderNumber} Failed to dispatch, stock is depleted. Payment has been refunded");
                            break;
                    }
                }
                catch (InvalidValueException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            UpdateProductsList();
            orderManager.InvokeEvent();
        }

        /// <summary>
        /// Changes the selected customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Ska tas bort?
        private void btnChangeCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer selected = GetSelectedCustomer();
                Customer customer = new Customer(selected.IDNumber, txtCustomerName.Text, txtCustomerPhone.Text, txtCustomerEMail.Text);
                customerManager.Change(selected, customer);
                txtCustomerName.Clear();
                txtCustomerPhone.Clear();
                txtCustomerEMail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Removes the selected custoemr inside the lstCustomer listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = GetSelectedCustomer();
                customerManager.Remove(customer);
                lstCustomer.Items.Remove(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// fills selected listbox with an array for items
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lb"></param>
        /// <param name="items"></param>
        private void PopulateListBox<T>(ListBox lb, List<T> items)
        {
            lb.Items.Clear();
            items.ForEach(x => lb.Items.Add(x));
        }

        /// <summary>
        /// opens a new form to add a product into the productslist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProduct_Click(object sender, EventArgs e) 
        {
            ProductForm addProdForm = new ProductForm(prodManager);
            if (addProdForm.ShowDialog() == DialogResult.OK)
            {
                UpdateProductsList();
            }
        }

        /// <summary>
        /// sets the selected order 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = GetSelectedOrder();
                order.PaymentCompleted = true;
                orderManager.InvokeEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Gets the selected costumer's archived order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArchivedOrders_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = GetSelectedCustomer();
                string finishedString = "";
                List<Order> archived = customer.GetArchivedOrders(customer);
                archived.ForEach(x => finishedString += x.ToString() + "\n");
                MessageBox.Show(finishedString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Populates textboxes with customer information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Order order = GetSelectedOrder();
                txtCustomerEMail.Text = order.Customer.EMail;
                txtCustomerName.Text = order.Customer.Name;
                txtCustomerPhone.Text = order.Customer.Phone;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Show relevant information in labels when a product in the list are selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Product product = GetSelectedProduct();
                lblRestockDate.Text = "Restock Date: " + product.NextStocking;
                lblStock.Text = "Stock: " + product.Stock;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            Methods.WriteToFile(orderManager.GetList(), "orders.json");
        }

        private void radioZeroStock_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioZeroStock.Checked) return;

            lstProducts.Items.Clear();
            PopulateListBox(lstProducts, Product.GetZeroStock(prodManager.GetList()));
        }

        private void radioAllProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioAllProducts.Checked) return;
            UpdateProductsList();
        }

        private void btnOrderProducts_Click(object sender, EventArgs e)
        {

            try
            {
                Order order = GetSelectedOrder();

                string prods = "";
                order.Items.ForEach(x => prods += x.Product.Name + " (" + x.Count + "), ");

                MessageBox.Show(prods);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
