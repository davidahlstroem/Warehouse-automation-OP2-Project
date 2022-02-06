using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

/// <summary>
/// 2020-10-26
/// Group AB5 -
/// André Normann
/// Viktor Klang
/// Denise Peterson
/// David Ahlström
/// </summary>
/// 
namespace OP2_Project_Group_AB5_
{
    public class Methods
    {
        private static readonly Random rand = new Random();
        private static readonly object syncLock = new object();

        /// <summary>
        /// Gets a random number with a maxlength.
        /// </summary>
        /// <returns></returns>
        public static int GetRandomNumber()
        {
            const int MIN = 10000;
            const int MAX = int.MaxValue;
            const int MAXLENGTH = 5;
            lock (syncLock)
            {
                int rnd = rand.Next(MIN, MAX);
                return int.Parse(rnd.ToString().Length <= MAXLENGTH
                    ? rnd.ToString()
                    : rnd.ToString().Substring(0, MAXLENGTH));
            }
        }

        /// <summary>
        /// Checks for unique number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public static bool CheckForUniqueNumber(int number, IEnumerable<int> list)
        {
            return list.All(checkNumber => checkNumber != number);
        }

        /// <summary>
        /// hardcoded for startup
        /// </summary>
        /// <param name="manager"></param>
        public static void SetCustomerList(Manager<Customer> manager)
        {
            manager.Add(new Customer(GetRandomNumber(), "Kurt", "073451334", "mejl@mejl.com"));
            manager.Add(new Customer(GetRandomNumber(), "Ingvar", "073451233", "mejl2@mejl.com"));
        }

        /// <summary>
        /// Productlist
        /// </summary>
        /// <param name="manager"></param>
        public static void SetProductsList(Manager<Product> manager)
        {
            manager.Add(new Product(GetRandomNumber(), "Phone", 2099, 3, DateTime.Today, new DateTime(2020, 11, 01)));
            manager.Add(new Product(GetRandomNumber(), "Chair", 300, 8, DateTime.Today, new DateTime(2020, 11, 01)));
            manager.Add(new Product(GetRandomNumber(), "Computer", 3500, 4, DateTime.Today, new DateTime(2020, 11, 01)));
            manager.Add(new Product(GetRandomNumber(), "Table", 500, 6, DateTime.Today, new DateTime(2020, 11, 01)));
            manager.Add(new Product(GetRandomNumber(), "Wallet", 40, 8, DateTime.Today, new DateTime(2020, 11, 01)));
            manager.Add(new Product(GetRandomNumber(), "Monitor", 1000, 0, DateTime.Today, new DateTime(2020, 11, 01)));
            manager.Add(new Product(GetRandomNumber(), "Keyboard", 400, 0, DateTime.Today, new DateTime(2020, 11, 01)));
        }

        /// <summary>
        /// Writes content to file
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="filename"></param>
        public static void WriteToFile(List<Order> orders, string filename)
        {
            string contents = JsonSerializer.Serialize(orders);
            File.WriteAllText("./neworders/" + filename, contents);
        }

    }
}