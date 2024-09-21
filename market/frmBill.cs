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

        frmMain frmMain1;
        public List<Article> articles = new List<Article>();
        public List<Article> articlesBill = new List<Article> { };
        public List<Bill> billList2 = new List<Bill>();
        public int idArt = 0;
        public string nameArt = "";
        public string nameClient = "Cliente";
        public float price = 0;
        public float amount = 0;
        public float tsum = 0;
        public int idBill;
        public frmBill(int id, List<Article> art, frmMain frm)
        {
            InitializeComponent();
            frmMain frmMain1;
            idBill = id;
            lblShowID.Text = idBill.ToString();
            articles = art;
            txtName.Text = "Cliente";
            lblAllPriceShow.Text = nameClient;
           
            
        }

        private void frmBill_Load(object sender, EventArgs e)
        {

        }

        public void AddItems()
        {

        }

        private void btnSearchArticle_Click(object sender, EventArgs e)
        {
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

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            amount = float.Parse(txtAmount.Text);
            price = price * float.Parse(txtAmount.Text);
            articlesBill.Add(new Article(idArt, nameArt, price, amount));
            totalSum();
            chargedata();
        }

        public void chargedata()
        {
            dgvitems.DataSource = null;
            dgvitems.DataSource = articlesBill;

        }

        public void totalSum()
        {
            foreach (var art in articlesBill)
            {
                tsum = tsum + art.Price;
            }
            lblAllPriceShow.Text = tsum.ToString();
        }

        private void dgvitems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_Enter(object sender, EventArgs e)
        {
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

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            frmMain f1 = Owner as frmMain;
            f1.addListBill(idBill, nameClient, articlesBill, tsum);
            f1.chargeListMain();
            Close();
            
        }

        private void dgvitems_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmBill_FormClosing(object sender, FormClosingEventArgs e)
        {


            
        }
    }
}
