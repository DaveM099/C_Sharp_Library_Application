
namespace Coursework_2_library
{
    partial class Form2
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
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMember2 = new System.Windows.Forms.Label();
            this.lblMember1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cbMem1 = new System.Windows.Forms.ComboBox();
            this.cbMem2 = new System.Windows.Forms.ComboBox();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(201, 212);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(417, 31);
            this.txtStreet1.TabIndex = 25;
            this.txtStreet1.TextChanged += new System.EventHandler(this.txtAddress1_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(417, 31);
            this.txtName.TabIndex = 23;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblMember2
            // 
            this.lblMember2.AutoSize = true;
            this.lblMember2.Location = new System.Drawing.Point(63, 640);
            this.lblMember2.Name = "lblMember2";
            this.lblMember2.Size = new System.Drawing.Size(102, 25);
            this.lblMember2.TabIndex = 22;
            this.lblMember2.Text = "Member ID";
            // 
            // lblMember1
            // 
            this.lblMember1.AutoSize = true;
            this.lblMember1.Location = new System.Drawing.Point(80, 454);
            this.lblMember1.Name = "lblMember1";
            this.lblMember1.Size = new System.Drawing.Size(102, 25);
            this.lblMember1.TabIndex = 20;
            this.lblMember1.Text = "Member ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(91, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 25);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(566, 613);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 52);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(63, 587);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(111, 40);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMod.Location = new System.Drawing.Point(63, 399);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(111, 40);
            this.btnMod.TabIndex = 15;
            this.btnMod.Text = "Modify";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(63, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 40);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cbMem1
            // 
            this.cbMem1.FormattingEnabled = true;
            this.cbMem1.Location = new System.Drawing.Point(201, 454);
            this.cbMem1.Name = "cbMem1";
            this.cbMem1.Size = new System.Drawing.Size(234, 33);
            this.cbMem1.TabIndex = 26;
            this.cbMem1.SelectedIndexChanged += new System.EventHandler(this.cbMem1_SelectedIndexChanged);
            // 
            // cbMem2
            // 
            this.cbMem2.FormattingEnabled = true;
            this.cbMem2.Location = new System.Drawing.Point(201, 637);
            this.cbMem2.Name = "cbMem2";
            this.cbMem2.Size = new System.Drawing.Size(234, 33);
            this.cbMem2.TabIndex = 27;
            this.cbMem2.SelectedIndexChanged += new System.EventHandler(this.cbMem2_SelectedIndexChanged);
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(73, 212);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(101, 25);
            this.lblStreet1.TabIndex = 28;
            this.lblStreet1.Text = "Streetname";
            this.lblStreet1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(201, 147);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(417, 31);
            this.txtSname.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Surname";
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Location = new System.Drawing.Point(91, 281);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(54, 25);
            this.lblEmail1.TabIndex = 32;
            this.lblEmail1.Text = "Email";
            this.lblEmail1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail1.Click += new System.EventHandler(this.lblEmail1_Click);
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(201, 275);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(417, 31);
            this.txtEmail1.TabIndex = 31;
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(91, 535);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(54, 25);
            this.lblEmail2.TabIndex = 38;
            this.lblEmail2.Text = "Email";
            this.lblEmail2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(201, 529);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(417, 31);
            this.txtEmail2.TabIndex = 37;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMember.Location = new System.Drawing.Point(314, 9);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(161, 45);
            this.lblMember.TabIndex = 39;
            this.lblMember.Text = "Members";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "House id";
            // 
            // txtHouse
            // 
            this.txtHouse.Location = new System.Drawing.Point(201, 344);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(129, 31);
            this.txtHouse.TabIndex = 41;
            this.txtHouse.TextChanged += new System.EventHandler(this.txtHouse_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 706);
            this.ControlBox = false;
            this.Controls.Add(this.txtHouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblEmail2);
            this.Controls.Add(this.txtEmail2);
            this.Controls.Add(this.lblEmail1);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStreet1);
            this.Controls.Add(this.cbMem2);
            this.Controls.Add(this.cbMem1);
            this.Controls.Add(this.txtStreet1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMember2);
            this.Controls.Add(this.lblMember1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "EditMembers";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMember2;
        private System.Windows.Forms.Label lblMember1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbMem1;
        private System.Windows.Forms.ComboBox cbMem2;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHouse;
    }
}