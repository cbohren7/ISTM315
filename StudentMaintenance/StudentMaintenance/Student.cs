using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMaintenance
{
    public class Student
    {
        private int studentID;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zip; 

        public Student() { }

        public Student(int studentID, string firstName, string lastName, string address,
            string state, string zip)
        {
            this.StudentID = studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }

        public int StudentID { //what variable type should this be?
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }

        public string FirstName {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Address {
            get
            {
                return address;
            }
            set
            {
                address = value;
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
