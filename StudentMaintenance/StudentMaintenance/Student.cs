using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMaintenance
{
    public class Student
    {
        private int sid;
        private string fName;
        private string lName;
        private string street;
        private string city;
        private string state;
        private string zip; 

        public Student() { }

        public Student(int sid, string fName, string lName, string street, string city,
            string state, string zip)
        {
            this.SID = sid;
            this.Fname = fName;
            this.Lname = lName;
            this.Street = street;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }

        public int SID { //what variable type should this be?
            get
            {
                return sid;
            }
            set
            {
                sid = value;
            }
        }

        public string Fname {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }

        public string Lname {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }

        public string Street {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        public string City {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string State {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public string Zip {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }
    }
}
