using System.Text.RegularExpressions;

namespace RegexValidation
{
    public class Validation
    {
        const string first_Name = "^[A-Z]{1}[a-z]$";
        public bool FirstName_Validation(string name)
        {
            if (Regex.IsMatch(name,first_Name))
            {
                Console.WriteLine("{0} is a valid user name", name);
            }
            return true;
        }
    }
}