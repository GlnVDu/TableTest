using TableTest1.Data;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace TableTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateBooks();
        }
        public void UpdateBooks()
        {
            listView1.Items.Clear();
            using DataContext dc = new DataContext();
            var list = dc.Books.ToList();
            foreach (var books in list)
            {
                listView1.Items.Add(books.Name);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using DataContext dc = new DataContext();
            var listBooks = dc.Books.Select(g => new { g.Id, g.Name }).ToList();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            string path = sfd.FileName;
            string json = JsonConvert.SerializeObject(listBooks, Formatting.Indented);

            using StreamWriter sstream = new StreamWriter(path);
            sstream.Write(json);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var  item in listView1.SelectedItems) {
            var temp = item as ListViewItem;
                var text = temp.Text;
                using DataContext dataContext = new DataContext();
                var book = dataContext.Author.First(i => 1.Name == text);
                ListBooks ls = new ListBooks(author.Id);
                ls show;

            }
        }
    }
}