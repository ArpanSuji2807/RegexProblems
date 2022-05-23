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
        public bool FirstName_Validation(string name)=>(Regex.IsMatch(name, first_Name));
        public bool LastName_Validation(string last_Name)=>(Regex.IsMatch(last_Name,first_Name));
        public bool MobileNumber_Validation(string number)=>(Regex.IsMatch(number, mobileNumber));
        public bool Email_Validation(string email)=>(Regex.IsMatch(email, emailID));
        public bool Password_Validation(string pswd)=>(Regex.IsMatch(pswd, password));
        public bool PasswordValidation_WithOneUpperCase(string paswd)=>(Regex.IsMatch(paswd, passwordWithOneUpperCase));
        public bool PasswordValidation_WithOneNumericNumber(string paswrd)=>(Regex.IsMatch(paswrd, passwordWithOneNumericNumber));
        public bool PasswordValidation_WithOneSpecialCharacter(string paswrrd)=>(Regex.IsMatch(paswrrd, passwordWithOneSpecialCharacter));
        public bool MultipleEmailValidationParameterized(string email)=>(Regex.IsMatch(email,allEmailSmaples));
    }
}