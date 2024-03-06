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
    public partial class Form10 : Form
    {
        public Form10(string inString)
        {
            InitializeComponent();
            conString = inString;
        }
        string conString;

        SQLiteConnection dbCon;
        SQLiteDataAdapter daMem;
        DataTable dtMem = new DataTable();

        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(conString))
                {
                    string sqlcommand =
                        @"Select* FROM member;";

                    daMem = new SQLiteDataAdapter(sqlcommand, dbCon);
                    daMem.Fill(dtMem);

                    dataGridView1.DataSource = dtMem;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
