using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Coursework_2_library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //create a connection object
        SQLiteConnection conn = new SQLiteConnection();
        //stores the database file details
        string conString;

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            gui_setpick();
        }

        //Menu item "Select new library"(database)
        private void mnu_new_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select SQLite database file";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Database files (*.db)|*.db";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                conString = @"Data Source =" + openFileDialog1.FileName;
                openFileDialog1.FileName = Path.GetFileName(openFileDialog1.FileName);
                //update interface
                gui_settest();
            }
        }

        private void tbar_select_Click(object sender, EventArgs e)
        {
            mnu_new_Click(sender, e);
        }

        //Menu item to set to local library database
        private void mnu_local_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\scuba\OneDrive - University of South Wales\My Modules\Computer Programming\TERM 2\Coursework 2-library\pontybrynlibrary.db";
            conString = @"Data source = " + filepath;
            openFileDialog1.FileName = "pontybrynlibrary.db";
            //update interface
            gui_settest();
        }

        //Menu item "Test connection"
        private void mnu_test_Click(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = conString;
                conn.Open();
                //connection worked
                tssImage.Text = "## testing connection ##";
                tmr1.Start();
            }
            catch
            {   //connection failed
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
                MessageBox.Show("Unable to connect to this database\n\rPlease try again");
                mnu_drop_Click(null, null);
            }
        }
        private void tbar_test_Click(object sender, EventArgs e)
        {
            mnu_test_Click(sender, e);
        }

        //set UI after a short delay to give appearence db connection being tested
        private void tmr1_Tick(object sender, EventArgs e)
        {
            tmr1.Stop();
            tssImage.Image = Properties.Resources.grn;
            tssImage.Text = "Using: " + Path.GetFileName(openFileDialog1.FileName);
            gui_setconnected();
        }

        //Menu item "Disconnect"
        private void mnu_drop_Click(object sender, EventArgs e)
        {
            tssImage.Image = Properties.Resources.red;
            openFileDialog1.FileName = "";
            gui_setpick();
        }

        private void tbar_drop_Click(object sender, EventArgs e)
        {
            mnu_drop_Click(sender, e);
        }

        //Menu item "View"

        //Menu item "edit"

        //Menu item " about"
        private void mnu_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program written by David Thompson\n\rStudent Id:30047616");
        }

        //Menu item "Exit"
        private void mnu_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really quit ?", "Exit",
             MessageBoxButtons.OKCancel,
             MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void tbar_close_Click(object sender, EventArgs e)
        {
            mnu_close_Click(sender, e);
        }


        //set menu & toolbar items to state: unconnected
        private void gui_setpick()
        {
            // - select ON
            mnu_new.Enabled = true;
            mnu_local.Enabled = true;
            //- test/drop OFF
            mnu_test.Enabled = false;
            mnu_drop.Enabled = false;
            // - menus OFF 
            mnu_edit.Enabled = false;
            mnu_view.Enabled = false;
            //toolbar update
            gui_tbar();
        }

        //set menu & toolbar items to state: ready to test
        private void gui_settest()
        {
            // - select OFF
            mnu_new.Enabled = false;
            mnu_local.Enabled = false;
            // - test/drop ON
            mnu_test.Enabled = true;
            mnu_drop.Enabled = true;
            // - menus OFF 
            mnu_edit.Enabled = false;
            mnu_view.Enabled = false;
            //toolbar update
            gui_tbar();
        }

        //set menu & toolbar items to state: connected
        private void gui_setconnected()
        {
            // - test OFF
            mnu_test.Enabled = false;
            // - drop OFF
            mnu_drop.Enabled = true;
            //menus ON
            mnu_edit.Enabled = true;
            mnu_view.Enabled = true;
            //toolbar update
            gui_tbar();
        }

        //synchronise toolbar and menu items
        private void gui_tbar()
        {
            tbar_select.Enabled = mnu_new.Enabled;
            tbar_test.Enabled = mnu_test.Enabled;
            tbar_drop.Enabled = mnu_drop.Enabled;
            tssImage.Text = "Selected: " + openFileDialog1.FileName;
        }


        private void lblLib_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnu_connect_Click(object sender, EventArgs e)
        {

        }

        private void tssImage_Click(object sender, EventArgs e)
        {

        }

        private void mnu_editMembers_Click(object sender, EventArgs e)
        {
            Form2 frmMember= new Form2(conString);
            frmMember.ShowDialog();
        }

        private void mnu_editBooks_Click(object sender, EventArgs e)
        {
            Form3 frmbook = new Form3(conString);
            frmbook.ShowDialog();
        }

        private void mnu_viewLoans_Click(object sender, EventArgs e)
        {
            Form4 frmloan = new Form4(conString);
            frmloan.ShowDialog();
        }

        private void mnu_return_Click(object sender, EventArgs e)
        {
            Form5 frmDue = new Form5(conString);
            frmDue.ShowDialog();
        }

        private void mnu_viewBooks_Click(object sender, EventArgs e)
        {
            Form6 frmViewBooks = new Form6(conString);
            frmViewBooks.ShowDialog();
        }

        private void scienceFictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frmscience = new Form7(conString);
            frmscience.ShowDialog();
        }

   

        private void historicalFictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frmhistorical = new Form8(conString);
            frmhistorical.ShowDialog();
        }

        private void biographyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 frmbio = new Form9(conString);
            frmbio.ShowDialog();
        }

        private void mnu_viewMembers_Click(object sender, EventArgs e)
        {
            Form10 frmViewMembers = new Form10(conString);
            frmViewMembers.ShowDialog();
        }

        private void mnu_viewAuthors_Click(object sender, EventArgs e)
        {
            Form11 frmViewAuthors = new Form11(conString);
            frmViewAuthors.ShowDialog();
        }

        private void mnu_editLoan_Click(object sender, EventArgs e)
        {
            Form12 frmEditLoan = new Form12(conString);
            frmEditLoan.ShowDialog();
        }
    }
}
