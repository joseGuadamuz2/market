using System.Collections.Generic;
using System.Reflection.Metadata;

namespace market
{
    public partial class frmMain : Form
    {

        const string Local = "Verdulería Cuendis";
        int counter = 0;
        List<Article> articles = new List<Article>();
        public List<Bill> billList1=new List<Bill>();
        frmMain MainForm;



        public frmMain()
        {
            InitializeComponent();
            lblLocal.Text = Local;
            articles.Add(new Article(1, "papa", 200, 1));
            articles.Add(new Article(2, "yuca", 200, 1));
            articles.Add(new Article(3, "chayote", 200, 1));
            

        }
        private void btnNewBill_Click(object sender, EventArgs e)
        {
            counter++;
            frmBill frmBill = new frmBill(counter, articles, this);
            frmBill.ShowDialog();
        }

        public void chargeListMain(List<Bill> nw)
        {
            dgvMain.DataSource = null;
            dgvMain.DataSource = nw;



        }
    }
}
