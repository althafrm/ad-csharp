using BookManagement.Business.Interfaces;
using BookManagement.Business.Services;
using BookManagement.Data.Models;
using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.Forms
{
    public partial class Customer : Form
    {
        private readonly IcustomerService _customerService;
        public Customer()
        {
            _customerService = new CustomerService();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new CustomerModel();
            customer.Name = txtName.Text;
            customer.Nic = txtNic.Text;
            customer.Contact = txtContact.Text;
            _customerService.AddCustomer(customer);
            LoadCustomers();
            MessageBox.Show("Customer added successfully!");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var customers = _customerService.GetAllCustomer();
            dataGridView1.DataSource = customers;
        }
    }
}
