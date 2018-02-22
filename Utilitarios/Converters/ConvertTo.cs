using System;
using Utilitarios.Mail;

namespace Utilitarios.Converters
{
    public class ConvertTo
    {
        public static Double _ToDouble(object o)
        {
            return _isNotNullOrDBNull(o) ? Convert.ToDouble(o) : -1;
        }

        public static bool _StringIsNumber(string value)
        {
            bool isNumber;
            try
            {
                int.Parse(value);
                isNumber = true;
            }
            catch (Exception ex)
            {
                MailSender.SendErrorMail(ex);
                isNumber = false;
            }
            return isNumber;
        }

        public static int _ToInt(object o)
        {
            return _isNotNullOrDBNull(o) ? Convert.ToInt32(o) : -1;
        }

        public static DateTime _ToDateTime(object o)
        {
            return _isNotNullOrDBNull(o) ? Convert.ToDateTime(o) : DateTime.Now;
        }

        public static string _ToString(object o)
        {
            return _isNotNullOrDBNull(o) ? Convert.ToString(o) : null;
        }

        public static char _ToChar(object o)
        {
            return _isNotNullOrDBNull(o) ? Convert.ToChar(o) : '-';
        }

        public static bool _isNotNullOrDBNull(object o)
        {
            return o != null && o != DBNull.Value;
        }
    }
}
