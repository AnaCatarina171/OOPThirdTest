using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOPTest3
{
    public static class Validate
    {
        #region CONSTANTS

        private const string EMAIL_PATTERN = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
        private const string POSTAL_CODE_PATTERN = @"^[a-zA-Z][0-9][a-zA-Z][0-9][a-zA-Z][0-9]$";

        #endregion

        #region METHODS

        public static bool IsValidEmail(string value)
        {
            Match matches = Regex.Match(value, EMAIL_PATTERN);
            return matches.Success;
        }

        public static bool IsValidPostalCode(string value)
        {
            Match matches = Regex.Match(value, POSTAL_CODE_PATTERN);
            return matches.Success;
        }

        public static bool ValidGreaterThanLength(string value, int length)
        {
            if (ValidNotEmpty(value) && value.Trim().Length > length)
                return true;
            return false;
        }

        public static bool ValidLessThanLength(string value, int length)
        {
            if (ValidNotEmpty(value) && value.Trim().Length < length)
                return true;
            return false;
        }

        public static bool ValidNotEmpty(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;
            return true;
        }

        #endregion
    }
}
