using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        private string  _firstname;
        //private, only this class can see it.
        public string Firstname 
        //this is the property which we call.
        //this is allowing it to be used in other areas. e.g. bank account.
        {
            get { return _firstname; }
            //get, is getting the value and returning it.
            set { _firstname = value; }
            //set, this is setting what we are given as the value.
            //this is the actual property.
        }

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private DateTime _dob;
        public DateTime Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }

        //private int _age;  we can delete this as its not being used. 

        public int Age
        {
            get
            {
                //save today's date.  //var is used when you're not use what to use.
                var today = DateTime.Today;
                //Calculate the age.
                var age = today.Year - this.Dob.Year;
                //taking todays year and taking away the Dob year, this. makes sure you are talking about the right classes properties.
                if (this.Dob > today.AddYears(-age))
                {
                    age--;
                    //age-- is taking one year off of the age.
                }
                return age;
            }
        }



    }               
}
