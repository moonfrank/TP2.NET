using System.Text.RegularExpressions;

namespace Business.Logic
{
    public class Validation
    {
        public static bool IsEmailValid(string email)
        {
            string expresion = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(email, expresion) && Regex.Replace(email, expresion, string.Empty).Length == 0;
        }

        public static bool IsPassValid(string pass, string valid)
        {
            return pass.Equals(valid) && pass.Length >= 8;
        }
    }
}
