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
    public partial class Form2 : Form
    {
        public Form2(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString;

        SQLiteConnection dbCon;
        SQLiteDataAdapter daMem;
        DataTable dtMem = new DataTable();

        private void Form2_Load(object sender, EventArgs e)
        {
            getnames();
        }

        //fill dropdowns with member details
        private void getnames()
        {
            try
            {
                //delete any previous entries
                dtMem.Clear();
                //fill with current customers
                using (dbCon = new SQLiteConnection(conString))
                {
                    string sqlcommand = @"Select memberid, fname, sname, email, streetname  from member";
                    daMem = new SQLiteDataAdapter(sqlcommand, dbCon);
                    daMem.Fill(dtMem);
                    cbMem1.DataSource = dtMem;
                    cbMem1.DisplayMember = "memberid";
                    cbMem1.ValueMember = "memberid";
                    cbMem1.SelectedIndex = 0;
                    cbMem2.DataSource = dtMem;
                    cbMem2.DisplayMember = "memberid";
                    cbMem2.ValueMember = "memberid";
                    cbMem2.SelectedIndex = 0;
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
                        cmd.CommandText = @"Insert Into member"
                                                          + "(fname, sname, email, streetname, houseidentifier)"
                                                          + "Values (@name, @Sname, @Email1, @Street1, @house)";

                        cmd.Parameters.AddWithValue("name", txtName.Text);
                        cmd.Parameters.AddWithValue("Sname", txtSname.Text);
                        cmd.Parameters.AddWithValue("Street1", txtStreet1.Text);
                        cmd.Parameters.AddWithValue("Email1", txtEmail1.Text);
                        cmd.Parameters.AddWithValue("house", txtHouse.Text);

                        //execute command instruction
                        con.Open();
                        int recordsChanged = cmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + "records added");
                        txtName.Clear();
                        txtStreet1.Clear();
                        txtSname.Clear();
                        txtEmail1.Clear();
                        con.Close();
                    }
                }
                //update names
                getnames();
            }
            catch(Exception ex)
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
                        cmd.CommandText = @"Update member Set email = @Email2"
                                                            + " Where memberid = @id";

                       
                        cmd.Parameters.AddWithValue("id", cbMem1.SelectedValue);
                        cmd.Parameters.AddWithValue("Email2", txtEmail2.Text);

                        //execute command instruction
                        con.Open();
                        int recordsChanged = cmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + "records added");
                       
                        txtEmail2.Clear();
                        con.Close();
                    }
                }
                //update names
                getnames();
            }
            catch(Exception ex)
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
                        cmd.CommandText = @"Delete From member Where memberid = @id";
                        cmd.Parameters.AddWithValue("id", cbMem2.SelectedValue);
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
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtAddress1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbMem1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        private void cbMem2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail1_Click(object sender, EventArgs e)
        {

        }

        private void txtHouse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
