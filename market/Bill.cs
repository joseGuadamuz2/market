using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market
{

    #region Variables
    public class Bill
    {
        // Property to article the id of the bill
        public int ID { get; set; }

        // Property to store the client's name
        public string ClientName { get; set; }

        // Property to store the list of purchased items
        public List<Article> Items { get; set; }

        // Private property to store the total amount of the bill
        public float Total { get; set; }
        #endregion

        #region Constructor

        // Default constructor
        public Bill() { }

        /// <summary>
        /// Constructor that initializes a bill with a client name and purchased items.
        /// </summary>
        /// <param name="clientName">Client's name</param>
        /// <param name="items">List of items in the bill</param>
        public Bill(int id, string clienteName, List<Article> items, float total) 
        {
            // Initializes properties with the received values
            ID = id;
            ClientName = clienteName;
            Items = items;
            Total = total;
        }

        #endregion

        


    }
}
