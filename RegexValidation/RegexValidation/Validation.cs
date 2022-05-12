using System.Text.RegularExpressions;

namespace RegexValidation
{
    public class Validation
    {
        const string first_Name = "^[A-Z]{1}[a-z]$";
        const string mobileNumber = "^[6-9]{1}[0-9]{9}$";
        const string emailID = "^[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        const string password = "^[a-zA-z0-9]{8,}";
        const string passwordWithOneUpperCase = "^[A-Z]{1, }[a-z]{8, }$";
        const string passwordWithOneNumericNumber = "^[A-Z]{1, }[a-z]{8, }[0-9]{1, }$";
        const string passwordWithOneSpecialCharacter = "^[A-Z]{1, }[a-z]{8, }[0-9]{1, }[@$#!*&^%]{1}$";
        const string allEmailSmaples = "^[a-z]+[.+-]{0,1}[0-9]{1, }+[@][a-z0-1][.][a-z]+([.][a-z]{2, }){0,1}$";
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
        public bool PasswordValidation_WithOneUpperCase(string paswd)
        {
            if (Regex.IsMatch(paswd,passwordWithOneUpperCase))
            {
                Console.WriteLine("{0} is a valid password",paswd);
            }
            return true;
        }
        public bool PasswordValidation_WithOneNumericNumber(string paswrd)
        {
            if (Regex.IsMatch(paswrd,passwordWithOneNumericNumber))
            {
                Console.WriteLine("{0} is a valid password", paswrd);
            }
            return true;
        }
        public bool PasswordValidation_WithOneSpecialCharacter(string paswrrd)
        {
            if (Regex.IsMatch(paswrrd, passwordWithOneSpecialCharacter))
            {
                Console.WriteLine("{0} is a valid password", paswrrd);
            }
            return true;
        }
        public bool AllEmailSamplesValidation(string email)
        {
            if (Regex.IsMatch(email, allEmailSmaples))
            {
                Console.WriteLine("{0} is a valid password", email);
            }
            return true;
        }
    }
}