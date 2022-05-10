using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomationProgram
{
    internal class Person
    {
        private string _firstName;
        private string _secondName;
        private string _lastName;

        internal string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        internal string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }
        internal string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        internal string ListAvailableCourse()
        {
            return "";
        }
        internal Boolean NameLenghtController(string name)
        {
            return (name.Length < 3) ? false : true;
        }
        internal Boolean PasswordController(string password, int choice)
        {
            if ( choice == '1' )
            {
                return (password.Equals("12345")) ? true : false;
            }else if ( choice == '2')
            {
                return (password.Equals("54321")) ? true : false;
            }
            else
            {
                return false;
            }
        }

    }
}
