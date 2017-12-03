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
            this.txtState = new System.Windows.Forms.TextBox();
            this.chkBuyer = new System.Windows.Forms.CheckBox();
            this.chkSeller = new System.Windows.Forms.CheckBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "State:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zip Code:";
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(112, 25);
            this.txtSID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(76, 20);
            this.txtSID.TabIndex = 0;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(112, 59);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFname.Name = "txtFname";
            this.txtFname.ReadOnly = true;
            this.txtFname.Size = new System.Drawing.Size(385, 20);
            this.txtFname.TabIndex = 2;
            this.txtFname.TabStop = false;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(112, 90);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLname.Name = "txtLname";
            this.txtLname.ReadOnly = true;
            this.txtLname.Size = new System.Drawing.Size(385, 20);
            this.txtLname.TabIndex = 3;
            this.txtLname.TabStop = false;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(112, 153);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(385, 20);
            this.txtStreet.TabIndex = 5;
            this.txtStreet.TabStop = false;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(112, 184);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(385, 20);
            this.txtCity.TabIndex = 6;
            this.txtCity.TabStop = false;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(111, 242);
            this.txtZip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(79, 20);
            this.txtZip.TabIndex = 8;
            this.txtZip.TabStop = false;
            // 
            // btnGetStudent
            // 
            this.btnGetStudent.Location = new System.Drawing.Point(242, 17);
            this.btnGetStudent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGetStudent.Name = "btnGetStudent";
            this.btnGetStudent.Size = new System.Drawing.Size(93, 31);
            this.btnGetStudent.TabIndex = 1;
            this.btnGetStudent.Text = "Get Student";
            this.btnGetStudent.UseVisualStyleBackColor = true;
            this.btnGetStudent.Click += new System.EventHandler(this.btnGetStudent_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(111, 285);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(242, 285);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(93, 31);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(404, 285);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(110, 215);
            this.txtState.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(80, 20);
            this.txtState.TabIndex = 7;
            this.txtState.TabStop = false;
            // 
            // chkBuyer
            // 
            this.chkBuyer.AutoSize = true;
            this.chkBuyer.Location = new System.Drawing.Point(242, 216);
            this.chkBuyer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBuyer.Name = "chkBuyer";
            this.chkBuyer.Size = new System.Drawing.Size(53, 17);
            this.chkBuyer.TabIndex = 13;
            this.chkBuyer.TabStop = false;
            this.chkBuyer.Text = "Buyer";
            this.chkBuyer.UseVisualStyleBackColor = true;
            // 
            // chkSeller
            // 
            this.chkSeller.AutoSize = true;
            this.chkSeller.Location = new System.Drawing.Point(242, 242);
            this.chkSeller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSeller.Name = "chkSeller";
            this.chkSeller.Size = new System.Drawing.Size(52, 17);
            this.chkSeller.TabIndex = 14;
            this.chkSeller.TabStop = false;
            this.chkSeller.Text = "Seller";
            this.chkSeller.UseVisualStyleBackColor = true;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(112, 122);
            this.txtSuffix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.ReadOnly = true;
            this.txtSuffix.Size = new System.Drawing.Size(70, 20);
            this.txtSuffix.TabIndex = 4;
            this.txtSuffix.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Suffix:";
            // 
            // frmStudentMaintenance
            // 
            this.AcceptButton = this.btnGetStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(538, 359);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkSeller);
            this.Controls.Add(this.chkBuyer);
            this.Controls.Add(this.txtState);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.CheckBox chkBuyer;
        private System.Windows.Forms.CheckBox chkSeller;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label label8;
    }
}

