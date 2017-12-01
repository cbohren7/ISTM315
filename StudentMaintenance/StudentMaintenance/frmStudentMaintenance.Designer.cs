namespace StudentMaintenance
{
    partial class frmStudentMaintenance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnGetStudent = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkBuyer = new System.Windows.Forms.CheckBox();
            this.chkSeller = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 394);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "State:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 445);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zip Code:";
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(224, 36);
            this.txtSID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(148, 31);
            this.txtSID.TabIndex = 0;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(224, 114);
            this.txtFname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFname.Name = "txtFname";
            this.txtFname.ReadOnly = true;
            this.txtFname.Size = new System.Drawing.Size(766, 31);
            this.txtFname.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(224, 184);
            this.txtLname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLname.Name = "txtLname";
            this.txtLname.ReadOnly = true;
            this.txtLname.Size = new System.Drawing.Size(766, 31);
            this.txtLname.TabIndex = 3;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(224, 256);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(766, 31);
            this.txtStreet.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(224, 328);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(766, 31);
            this.txtCity.TabIndex = 5;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(227, 440);
            this.txtZip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(154, 31);
            this.txtZip.TabIndex = 7;
            // 
            // btnGetStudent
            // 
            this.btnGetStudent.Location = new System.Drawing.Point(416, 33);
            this.btnGetStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetStudent.Name = "btnGetStudent";
            this.btnGetStudent.Size = new System.Drawing.Size(195, 36);
            this.btnGetStudent.TabIndex = 1;
            this.btnGetStudent.Text = "Get Student";
            this.btnGetStudent.UseVisualStyleBackColor = true;
            this.btnGetStudent.Click += new System.EventHandler(this.btnGetStudent_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 503);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 49);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(224, 503);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(157, 49);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(841, 503);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 49);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 389);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(157, 31);
            this.textBox1.TabIndex = 11;
            // 
            // chkBuyer
            // 
            this.chkBuyer.AutoSize = true;
            this.chkBuyer.Location = new System.Drawing.Point(488, 390);
            this.chkBuyer.Name = "chkBuyer";
            this.chkBuyer.Size = new System.Drawing.Size(100, 29);
            this.chkBuyer.TabIndex = 13;
            this.chkBuyer.Text = "Buyer";
            this.chkBuyer.UseVisualStyleBackColor = true;
            // 
            // chkSeller
            // 
            this.chkSeller.AutoSize = true;
            this.chkSeller.Enabled = false;
            this.chkSeller.Location = new System.Drawing.Point(488, 441);
            this.chkSeller.Name = "chkSeller";
            this.chkSeller.Size = new System.Drawing.Size(99, 29);
            this.chkSeller.TabIndex = 14;
            this.chkSeller.Text = "Seller";
            this.chkSeller.UseVisualStyleBackColor = true;
            // 
            // frmStudentMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 595);
            this.Controls.Add(this.chkSeller);
            this.Controls.Add(this.chkBuyer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGetStudent);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStudentMaintenance";
            this.Text = "Student Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnGetStudent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkBuyer;
        private System.Windows.Forms.CheckBox chkSeller;
    }
}

