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
    public partial class Form4 : Form
    {
        public Form4(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString;

        SQLiteConnection dbCon;
        SQLiteDataAdapter daLo;
        DataTable dtLo = new DataTable();
        int rowAt;
        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(conString))
                {
                    string sqlcommand =
                                   @"Select loan.loanid, book.title, member.fname, member.sname, loan.dateout, loan.datedue FROM loan INNER JOIN member on loan.memberid = member.memberid INNER JOIN book on loan.bookid= book.bookid;";

                    daLo = new SQLiteDataAdapter(sqlcommand, dbCon);
                    daLo.Fill(dtLo);
                    rowAt = 0;
                    showrecord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void showrecord()
        {
            DataRow row = dtLo.Rows[rowAt];
            lblLoan.Text = "Loan ID:" + row["loanid"].ToString();
            lblTitle.Text = "Book Title:" + row["title"].ToString();
            lblName.Text = "Name:" + row["fname"].ToString();
            lblSname.Text = "Surname:" + row["sname"].ToString();
            DateTime thedate = Convert.ToDateTime(row["dateout"].ToString());
            lblOut.Text = "DateOuT:" + thedate.ToString("yyyy-MM-dd");
            DateTime thedate1 = Convert.ToDateTime(row["datedue"].ToString());
            lblDue.Text = "DateDue:" + thedate1.ToString("yyyy-MM-dd");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rowAt < dtLo.Rows.Count - 1)
            {
                rowAt++;
            }
            else
            {
                rowAt = 0;
            }
            showrecord();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (rowAt > 0)
            {
                rowAt--;
            }
            else
            {
                rowAt = dtLo.Rows.Count - 1;
            }
            showrecord();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
