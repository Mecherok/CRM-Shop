using System;
using System.Windows.Forms;
using BLogic.Models;

namespace CRMUI {
    public partial class Main : Form {
        CRMContext db;

        public Main() {
            InitializeComponent();
            db = new CRMContext();
        }

        private void Main_Load(object sender, EventArgs e) {

        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e) {
            var CatalogProduct = new Catalog<Product>(db.Products);
            CatalogProduct.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e) {
            var CatalogSeller = new Catalog<Seller>(db.Sellers);
            CatalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e) {
            var CatalogCustomer = new Catalog<Customer>(db.Customers);
            CatalogCustomer.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e) {
            var CheckCustomer = new Catalog<Check>(db.Checks);
            CheckCustomer.Show();
        }

        private void CustomerAddToolStripMenuItem2_Click(object sender, EventArgs e) {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK) {
                db.Customers.Add(form.Customer);
                db.SaveChanges();             
            }
        }
    }
}
