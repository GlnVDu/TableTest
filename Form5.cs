using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTest1.Data;

namespace TableTest1
{
    public partial class Form5 : Form
    {
        public Form5(int Id)
        {
            InitializeComponent();
            using DataContext db = new DataContext();
            var books = db.Author.Where(i => 1.AuthorId == Id);
            foreach (var book in books)
            {
                listView1.Items.Add(book.ToString());
            }
        }
    }
}
