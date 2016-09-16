using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VidlyForms.Models;

namespace VidlyForms
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var _customerName = txtCustomerName.Text.Trim();

            using(var db = new CustomerContext())
            {
                db.Customers.Add(new Customer { Name = _customerName });
                btnSave.Enabled = false;
                db.SaveChanges();

                foreach (var customer in db.Customers)
                {
                    lstCustomers.Items.Add(customer.Name);
                }
                
            }
        }
    }
}
