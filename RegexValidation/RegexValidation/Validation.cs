using System.Text.RegularExpressions;

namespace RegexValidation
{
    public class Validation
    {
        List<string> list = new List<string>();
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
            try
            {
                if(first_Name!=name)
                {
                    throw new UserCustomException(UserCustomException.CustomException.FIRSTNAME_NOT_VALID, "First name is not valid");
                }
                if (Regex.IsMatch(name, first_Name))
                {
                    Console.WriteLine("{0} is a valid first name", name);
                }
                return true;
            }
            catch(UserCustomException ex)
            {
                return ex.Message == "First name is not valid";
            }
        }
        public bool LastName_Validation(string last_Name)
        {
            try
            {
                if(first_Name!= last_Name)
                {
                    throw new UserCustomException(UserCustomException.CustomException.LASTNAME_NOT_VALID, "Last name is not valid");
                }
                if (Regex.IsMatch(last_Name, first_Name))
                {
                    Console.WriteLine("{0} is valid last name", last_Name);
                }
                return true;
            }
            catch (UserCustomException ex)
            {
                return ex.Message == "Last name is not valid";
            }
        }
        public bool MobileNumber_Validation(string number)
        {
            try
            {
                if (mobileNumber!= number)
                {
                    throw new UserCustomException(UserCustomException.CustomException.MOBILENUMBER_NOT_VALID, "Mobile number is not valid");
                }
                if (Regex.IsMatch(number, mobileNumber))
                {
                    Console.WriteLine("{0} is a valid number", number);
                }
                return true;
            }
            catch(UserCustomException ex)
            {
                return ex.Message == "Mobile number is not valid";
            }
        }
        public bool Email_Validation(string email)
        {
            try
            {
                if(emailID!= email)
                {
                    throw new UserCustomException(UserCustomException.CustomException.EMAILID_NOT_VALID, "Email is not valid");
                }
                if (Regex.IsMatch(email, emailID))
                {
                    Console.WriteLine("{0} is a valid email ID", email);
                }
                return true;
            }
            catch(UserCustomException ex)
            {
                return ex.Message == "Email is not valid";
            }
        }
        public bool Password_Validation(string pswd)
        {
            try
            {
                if(password!= pswd)
                {
                    throw new UserCustomException(UserCustomException.CustomException.PASSWORD_NOT_VALID, "Password is not valid");
                }
                if (Regex.IsMatch(pswd, password))
                {
                    Console.WriteLine("{0} is a valid password", pswd);
                }
                return true;
            }
            catch(UserCustomException ex)
            {
                return ex.Message == "Password is not valid";
            }
        }
        public bool PasswordValidation_WithOneUpperCase(string paswd)
        {
            try
            {
                if(passwordWithOneUpperCase!= paswd)
                {
                    throw new UserCustomException(UserCustomException.CustomException.PASSWORD_NOT_VALID, "Password is not valid");
                }
                if (Regex.IsMatch(paswd, passwordWithOneUpperCase))
                {
                    Console.WriteLine("{0} is a valid password", paswd);
                }
                return true;
            }
            catch (UserCustomException ex)
            {
                return ex.Message == "Password is not valid";
            }
        }
        public bool PasswordValidation_WithOneNumericNumber(string paswrd)
        {
            try
            {
                if (passwordWithOneNumericNumber != paswrd)
                {
                    throw new UserCustomException(UserCustomException.CustomException.PASSWORD_NOT_VALID, "Password is not valid");
                }
                if (Regex.IsMatch(paswrd, passwordWithOneNumericNumber))
                {
                    Console.WriteLine("{0} is a valid password", paswrd);
                }
                return true;
            }
            catch (UserCustomException ex)
            {
                return ex.Message == "Password is not valid";
            }
        }
        public bool PasswordValidation_WithOneSpecialCharacter(string paswrrd)
        {
            try
            {
                if (passwordWithOneSpecialCharacter != paswrrd)
                {
                    throw new UserCustomException(UserCustomException.CustomException.PASSWORD_NOT_VALID, "Password is not valid");
                }
                if (Regex.IsMatch(paswrrd, passwordWithOneSpecialCharacter))
                {
                    Console.WriteLine("{0} is a valid password", paswrrd);
                }
                return true;
            }
            catch (UserCustomException ex)
            {
                return ex.Message == "Password is not valid";
            }
        }
        public bool AllEmailSamplesValidation()
        {
            list.Add("abc.100@abc.com.au");
            list.Add("abc+100@gmail.com");
            list.Add("abc@yahoo.com");
            list.Add("abc-100@yahoo.com");
            list.Add("abc111@abc.com");
            list.Add("abc.100@abc.com.au");
            list.Add("abc-100@abc.net");
            list.Add("abc@1.com");
            try
            {
                foreach (var data in list)
                {
                    if (data != allEmailSmaples)
                    {
                        throw new UserCustomException(UserCustomException.CustomException.EMAILID_NOT_VALID, "Email is not valid");
                    }
                    if (Regex.IsMatch(data, allEmailSmaples))
                    {
                        Console.WriteLine("{0} is a valid password", data);
                    }
                    return true;
                }
            }
            catch(UserCustomException ex)
            {
                return ex.Message == "Email is not valid";
            }
            return true;
        }
        public bool MultipleEmailValidationParameterized(string email)
        {
            try
            {
                if(allEmailSmaples!=email)
                {
                    throw new UserCustomException(UserCustomException.CustomException.EMAILID_NOT_VALID, "Email is not valid");
                }
                if (Regex.IsMatch(email, allEmailSmaples))
                {
                    Console.WriteLine("Email is matched");
                }
                return true;
            }
            catch (UserCustomException ex)
            {
                return ex.Message == "Email is not valid";
            }
        }
    }
}