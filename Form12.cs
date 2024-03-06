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
    public partial class Form12 : Form
    {
        public Form12(string inString)
        {
            InitializeComponent();
            conString = inString;
        }
        string conString;

        SQLiteConnection dbCon = new SQLiteConnection();

        SQLiteDataAdapter daTitle;
        SQLiteDataAdapter daMem;
        SQLiteDataAdapter daloan;

        DataTable dtTitle = new DataTable();
        DataTable dtMem = new DataTable();
        DataTable dtloan = new DataTable();

        string sql1 = @"Select bookid, title From book";
        string sql2 = @"Select memberid, fname, sname From member";
        string sql3 = @"Select* From loan";

        private void Form12_Load(object sender, EventArgs e)
        {
            try
            {
                //assign connection string to SQLiteConnection
                dbCon.ConnectionString = conString;

                //set up DataAdapters
                daTitle = new SQLiteDataAdapter(sql1, dbCon);
                daMem = new SQLiteDataAdapter(sql2, dbCon);
                daloan = new SQLiteDataAdapter(sql3, dbCon);

                //Fill DataTables
                daTitle.Fill(dtTitle);
                daMem.Fill(dtMem);
                daloan.Fill(dtloan);

                //Bind dtTitle to Title ComboBox
                cbTitle.DataSource = dtTitle;
                cbTitle.DisplayMember = "title";
                cbTitle.ValueMember = "bookid";
                cbTitle.SelectedIndex = -1;

                //Bind dtMem to Member ComboBox
                cbMem.DataSource = dtMem;
                cbMem.DisplayMember = "fname";
                cbMem.ValueMember = "memberid";
                cbMem.SelectedIndex = -1;

               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void cbMem_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void checkStatus()
        {
            //activate submit button only if all fields have an entry 
            if (cbTitle.SelectedIndex != -1
                && cbMem.SelectedIndex != -1)
            {
                btnSub.Enabled = true;
            }
            else
            {
                btnSub.Enabled = false;
            }
        }

        //insert a new loan record
        private void btnSub_Click(object sender, EventArgs e)
        {
            //set up a SQLiteCommand object
            using (SQLiteCommand dbCmd = dbCon.CreateCommand())
            {
                try
                {
                    dbCmd.CommandText =
                    @"Insert Into loan (bookid, memberid, dateout, datedue)"
                 + @" Values(@Title, @Memb, @dte, @due)";

                   
                    dbCmd.Parameters.AddWithValue("Title", cbTitle.SelectedValue);
                    dbCmd.Parameters.AddWithValue("Memb", cbMem.SelectedValue);
                    dbCmd.Parameters.AddWithValue("due", dtp1);
                    


                    // get current date in a suitable format 
                    DateTime time = DateTime.Now;
                    dbCmd.Parameters.AddWithValue("dte", time.ToString("yyyy-MM-dd"));
                    




                    //update database with new loan details
                    dbCon.Open();
                    int changed = dbCmd.ExecuteNonQuery();
                    if (changed == 1)
                        MessageBox.Show(" new loan added successfully");
                    dbCon.Close();
                    btnCancel_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
