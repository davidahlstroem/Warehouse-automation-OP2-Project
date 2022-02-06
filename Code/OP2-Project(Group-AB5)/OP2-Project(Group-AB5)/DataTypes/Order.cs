using OP2_Project_Group_AB5_.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

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
    /// <summary>
    /// Order datatype
    /// </summary>
    public class Order
    {
        private int number;
        /// <summary>
        /// Get and set for number
        /// </summary>
        public int OrderNumber
        {
            get
            { return number; }
            set
            {
                number = value;
            }
        }

        private Customer customer;
        /// <summary>
        /// Get and set for customer
        /// throws exception when incoming value is null
        /// </summary>
        public Customer Customer 
        { 
            get { return customer; } 
            set 
            { 
                if (value != null)
                {
                    customer = value;
                }
                else
                {
                    throw new InvalidValueException("No customer selected!");
                }
            }
        }
        public DateTime OrderDate { get; set; }
        private string deliveryAdress;
        /// <summary>
        /// Get and set for delivery adress
        /// throws exception when value empty or null
        /// </summary>
        public string DeliveryAdress
        {
            get { return deliveryAdress; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    deliveryAdress = value;
                }
                else
                {
                    throw new InvalidStringException("No delivery adress given");
                }
            }
        }
        private bool paymentCompleted;

        /// <summary>
        /// Exception handling for paymentCompleted
        /// </summary>
        public bool PaymentCompleted 
        { 
            get { return paymentCompleted; } 
            set 
            {
                paymentCompleted = value;


                if (paymentCompleted == true && dispatched == true)
                {
                    throw new InvalidValueException("Order cannot be completed when the order is already dispatched");
                }
            } 
        }
        private bool refunded;
        /// <summary>
        /// Get and set for refunded
        /// throws exception if dispatched is set to true while order is already dispatched
        /// </summary>
        public bool PaymentRefunded
        {
            get { return refunded; }
            set
            {
                if (Dispatched)
                {
                    refunded = false;
                    throw new InvalidValueException("Order cannot be refunded when the order is already dispatched");
                }
                refunded = value;
                //PaymentCompleted = false;
            }
        }
        private bool dispatched;
        /// <summary>
        /// Get and set for dispatched
        /// throws exception if payment is set to true while payment is not yet completed
        /// </summary>
        public bool Dispatched
        {
            get { return dispatched; }
            set
            {
                if (value && items != null)
                {
                    if (paymentCompleted)
                    {
                        foreach (OrderLine x in items.Where(x => DateTime.Compare(x.Product.FirstAvailable, DateTime.Now) > 0))
                        {
                            throw new InvalidDateException($"First available date is earlier then current date for product {x.Product.Name}, First available: {x.Product.FirstAvailable}");
                        }

                        foreach (OrderLine item in items) //where
                        {
                            if (item.Product.Stock < item.Count)
                            {
                                dispatched = false;

                            }
                            else // cant throw exception here because it goes through all and then cancels execution and wont go through entire list
                            {
                                item.Product.Stock -= item.Count;
                                dispatched = true;
                            }
                        }
                    }
                    else
                    {
                        throw new InvalidValueException("Cannot be dispatched before payment is completed.");
                    }
                }
                else
                {
                    dispatched = value;
                }
            }
        }
        private List<OrderLine> items;
        /// <summary>
        /// Get and set for items
        /// throws an exception if incoming value is null
        /// </summary>
        public List<OrderLine> Items 
        { 
            get { return items; } 
            set 
            {
                Console.WriteLine(value.Count);

                items = value;
            }
        }
        /// <summary>
        /// Constructor for orders 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="customer"></param>
        /// <param name="orderdate"></param>
        /// <param name="_deliveryadress"></param>
        /// <param name="_items"></param>
        public Order(int number, Customer customer, DateTime orderdate, string _deliveryadress, List<OrderLine> _items)
        {
            items = new List<OrderLine>();
            OrderNumber = number;
            Customer = customer;
            OrderDate = orderdate;
            DeliveryAdress = _deliveryadress;
            Items = _items;
        }

        public Order() { }
        /// <summary>
        /// Puts all products into a string and then prints out all variables
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return $"CID: {Customer.IDNumber}, {Customer.Name}, OrderNumber: {OrderNumber}, OrderDate {OrderDate}, Payment Completed: {PaymentCompleted}, Payment Refunded: {PaymentRefunded}, Dispatched: {Dispatched}";
        }

        public List<Order> GetArchivedOrders(Customer customer)
        {
            return customer.ArchivedOrders.Where(x => x.Dispatched == true && DateTime.Compare(DateTime.Today.AddMonths(-1), x.OrderDate) >= 0).ToList();
        }


        public static List<Order> DispatchedOrderQuery(List<Order> list)
        {
            return list.Where(order => order.PaymentCompleted && order.Dispatched == false && order.PaymentRefunded == false).OrderBy(x => x.OrderDate).ToList();
        }


        public static List<Order> GetDispatched(List<Order> list, bool input)
        {
            return list.Where(x => x.Dispatched == input).ToList();
        }
    }
}
