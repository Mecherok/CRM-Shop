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
            var CatalogProduct = new Catalog<Product>(db.Products, db);
            CatalogProduct.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e) {
            var CatalogSeller = new Catalog<Seller>(db.Sellers, db);
            CatalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e) {
            var CatalogCustomer = new Catalog<Customer>(db.Customers, db);
            CatalogCustomer.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e) {
            var CheckCustomer = new Catalog<Check>(db.Checks, db);
            CheckCustomer.Show();
        }

        private void CustomerAddToolStripMenuItem2_Click(object sender, EventArgs e) {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK) {
                db.Customers.Add(form.Customer);
                db.SaveChanges();             
            }
        }

        private void SellerAddToolStripMenuItem1_Click(object sender, EventArgs e) {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK) {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        private void ProductAddToolStripMenuItem_Click(object sender, EventArgs e) {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK) {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }
    }
}
