
namespace Coursework_2_library
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.txtTitle2 = new System.Windows.Forms.TextBox();
            this.cbBookID2 = new System.Windows.Forms.ComboBox();
            this.lblMember2 = new System.Windows.Forms.Label();
            this.lblMember1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.cbBookID = new System.Windows.Forms.ComboBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(159, 137);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(417, 31);
            this.txtBookID.TabIndex = 37;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Book ID";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(48, 210);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(90, 25);
            this.lblStreet1.TabIndex = 35;
            this.lblStreet1.Text = "Author ID";
            this.lblStreet1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(159, 204);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(417, 31);
            this.txtAuthorID.TabIndex = 34;
            this.txtAuthorID.TextChanged += new System.EventHandler(this.txtAuthorID_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(159, 75);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(417, 31);
            this.txtTitle.TabIndex = 33;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 25);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Book Title";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(21, 15);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 40);
            this.btnNew.TabIndex = 31;
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Location = new System.Drawing.Point(67, 522);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(90, 25);
            this.lblTitle2.TabIndex = 47;
            this.lblTitle2.Text = "Book Title";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTitle2
            // 
            this.txtTitle2.Location = new System.Drawing.Point(191, 519);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(417, 31);
            this.txtTitle2.TabIndex = 46;
            // 
            // cbBookID2
            // 
            this.cbBookID2.FormattingEnabled = true;
            this.cbBookID2.Location = new System.Drawing.Point(191, 647);
            this.cbBookID2.Name = "cbBookID2";
            this.cbBookID2.Size = new System.Drawing.Size(234, 33);
            this.cbBookID2.TabIndex = 45;
            this.cbBookID2.SelectedIndexChanged += new System.EventHandler(this.cbBookID2_SelectedIndexChanged);
            // 
            // lblMember2
            // 
            this.lblMember2.AutoSize = true;
            this.lblMember2.Location = new System.Drawing.Point(53, 650);
            this.lblMember2.Name = "lblMember2";
            this.lblMember2.Size = new System.Drawing.Size(77, 25);
            this.lblMember2.TabIndex = 43;
            this.lblMember2.Text = "book ID";
            // 
            // lblMember1
            // 
            this.lblMember1.AutoSize = true;
            this.lblMember1.Location = new System.Drawing.Point(67, 454);
            this.lblMember1.Name = "lblMember1";
            this.lblMember1.Size = new System.Drawing.Size(76, 25);
            this.lblMember1.TabIndex = 42;
            this.lblMember1.Text = "Book ID";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(570, 635);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 52);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(53, 597);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(111, 40);
            this.btnDel.TabIndex = 40;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMod.Location = new System.Drawing.Point(53, 389);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(111, 40);
            this.btnMod.TabIndex = 39;
            this.btnMod.Text = "Modify";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // cbBookID
            // 
            this.cbBookID.FormattingEnabled = true;
            this.cbBookID.Location = new System.Drawing.Point(191, 446);
            this.cbBookID.Name = "cbBookID";
            this.cbBookID.Size = new System.Drawing.Size(234, 33);
            this.cbBookID.TabIndex = 48;
            this.cbBookID.SelectedIndexChanged += new System.EventHandler(this.cbBookID_SelectedIndexChanged);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBook.Location = new System.Drawing.Point(219, 5);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(123, 48);
            this.lblBook.TabIndex = 49;
            this.lblBook.Text = "Books";
            this.lblBook.Click += new System.EventHandler(this.lblBook_Click);
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Location = new System.Drawing.Point(35, 280);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(107, 25);
            this.lblcat.TabIndex = 51;
            this.lblcat.Text = "Category ID";
            this.lblcat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(159, 280);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(417, 31);
            this.txtCat.TabIndex = 52;
            this.txtCat.TextChanged += new System.EventHandler(this.txtCat_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 729);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.cbBookID);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.txtTitle2);
            this.Controls.Add(this.cbBookID2);
            this.Controls.Add(this.lblMember2);
            this.Controls.Add(this.lblMember1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStreet1);
            this.Controls.Add(this.txtAuthorID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnNew);
            this.Name = "Form3";
            this.Text = "EditBooks";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TextBox txtTitle2;
        private System.Windows.Forms.ComboBox cbBookID2;
        private System.Windows.Forms.Label lblMember2;
        private System.Windows.Forms.Label lblMember1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.ComboBox cbBookID;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.TextBox txtCat;
    }
}