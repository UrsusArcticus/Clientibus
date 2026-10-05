using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clientibus.DataClasses;

namespace Clientibus {
    public partial class CustomerControl : UserControl {

        private Customer customer;
        public CustomerControl() {
            InitializeComponent();
        }

        public DatabaseContext DatabaseContext { get; set; }

        public void CreateNewCustomer() {
            customer = new Customer();
            DatabaseContext.Customers.Add(customer);
            DatabaseContext.SaveChanges();
        }

        public Customer GetCustomer() {
            if (customer == null) {
                customer = new Customer();
            }
            customer.FirstName = textBoxFirstName.Text;
            customer.LastName = textBoxLastName.Text;
            customer.Email = textBoxEmail.Text;
            customer.Phone = textBoxPhone.Text;
            customer.Address = textBoxAddress.Text;
            customer.City = textBoxCity.Text;
            customer.ZipCode = textBoxZip.Text;
            customer.IsActive = checkBoxActive.Checked;
            customer.Description = richTextBoxDescription.Text;
            return customer;
        }

        public void SetCustomer(int customerID) {
            customer = DatabaseContext.Customers.Where(c => c.Id == customerID).First();

            textBoxFirstName.Text = customer.FirstName ?? string.Empty;
            textBoxLastName.Text = customer.LastName ?? string.Empty;
            textBoxEmail.Text = customer.Email ?? string.Empty;
            textBoxPhone.Text = customer.Phone ?? string.Empty;
            textBoxAddress.Text = customer.Address ?? string.Empty;
            textBoxCity.Text = customer.City ?? string.Empty;
            textBoxZip.Text = customer.ZipCode ?? string.Empty;
            checkBoxActive.Checked = customer.IsActive;
            richTextBoxDescription.Text = customer.Description ?? string.Empty;
        }

        public void btnSave_Click(Object sender, EventArgs e) {
            if (customer == null) {
                customer = new Customer();
                DatabaseContext.Customers.Add(customer);
            }
            customer.FirstName = textBoxFirstName.Text;
            customer.LastName = textBoxLastName.Text;
            customer.Email = textBoxEmail.Text;
            customer.Phone = textBoxPhone.Text;
            customer.Address = textBoxAddress.Text;
            customer.City = textBoxCity.Text;
            customer.ZipCode = textBoxZip.Text;
            customer.IsActive = checkBoxActive.Checked;
            customer.Description = richTextBoxDescription.Text;
            DatabaseContext.SaveChanges();
        }
    }
}
