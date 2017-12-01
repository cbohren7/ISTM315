using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMaintenance
{
    public class Student
    {
        private string strSid;
        private string strFname;
        private string strLname;
        private string strStreet;
        private string strCity;
        private string strState;
        private string strZip;
        private bool blnBuyer;
        private bool blnSeller;

        public Student() { }

        public Student(string strSid, string strFname, string strLname, string strStreet, string strCity,
            string strState, string strZip, bool blnBuyer, bool blnSeller)
        {
            this.SID = strSid;
            this.Fname = strFname;
            this.Lname = strLname;
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
                return strSid;
            }
            set
            {
                strSid = value;
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
