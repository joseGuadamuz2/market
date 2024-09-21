using market;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace market
{
    public partial class frmMain : Form
    {
        
        const string Local = "Verdulería Cuendis";
        int counter = 0;
        List<Article> articles = new List<Article>();
        public List<Bill> billList = new List<Bill>();
        List<Article> articlesBill = new List<Article> { };
        frmMain MainForm; 
        BindingSource bindingSource = new BindingSource();
       


        public frmMain()
        {
            InitializeComponent();
            lblLocal.Text = Local;
            articles.Add(new Article(1, "papa", 200, 1));
            articles.Add(new Article(2, "yuca", 200, 1));
            articles.Add(new Article(3, "chayote", 200, 1));
            /*
           
            billList.Add(new Bill(2, "luis", articles, 1000));
            billList.Add(new Bill(1, "Jose", articles, 1000));
            billList.Add(new Bill(2, "luis", articles, 1000));
            */
            billList.Add(new Bill(1, "Jose", articles, 1000));
            chargeListMain();

        }
        private void btnNewBill_Click(object sender, EventArgs e)
        {
            counter++;
            frmBill frmBill = new frmBill(counter, articles, this);
            AddOwnedForm(frmBill);
            frmBill.ShowDialog();
            
        }

        public void chargeListMain()
        {
            dgvMain.DataSource = null;
            
            // Asignar la lista de facturas al DataGridView
            dgvMain.DataSource = billList;


        }

        public void addListBill(int idbill, string nameClient, List<Article>articlesBill,float tsum)
        {
            billList.Add(new Bill(idbill, nameClient, articlesBill, tsum));
        }

        

    }
}
