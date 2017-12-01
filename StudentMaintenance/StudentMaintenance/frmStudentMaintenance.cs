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
    public partial class frmStudentMaintenance : Form
    {
        public frmStudentMaintenance()
        {
            InitializeComponent();
        }

        private void btnGetStudent_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSID))
            {
                string strSID = Convert.ToString(txtSID.Text);
                this.GetStudent(strSID);
                if (strSID == null)
                {
                    MessageBox.Show("No customer found with this ID. " +
                         "Please try again.", "Customer Not Found");
                    this.ClearControls();
                }
                else
                    this.DisplayCustomer();
            }


        }

        private void GetStudent(string SID)
        {
            try
            {
                SID = StudentDB.GetStudent(SID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
