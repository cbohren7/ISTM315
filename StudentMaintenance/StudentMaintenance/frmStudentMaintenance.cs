﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//AUTHOR:       Madeline Moen, Karuna Kankani, Christian Bohren
//COURSE:	    ISTM 315.501
//FORM:		    frmStudentMaintenance.cs ; frmAddModifyStudent.cs
//PURPOSE:	    This program is designed to maintain student records 
//              through mofifying and retrieving students from the database.
//INITIALIZE:   MySql Student Database
//			
//INPUT:	    Student ID from txtSID
//PROCESS:		GetStudent, ClearControls, DisplayStudent
//OUTPUT:		The Student's first name, last name, stuffix, street, city, state,
//              zip, and buyer and/or seller status will be displayed in the text boxes
//			    once the user enters a student ID.
//TERMINATE:	Student Database connection will be terminated once the student information
//              is retrieved from the database.
//HONOR CODE:	“On my honor, as an Aggie, I have neither given 
//			    nor received unauthorized aid on this academic 
//			    work.”

namespace StudentMaintenance
{
    public partial class frmStudentMaintenance : Form
    {
        public frmStudentMaintenance()
        {
            InitializeComponent();
        }
        private Student student;

        /// <summary>
        /// When the Get Student button is clicked, if the SID is present, the student information is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method gets the student from the form and calls the GetStudent method from the StudentDB class.
        /// </summary>
        /// <param name="SID"></param>
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

        /// <summary>
        /// All the textboxes are made blank.
        /// </summary>
        /// <param name="SID"></param>
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

        /// <summary>
        /// The student information is displayed in textboxes as output.
        /// </summary>
        /// <param name="SID"></param>
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

        /// <summary>
        /// Clicking Add button sends users to a blank frmAddModifyStudent form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When user clicks modify button, the frmAddModifyStudent form is displayed with the student's current information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This button exits the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
