using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Coursework_2_library
{
    public partial class Form7 : Form
    {
        public Form7(string inString)
        {
            InitializeComponent();
            conString = inString;
        }
        string conString;
        SQLiteConnection dbCon;
        SQLiteDataAdapter daBooks;
        DataTable dtBooks = new DataTable();

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(conString))
                {
                    string sqlcommand =
                        @"Select book.bookid, book.title, author.fname, author.sname, category.type FROM book INNER JOIN author on book.bookid = author.authorid INNER JOIN category on category.categoryid= book.categoryid WHERE category.type = ('science fiction');";

                    daBooks = new SQLiteDataAdapter(sqlcommand, dbCon);
                    daBooks.Fill(dtBooks);

                    dataGridView1.DataSource = dtBooks;

                    dataGridView1.DefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
