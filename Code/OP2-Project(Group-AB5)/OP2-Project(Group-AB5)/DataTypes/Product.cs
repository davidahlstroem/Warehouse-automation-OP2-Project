using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Product datatype
    /// </summary>
    public class Product
    {
        private int code;
        /// <summary>
        /// getter and setter for code
        /// throws an exception when number is trying to be set lower than 0
        /// </summary>
        public int Code {
            get { return code; }
            set
            {
                if (value >= 0)
                {
                    code = value;
                }
                else
                {
                    throw new InvalidValueException("Number is less than 0");
                }
            }
        }
        /// <summary>
        /// Public variables for name and price 
        /// </summary>
        public string Name { get; set; }
        public double Price { get; set; }
        public bool ProductExists { get; set; }

        private int stock;
        /// <summary>
        /// Getter and sett for stock
        /// throws an exception when stock is trying to be lowered to less than 0
        /// </summary>
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (value >= 0)
                {
                    stock = value;
                }
                else
                {
                    throw new InvalidValueException("Out of stock!");
                }
            }
        }
        /// <summary>
        /// public variables for FirstAvailable and NextStocking
        /// </summary>
        public DateTime FirstAvailable { get; set; }
        public DateTime NextStocking { get; set; }

        /// <summary>
        /// Constructor for products
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        /// <param name="firstAvailable"></param>
        /// <param name="nextStocking"></param>
        public Product(int code, string name, double price, int stock, DateTime firstAvailable, DateTime nextStocking)
        {
            Code = code;
            Name = name;
            Price = price;
            Stock = stock;
            FirstAvailable = firstAvailable;
            NextStocking = nextStocking;
        }
        public Product() { }

        /// <summary>
        /// returns values 
        /// </summary>
        /// <returns></returns>
        public static List<IGrouping<Product, Product>> GetGroupedItemList(List<Product> selectedItemList)
        {
            return selectedItemList.GroupBy(x => x).ToList();
        }

        public static List<OrderLine> GetProductList(List<IGrouping<Product, Product>> groupedItemsList)
        {
            
            return groupedItemsList.Select(items => new OrderLine(items.Key, items.Count())).ToList();
        }

        public static List<Product> GetZeroStock(List<Product> list)
        {
            return list.Where(prod => prod.Stock == 0).ToList();
        }


        public override string ToString()
        {
            return $"{Name}, ${Price}, ISBN: {Code}";
        }

           

            
    }
}
