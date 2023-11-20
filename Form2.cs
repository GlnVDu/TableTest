using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTest1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace TableTest1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using DataContext DataContext = new DataContext();
            
            string nameBook = textBox1.Text;
            Books a = new Books() { Name = nameBook };
            DataContext.Books.Add(a);
            DataContext.SaveChanges();

            string nameYear = textBox3.Text;
            int i = Convert.ToInt32(nameYear);
            Books b = new Books() { Year = i };
            DataContext.Books.Add(b);
            DataContext.SaveChanges();

            string nameJanr = textBox4.Text;
            Books c = new Books() { Janr = nameJanr };
            DataContext.Books.Add(c);
            DataContext.SaveChanges();

            string nameAuthor = textBox5.Text;
            Author z = new Author() { Name = nameAuthor };
            DataContext.Author.Add(z);
            DataContext.SaveChanges();




        }
    }
}
