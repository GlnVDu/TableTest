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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        TableTest1.Data.Author author = new TableTest1.Data.Author();
            author.Name = textBox1.Text;
            author.Country = textBox5.Text; 
           using DataContext dataContext = new DataContext();
            dataContext.Attach(author);
            dataContext.Add(author);
            dataContext.SaveChanges();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
