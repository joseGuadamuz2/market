using market;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace market
{
    public partial class frmMain : Form
    {
        #region Variables

        // Constant for the local market name
        const string marketName = "Verdulería Los Cuendis";

        // Counter to track bill numbers
        int counter = 0;

        // List to store available articles (products)
        List<Article> articles = new List<Article>();

        // List to store bills
        public List<Bill> billList = new List<Bill>();

        // Temporary list to hold articles for a specific bill
        List<Article> articlesBill = new List<Article> { };

        #endregion


        #region Constructor
        // Constructor for the main form
        public frmMain()
        {
            InitializeComponent();

            // Set the label to the market name
            lblLocal.Text = marketName;

            // Add sample articles (vegetables) to the list
            articles.Add(new Article(1, "papa", 200, 1));
            articles.Add(new Article(2, "yuca", 200, 1));
            articles.Add(new Article(3, "chayote", 200, 1));
            articles.Add(new Article(4, "zanahoria", 150, 1));
            articles.Add(new Article(5, "tomate", 120, 1));
            articles.Add(new Article(6, "pepino", 180, 1));
            articles.Add(new Article(7, "cebolla", 100, 1));
            articles.Add(new Article(8, "lechuga", 130, 1));
            articles.Add(new Article(9, "calabacín", 170, 1));
            articles.Add(new Article(10, "berenjena", 160, 1));
            articles.Add(new Article(11, "coliflor", 210, 1));
            articles.Add(new Article(12, "brocoli", 220, 1));
            articles.Add(new Article(13, "remolacha", 140, 1));
            articles.Add(new Article(14, "espinaca", 110, 1));
            articles.Add(new Article(15, "pimiento", 200, 1));
            articles.Add(new Article(16, "apio", 190, 1));
            articles.Add(new Article(17, "nabo", 125, 1));
            articles.Add(new Article(18, "rábano", 135, 1));
            articles.Add(new Article(19, "repollo", 115, 1));
            articles.Add(new Article(20, "ajo", 90, 1));

            // Load the articles into the main list view
            chargeListMain();
        }
        #endregion

        #region Events
        // Event handler for creating a new bill
        private void btnNewBill_Click(object sender, EventArgs e)
        {
            // Increment the bill counter
            counter++;

            // Create a new bill form, passing the counter, articles, and the main form reference
            frmBill frmBill = new frmBill(counter, articles);

            // Set the new bill form as an owned form to this one
            AddOwnedForm(frmBill);

            // Show the new bill form as a dialog
            frmBill.ShowDialog();
        }

        #endregion

        #region Events

        // Method to load the list of bills into the DataGridView
        public void chargeListMain()
        {
            // Clear the current data source
            dgvMain.DataSource = null;

            // Set the DataGridView data source to the list of bills
            dgvMain.DataSource = billList;
        }

        // Method to add a new bill to the list
        public void addListBill(int idbill, string nameClient, List<Article> articlesBill, float tsum)
        {
            
            // Add a new bill with the provided information
            billList.Add(new Bill(idbill, nameClient, articlesBill, tsum));
        }

        #endregion


    }
}
