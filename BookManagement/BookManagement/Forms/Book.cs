using BookManagement.Business.Services;
using System;
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
    public partial class Book : Form
    {
        private readonly BookService _bookService;
        public Book()
        {
            InitializeComponent();
            _bookService = new BookService();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            var books = _bookService.GetBooks();
            dataGridView1.DataSource = books;
        }
    }
}
