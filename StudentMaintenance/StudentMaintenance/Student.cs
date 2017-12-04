using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMaintenance
{
    public class Student
    {
        private string strSID;
        private string strFname;
        private string strLname;
        private string strSuffix;
        private string strStreet;
        private string strCity;
        private string strState;
        private string strZip;
        private bool blnBuyer;
        private bool blnSeller;

        public Student() { }

        /// <summary>
        /// This is qualifying the fields for the student.
        /// </summary>
        /// <param name="SID"></param>
        /// <param name="Fname"></param>
        /// <param name="Lname"></param>
        /// <param name="Suffix"></param>
        /// <param name="Street"></param>
        /// <param name="City"></param>
        /// <param name="State"></param>
        /// <param name="Zip"></param>
        /// <param name="Buyer"></param>
        /// <param name="Seller"></param>
        public Student(string SID, string Fname, string Lname, string Suffix, string Street, string City,
            string State, string Zip, bool Buyer, bool Seller)
        {
            this.SID = strSID;
            this.Fname = strFname;
            this.Lname = strLname;
            this.Suffix = strSuffix;
            this.Street = strStreet;
            this.City = strCity;
            this.State = strState;
            this.Zip = strZip;
            this.Buyer = blnBuyer;
            this.Seller = blnSeller;
        }
        /// <summary>
        /// Uses get set accessors for the student ID.
        /// </summary>
        public string SID
        { 
            get
            {
                return strSID;
            }
            set
            {
                strSID = value;
            }
        }
        /// <summary>
        /// Get Set accessors for the student's first name.
        /// </summary>
        public string Fname
        {
            get
            {
                return strFname;
            }
            set
            {
                strFname = value;
            }
        }
        /// <summary>
        /// Get Set accessors for the student's last name.
        /// </summary>
        public string Lname
        {
            get
            {
                return strLname;
            }
            set
            {
                strLname = value;
            }
        }
        /// <summary>
        /// Get Set accessors for the student's suffix.
        /// </summary>
        public string Suffix
        {
            get
            {
                return strSuffix;
            }
            set
            {
                strSuffix = value;
            }
        }
        /// <summary>
        /// Get Set accessors for the student's street address.
        /// </summary>
        public string Street
        {
            get
            {
                return strStreet;
            }
            set
            {
                strStreet = value;
            }
        }
        /// <summary>
        /// Get Set accessors for the student's city.
        /// </summary>
        public string City
        {
            get
            {
                return strCity;
            }
            set
            {
                strCity = value;
            }
        }
        /// <summary>
        /// Get Set accessors for the student's state.
        /// </summary>
        public string State
        {
            get
            {
                return strState;
            }
            set
            {
                strState = value;
            }
        }
        /// <summary>
        /// Get Set accessors for the student's zip code.
        /// </summary>
        public string Zip
        {
            get
            {
                return strZip;
            }
            set
            {
                strZip = value;
            }
        }
        /// <summary>
        /// Get Set accessors used for buyer.
        /// </summary>
        public bool Buyer
        {
            get
            {
                return blnBuyer;
            }
            set
            {
                blnBuyer = value;
            }
        }
        /// <summary>
        /// Get Set accessors for seller.
        /// </summary>
        public bool Seller
        {
            get
            {
                return blnSeller;
            }
            set
            {
                blnSeller = value;
            }
        }
    }
}
