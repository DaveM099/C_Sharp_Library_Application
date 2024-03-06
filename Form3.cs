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
    public partial class Form3 : Form
    {
        public Form3(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString;

        SQLiteConnection dbCon;
        SQLiteDataAdapter dabk;
        DataTable dtbk = new DataTable();

        private void Form3_Load(object sender, EventArgs e)
        {
            getnames();
        }

        private void getnames()
        {
            try
            {
                //delete any previous entries
                dtbk.Clear();
                //fill with current customers
                using (dbCon = new SQLiteConnection(conString))
                {
                    string sqlcommand = @"Select bookid, title, authorid from book";
                    dabk = new SQLiteDataAdapter(sqlcommand, dbCon);
                    dabk.Fill(dtbk);
                    cbBookID.DataSource = dtbk;
                    cbBookID.DisplayMember = "bookid";
                    cbBookID.ValueMember = "bookid";
                    cbBookID.SelectedIndex = 0;
                    cbBookID2.DataSource = dtbk;
                    cbBookID2.DisplayMember = "bookid";
                    cbBookID2.ValueMember = "bookid";
                    cbBookID2.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        //build command instruction
                        cmd.CommandText = @"Insert Into book"
                                                          + "(bookid, title, authorid, categoryid)"
                                                          + "Values (@BookID, @Title, @AuthorID, @catID)";

                      
                        cmd.Parameters.AddWithValue("BookID", txtBookID.Text);
                        cmd.Parameters.AddWithValue("Title", txtTitle.Text);
                        cmd.Parameters.AddWithValue("AuthorID", txtAuthorID.Text);
                        cmd.Parameters.AddWithValue("catID", txtCat.Text);


                        //execute command instruction
                        con.Open();
                        int recordsChanged = cmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + "records added");
                        txtTitle.Clear();
                        txtBookID.Clear();
                        txtAuthorID.Clear();
                        con.Close();
                    }
                }
                //update names
                getnames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        //build command instruction
                        cmd.CommandText = @"Update book Set title = @Title2"
                                                            + " Where bookid = @id";


                        cmd.Parameters.AddWithValue("id", cbBookID.SelectedValue);
                        cmd.Parameters.AddWithValue("Title2", txtTitle2.Text);
                        

                        //execute command instruction
                        con.Open();
                        int recordsChanged = cmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + "records added");

                        txtTitle2.Clear();
                        con.Close();
                    }
                }
                //update names
                getnames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //check action before proceeding
            if (MessageBox.Show("Delete record: are you sure?", "Delete",
             MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) != DialogResult.OK)
            {
                //tssLabel.Text = "Last action: delete record ~ cancelled";
                //tssLabel.ForeColor = Color.OrangeRed;
                return;
            }

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        //execute command instruction
                        cmd.CommandText = @"Delete From book Where bookid = @id";
                        cmd.Parameters.AddWithValue("id", cbBookID2.SelectedValue);
                        //update db
                        con.Open();
                        int recordsChanged = cmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + "records added");
                        con.Close();
                    }
                }
                //update customer names list
                getnames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAuthorID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbBookID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBookID2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void txtCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBook_Click(object sender, EventArgs e)
        {

        }
    }
}
