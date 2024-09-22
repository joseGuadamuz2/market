using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class frmBill : Form
    {
        #region Variables

        // List to store all available articles
        public List<Article> articles = new List<Article>();

        // List to store the articles added to the current bill
        public List<Article> articlesBill = new List<Article> { };

        // List to store bills
        public List<Bill> billList2 = new List<Bill>();

        // Variables to track the article ID, name, price, and amount
        public int idArt = 0;
        public string nameArt = "";
        public string nameClient = "Cliente"; // Default client name
        public float price = 0;
        public float amount = 0;
        public float tsum = 0; // Total sum of the bill
        public int idBill; // Bill ID

        #endregion

        #region Constructor

        // Constructor that initializes the form with the bill ID and articles list
        public frmBill(int id, List<Article> art)
        {
            InitializeComponent();

            // Assign the bill ID and display it on the form
            idBill = id;
            lblShowID.Text = idBill.ToString();

            // Assign the list of articles passed to the form
            articles = art;

            // Set default client name and total sum label
            txtName.Text = "Cliente";
            lblAllPriceShow.Text = nameClient;
        }

        #endregion

        #region Events

        // Event handler for searching an article by its ID
        private void btnSearchArticle_Click(object sender, EventArgs e)
        {
            // Loop through the articles list to find the one matching the entered ID
            foreach (var article in articles)
            {
                if (article.ID.ToString() == txtID.Text)
                {
                    // Display article details (name, amount, price) and assign values to variables
                    lblNameProdutShow.Text = article.Name;
                    txtAmount.Text = article.Amount.ToString();
                    lblPriceShow.Text = article.Price.ToString();
                    idArt = article.ID;
                    nameArt = article.Name;
                    price = float.Parse(article.Price.ToString());
                    amount = float.Parse(article.Amount.ToString());
                }
            }
        }

        // Event handler for adding an article to the bill
        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            // Get the entered amount and calculate the total price for that article
            amount = float.Parse(txtAmount.Text);
            price = price * float.Parse(txtAmount.Text);

            // Add the article to the bill's article list
            articlesBill.Add(new Article(idArt, nameArt, price, amount));

            // Update the total sum and refresh the data grid view
            totalSum();
            chargedata();
        }

        // Event handler when the user enters the article ID text box
        private void txtID_Enter(object sender, EventArgs e)
        {
            // Same logic as in btnSearchArticle_Click to display article details based on ID
            foreach (var article in articles)
            {
                if (article.ID.ToString() == txtID.Text)
                {
                    lblNameProdutShow.Text = article.Name;
                    txtAmount.Text = article.Amount.ToString();
                    lblPriceShow.Text = article.Price.ToString();
                    idArt = article.ID;
                    nameArt = article.Name;
                    price = float.Parse(article.Price.ToString());
                    amount = float.Parse(article.Amount.ToString());
                }
            }
        }

        // Event handler for saving the current bill
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Cast the owner form to frmMain and add the current bill to the main form's list
            frmMain f1 = Owner as frmMain;
            f1.addListBill(idBill, nameClient, articlesBill, tsum);

            // Update the main form's data grid view with the new bill
            f1.chargeListMain();

            // Close the bill form
            Close();
        }

        #endregion

        #region Methods

        // Method to refresh the data grid view with the list of articles in the current bill
        public void chargedata()
        {
            dgvitems.DataSource = null;
            dgvitems.DataSource = articlesBill;
        }

        // Method to calculate the total sum of all articles in the bill
        public void totalSum()
        {
            // Sum up the price of each article in the bill
            foreach (var art in articlesBill)
            {
                tsum = tsum + art.Price;
            }

            // Update the total sum label with the calculated value
            lblAllPriceShow.Text = tsum.ToString();
        }

        #endregion
    }
}

