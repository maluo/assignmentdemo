using System;
using System.Text;
using System.Text.RegularExpressions;

namespace DBLibrary.Utilities
{
    public static class GlobalFun
    {
        private static readonly log4net.ILog log =
    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static string Hashpass(string pass) {
            string hash = null;
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(pass);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                hash = Encoding.ASCII.GetString(data);
            }
            catch (Exception e) {
                log.Error(e.Message);
            }
            return hash;
        }

        public static bool validatePcode(string pcode) {
            try
            {
                var pattern = @"^[A-Za-z]\d[A-Za-z][-]?\d[A-Za-z]\d$";
                MatchCollection matches = null;
                Regex rx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                if (rx.Matches(pcode).Count == 0) return false;
            }
            catch (Exception e) {
                log.Error(e.Message);
            }
            return true;
        }

        public static bool validatePass(string pass) {
            //https://www.regextester.com/
            /*
             * Testing regular expression with this online tool
             */
            try
            {
                string digit = @"\w?\d+\w?";
                string Uppercase = @"\w?[A-Z]+\w?";
                string specialChar = @"\w?[&;^%$#@]\w?";
                MatchCollection matches = null;

                if (pass.Length < 10) return false;

                Regex rx = new Regex(digit, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                if (rx.Matches(pass).Count == 0) return false;

                rx = new Regex(Uppercase, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                if (rx.Matches(pass).Count == 0) return false;

                rx = new Regex(specialChar, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                if (rx.Matches(pass).Count == 0) return false;

                return true;
            }
            catch (Exception e) {
                log.Error(e.Message);
            }
            return false;
        }

        public static bool validaEmail(string email) {
            /*
             * Refering to the patter provided by this link https://www.regular-expressions.info/email.html
             */
            try
            {
                string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
                Regex rx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                return (rx.Matches(email).Count > 0);
            }
            catch (Exception e) {
                log.Error(e.Message);
            }
            return false;
        }

        public static DateTime getCurrentDatetime() {
            return DateTime.Now;
        }

        public static string getCurrentimestamp() {
            return getCurrentDatetime().ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}
