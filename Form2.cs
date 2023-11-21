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
using Newtonsoft.Json;

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

            using DataContext DC = new DataContext();
            var author = DC.Author.ToList();
            foreach (var ath in author)
            {
                comboBox1.Items.Add(ath);
            }

            Books a = new() { Name = textBox1.Text, Year = Convert.ToInt32(textBox5.Text), Janr = textBox4.Text};

            DC.Books.Add(a);
            
                DC.SaveChanges();
            Close();
            MessageBox.Show("Book was added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
