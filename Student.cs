using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_9___Making_a_class__Console_
{
    class Student
    {
        private static Random generator = new Random();
        private string _firstname;
        private string _lastname;
        private int _studentnumber;
        private string _email;

        public Student(string firstName, string lastName)
        {
            //instance variable, fields initialized here
            _firstname = firstName;
            _lastname = lastName;

            _studentnumber = generator.Next(100, 1000);
            generateEmail();
        }

        public string firstName
        {
            get
            {

                return _firstname;

            }
            set
            {

                _firstname = value;
                generateEmail();
            }
        }
        public string lastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                generateEmail();
            }



        }
        public int StudentNumber
        {
            get
            {
                return _studentnumber;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }


        }


        public override string ToString()
        {
            return _firstname + " " + _lastname;
        }
        private void generateEmail()
        {
            //first 3 letters of first name, first 3 letters of the last name, and the student #, @ICS4U.ca
            _email = _firstname.Substring(0, 3) + _lastname.Substring(0, 3) + _studentnumber + "@ICS4U.ca";
            



        }

    }
}
