using System.Text.RegularExpressions;

namespace RegexValidation
{
    public class Validation
    {
        const string first_Name = "^[A-Z]{1}[a-z]$";
        const string mobileNumber = "^[6-9]{1}[0-9]{9}$";
        const string emailID = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        const string password = "^[a-zA-z0-9]{8,}";
        public bool FirstName_Validation(string name)
        {
            if (Regex.IsMatch(name,first_Name))
            {
                Console.WriteLine("{0} is a valid first name", name);
            }
            return true;
        }
        public bool LastName_Validation(string last_Name)
        {
            if (Regex.IsMatch(last_Name,first_Name))
            {
                Console.WriteLine("{0} is valid last name", last_Name);
            }
            return true;
        }
        public bool MobileNumber_Validation(string number)
        {
            if (Regex.IsMatch(number,mobileNumber))
            {
                Console.WriteLine("{0} is a valid number", number);
            }
            return true;
        }
        public bool Email_Validation(string email)
        {
            if (Regex.IsMatch(email,emailID))
            {
                Console.WriteLine("{0} is a valid email ID", email);
            }
            return true;
        }
        public bool Password_Validation(string pswd)
        {
            if (Regex.IsMatch(pswd, password))
            {
                Console.WriteLine("{0} is a valid password", pswd);
            }
            return true;
        }
    }
}