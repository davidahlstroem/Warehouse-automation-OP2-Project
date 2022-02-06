using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Products datatype
    /// </summary>
    public class OrderLine
    {
        /// <summary>
        /// Getter and setter for product and count
        /// </summary>
        public Product Product { get; set; }
        public int Count { get; set; }



        /// <summary>
        /// Constructor for orderline
        /// </summary>
        /// <param name="product"></param>
        /// <param name="count"></param>
        public OrderLine(Product product, int count)
        {
            Product = product;
            Count = count;
        }

        public OrderLine() { }

        /// <summary>
        /// returns products
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ISBN: {Product.Code}, {Product.Name}, ${Product.Price}";

        }

    }
}
