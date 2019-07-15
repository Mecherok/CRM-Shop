using BLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMUI {
    public partial class Catalog<T> : Form where T : class {
        CRMContext db;
        DbSet<T> set;

        public Catalog(DbSet<T> set, CRMContext db) {
            InitializeComponent();
            this.db = db;
            this.set = set;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (typeof(T) == typeof(Product)) {
                //var form = new CustomerForm();
                //if (form.ShowDialog() == DialogResult.OK) {
                //    db.Customers.Add(form.Customer);
                //    db.SaveChanges();
                //}
            } else if (typeof(T) == typeof(Seller)) {

            } else if (typeof(T) == typeof(Customer)) {

            }
        }

        private void button2_Click(object sender, EventArgs e) {
            var ID = dataGridView.SelectedRows[0].Cells[0].Value;
            if (typeof(T) == typeof(Product)) {
                var product = set.Find(ID) as Product;
                if (product != null) {
                    var form = new ProductForm(product);
                    if (form.ShowDialog() == DialogResult.OK) {
                        product = form.Product;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            } else if (typeof(T) == typeof(Seller)) {
                var seller = set.Find(ID) as Seller;
                if (seller != null) {
                    var form = new SellerForm(seller);
                    if (form.ShowDialog() == DialogResult.OK) {
                        seller = form.Seller;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            } else if (typeof(T) == typeof(Customer)) {
                var customer = set.Find(ID) as Customer;
                if (customer != null) {
                    var form = new CustomerForm(customer);
                    if (form.ShowDialog() == DialogResult.OK) {
                        customer = form.Customer;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {

        }
    }
}
