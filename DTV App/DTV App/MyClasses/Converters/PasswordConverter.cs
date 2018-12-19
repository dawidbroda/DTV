using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTV_App
{
    public class PasswordConverter
    {
        public static string ToBase(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            string code = Convert.ToBase64String(bytes);
            return code;
        }

        public static string ToString(string code)
        {
            string password = "" + Convert.FromBase64String(code);
            return password;
        }
    }
}
