using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Business.Logic
{
    public class Validation
    {
        public static bool IsEmailValid(string email)
        {
            string expresion = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            if (Regex.IsMatch(email, expresion) && Regex.Replace(email, expresion, string.Empty).Length == 0)
                return true;
            else return false;
        }
    }
}
