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

        public string SID { //what variable type should this be?
            get
            {
                return strSID;
            }
            set
            {
                strSID = value;
            }
        }

        public string Fname {
            get
            {
                return strFname;
            }
            set
            {
                strFname = value;
            }
        }

        public string Lname {
            get
            {
                return strLname;
            }
            set
            {
                strLname = value;
            }
        }

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

        public string Street {
            get
            {
                return strStreet;
            }
            set
            {
                strStreet = value;
            }
        }

        public string City {
            get
            {
                return strCity;
            }
            set
            {
                strCity = value;
            }
        }

        public string State {
            get
            {
                return strState;
            }
            set
            {
                strState = value;
            }
        }

        public string Zip {
            get
            {
                return strZip;
            }
            set
            {
                strZip = value;
            }
        }

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
