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
    /// Customer datatype
    /// </summary>
    public class Customer
    {
        private int idNumber;
        /// <summary>
        /// Getter and setter for number
        /// throw exception for value is less than 0
        /// </summary>
        public int IDNumber
        {
            get { return idNumber; }
            set
            {
                if (value >= 0)
                {
                    idNumber = value;
                }
                else
                {
                    throw new InvalidValueException("Number is less than 0");
                }
            }
        }
        private string name;
        /// <summary>
        /// Getter and setter for name
        /// throw exception for empty or null string
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new InvalidStringException("Enter Name");
                }
            }
        }
        private string phone;
        /// <summary>
        /// Getter and setter for phone
        /// throw exception for empty or null string
        /// throw exception for invalid phonestring
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    phone = value;
                }
                else
                {
                    throw new InvalidStringException("Enter PhoneNumber");
                }
                if (!phone.All(char.IsDigit))
                {
                    throw new InvalidStringException("Invalid Phonenumber");
                }
            }
        }
        private string email;
        /// <summary>
        /// Getter and setter for email
        /// throw exception for empty or null string
        /// throw exception for invalid emailstring
        /// </summary>
        public string EMail
        {
            get { return email; }
            set
            {
                
                if (!string.IsNullOrEmpty(value))
                {
                    email = value;
                }
                else
                {
                    throw new InvalidStringException("Enter Emailadress");
                }
                if (email.All(x => x.ToString() != "@"))
                {
                    throw new InvalidStringException("Invalid Emailadress, @ missing");
                }

            }
        }
        /// <summary>
        /// public getter and setter for ArchivedOrders 
        /// </summary>
        public List<Order> ArchivedOrders { get; set; } = new List<Order>();

        /// <summary>
        /// Constructor for customers
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public Customer(int _number,string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            EMail = email;
            idNumber = _number;
        }

        public Customer() { }
        /// <summary>
        /// Returns data of customer
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"CID: {idNumber}, Name: {Name}, Phone: {Phone}, Email: {EMail}";
        }

        public List<Order> GetArchivedOrders(Customer customer) {
            return customer.ArchivedOrders.Where(x => x.Dispatched == true && DateTime.Compare(DateTime.Today.AddMonths(-1), x.OrderDate) >= 0).ToList();
        }

        public List<Order> GetOrderFromCustomer(List<Order> list)
        {
            return list.Where(x => x.Customer.IDNumber == IDNumber).ToList();
        }

    }
}
