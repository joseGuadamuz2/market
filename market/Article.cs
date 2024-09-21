using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market
{
    #region Variables
    public class Article
    {

        // Property to article the id of the item
        public int ID { get; set; }

        // Property to article the name of the item
        public string Name { get; set; }

        // Property to article the price of the item
        public float Price { get; set; }

        public float Amount { get; set; }

        #endregion

        #region Constructor
        public Article() { }


        /// <summary>
        /// Constructor that initializes an article item with specified properties.
        /// </summary>
        /// <param name="id">ID of the item</param>
        /// <param name="name">Name of the item</param>
        /// <param name="price">Price of the item</param>
        /// <param name="amount">Amount of the items</param>
        public Article(int id, string name, float price,float amount) 
        { 
            ID = id;
            Name= name;
            Price= price;
            Amount= amount;
        }
        #endregion 

    }
}
