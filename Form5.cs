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
    public partial class Form5 : Form
    {
        public Form5(string inString)
        {
            InitializeComponent();
            conString = inString;
        }
        string conString;
        SQLiteConnection dbCon;
        SQLiteDataAdapter daDue;
        DataTable dtDue = new DataTable();

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(conString))
                {
                    string sqlcommand =
                        @"Select loan.loanid, book.title, member.fname, member.sname, loan.dateout, loan.datedue, loan.datereturned FROM loan INNER JOIN member on loan.memberid = member.memberid INNER JOIN book on loan.bookid= book.bookid WHERE datedue>date('2022-02-03');";

                    daDue = new SQLiteDataAdapter(sqlcommand, dbCon);
                    daDue.Fill(dtDue);

                    dataGridView1.DataSource = dtDue;

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
