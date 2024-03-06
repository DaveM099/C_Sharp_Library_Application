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
    public partial class Form11 : Form
    {
        public Form11(string inString)
        {
            InitializeComponent();
            conString = inString;
        }
        string conString;

        SQLiteConnection dbCon;
        SQLiteDataAdapter daAu;
        DataTable dtAu= new DataTable();


        private void Form11_Load(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(conString))
                {
                    string sqlcommand =
                        @"Select author.authorid, author.fname, author.sname, book.title FROM author INNER JOIN book on author.authorid = book.authorid ;";

                    daAu = new SQLiteDataAdapter(sqlcommand, dbCon);
                    daAu.Fill(dtAu);

                    dataGridView1.DataSource = dtAu;

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
