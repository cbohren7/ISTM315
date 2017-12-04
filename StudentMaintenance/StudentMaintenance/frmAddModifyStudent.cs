using System;
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
    public partial class frmAddModifyStudent : Form
    {
        public frmAddModifyStudent()
        {
            InitializeComponent();
        }

        public bool addStudent;
        public Student student;

      
        /// <summary>
        /// This loads the Add Modify Student form and displays the students information if modifying student.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
private void frmAddModifyStudent_Load(object sender, EventArgs e)
        {
            
            if (addStudent)
            {
                this.Text = "Add Customer";
                
            }
            else
            {
                this.Text = "Modify Customer";
                this.DisplayStudent();
            }

        }

  
        /// <summary>
        /// This displays the students information on form.
        /// </summary>
        private void DisplayStudent()
        {
            txtSID.Text = student.SID;
            txtFname.Text = student.Fname;
            txtLname.Text = student.Lname;
            txtSuffix.Text = student.Suffix;
            txtStreet.Text = student.Street;
            txtCity.Text = student.City;
            cboState.Text = student.State;
            txtZip.Text = student.Zip;
            chkBuyer.Checked = student.Buyer;
            chkSeller.Checked = student.Seller;
            
        }
        /// <summary>
        /// This method updates and adds the information on the student.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addStudent)
                {
                    student = new Student();
                    this.PutStudentData(student);
                    try
                    {
                        StudentDB.AddStudent(student);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    Student newStudent = new Student();
                    newStudent.SID = student.SID;
                    this.PutStudentData(newStudent);
                    try
                    {
                        if (!StudentDB.UpdateStudent(student, newStudent))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that customer.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            student = newStudent;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }
        /// <summary>
        /// This method checks that all entered data is valid.
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtSID) &&
                Validator.IsPresent(txtFname) &&
                Validator.IsPresent(txtLname) &&
                Validator.IsPresent(txtStreet) &&
                Validator.IsPresent(txtCity) &&
                Validator.IsPresent(cboState) &&
                Validator.IsPresent(txtZip) &&
                Validator.IsInt32(txtZip) &&
                Validator.IsChecked(chkBuyer, chkSeller);
        }
        /// <summary>
        /// This takes the values fro mthe textboxes and assigns them to the corresponding Student class variables.
        /// </summary>
        /// <param name="student"></param>
        private void PutStudentData(Student student)
        {
            student.SID = txtSID.Text;
            student.Fname = txtFname.Text;
            student.Lname = txtLname.Text;
            student.Suffix = txtSuffix.Text;
            student.Street = txtStreet.Text;
            student.City = txtCity.Text;
            student.State = cboState.SelectedItem.ToString();
            student.Zip = txtZip.Text;
            student.Buyer = chkBuyer.Checked;
            student.Seller = chkSeller.Checked;
        }
        /// <summary>
        /// This closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

