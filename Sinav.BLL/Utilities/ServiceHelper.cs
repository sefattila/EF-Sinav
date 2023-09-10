using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.BLL.Utilities
{
    public class ServiceHelper
    {
        public bool PasswordControl(string password)
        {
            bool isAnyNumber = password.Any(char.IsDigit);
            bool isAllCharOrDigit = !password.All(char.IsLetterOrDigit);
            bool isAnyLetter = password.Any(char.IsLetter);
            if (isAnyLetter && isAllCharOrDigit && isAnyNumber && password.Length > 6)
            {
                return true;
            }
            return false;
        }
    }
}
