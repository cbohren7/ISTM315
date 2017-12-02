﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMaintenance
{
    public partial class frmStudentMaintenance : Form
    {
        public frmStudentMaintenance()
        {
            InitializeComponent();
        }
        private Student student;
        private void btnGetStudent_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSID))
            {
                string strSID = Convert.ToString(txtSID.Text);
                this.GetStudent(strSID);
                if (student == null)
                {
                    MessageBox.Show("No customer found with this ID. " +
                         "Please try again.", "Customer Not Found");
                    this.ClearControls();
                }
                else
                    this.DisplayStudent();
            }


        }

        private void GetStudent(string SID)
        {
            try
            {
                student = StudentDB.GetStudent(SID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ClearControls()
        {
            txtSID.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtSuffix.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            chkBuyer.Checked = false;
            chkSeller.Checked = false;
            btnModify.Enabled = false;
            txtSID.Focus();
        }

        private void DisplayStudent()
        {
            txtSID.Text = student.SID;
            txtFname.Text = student.Fname;
            txtLname.Text = student.Lname;
            txtSuffix.Text = student.Suffix;
            txtStreet.Text = student.Street;
            txtCity.Text = student.City;
            txtState.Text = student.State;
            txtZip.Text = student.Zip;
            chkBuyer.Checked = student.Buyer;
            chkSeller.Checked = student.Seller;
            btnModify.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyStudent addStudentForm = new frmAddModifyStudent();
            addStudentForm.addStudent = true;
            DialogResult result = addStudentForm.ShowDialog(); //this now pulls up the add/modify form
            if (result == DialogResult.OK)
            {
                student = addStudentForm.student;
                txtSID.Text = student.SID.ToString();
                this.DisplayStudent();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyStudent modifyStudentForm = new frmAddModifyStudent();
            modifyStudentForm.addStudent = false;
            modifyStudentForm.student = student;
            DialogResult result = modifyStudentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                student = modifyStudentForm.student;
                this.DisplayStudent();
            }
            else if (result == DialogResult.Retry)
            {
                this.GetStudent(student.SID);
                if (student != null)
                    this.DisplayStudent();
                else
                    this.ClearControls();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
