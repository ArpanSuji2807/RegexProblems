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
    }
}