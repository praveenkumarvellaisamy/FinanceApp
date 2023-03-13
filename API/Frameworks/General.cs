using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebAPI_Montensseri.Frameworks
{
    public class General
    {
        /// <summary>
        /// Checks whether the string value can be evaluated to a value of type (int?).
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>int? Nullable int value</returns>
        public static int? GetNullableInteger(string value)
        {
            int? i = null;
            int ii;

            if (int.TryParse(value, out ii))
                i = ii;
            return i;
        }


        public static Guid? GetNullableGuid(string value)
        {
            try
            {
                Guid result = new Guid(value);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public static string GetNullableString(string value)
        {
            if (string.IsNullOrEmpty(value) || value.ToUpper().Equals("DUMMY") || value.Trim().Equals(""))
                return null;
            return value.Trim();
        }
        /// <summary>
        /// Gets a nullable date time value for a datetime string provided it is either null string or invalid date string
        /// </summary>
        /// <param name="datetime">datetime value represented as string</param>
        /// <returns>DateTime?: Nullable datetime object is returned if 1st argument is either null string or invalid date string</returns>
        public static DateTime? GetNullableDateTime(string datetime)
        {
            DateTime? dt = null;
            DateTime dtt;

            if (DateTime.TryParse(datetime, out dtt))
                dt = dtt;
            return dt;
        }

        /// <summary>
        /// Gets a nullable Decimal for the string provided it is either null string or invalid decimal string
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Decimal?: Nullable decimal object</returns>
        public static Decimal? GetNullableDecimal(string value)
        {
            decimal? result = null;
            decimal tmpvalue;

            if (decimal.TryParse((string)value, out tmpvalue))
                result = tmpvalue;
            return result;
        }
        /// <summary>
        /// Gets a string for the date time string provided it is either null string or invalid format string
        /// </summary>
        /// <param name="datetimestring"> datase datetime values </param>
        /// <returns> Short Date String based on the configuration</returns>
        public static string GetDateTimeToString(string datetimestring, DateDisplayOption option = DateDisplayOption.Date)
        {
            DateTime dtt;
            string dtformatstring = null;
            if (DateTime.TryParse(datetimestring, out dtt))
            {
                dtformatstring = dtt.ToString("d");
                if (option == DateDisplayOption.DateTime)
                    dtformatstring = dtt.ToString("g");
                else if (option == DateDisplayOption.Time)
                    dtformatstring = dtt.ToString("t");
                else if (option == DateDisplayOption.DateTimeHR24)
                    dtformatstring = dtt.ToString("d") + " " + dtt.ToString("HH:mm");
                else if (option == DateDisplayOption.TimeHR24)
                    dtformatstring = dtt.ToString("HH:mm");
            }
            return dtformatstring;
        }
        /// <summary>
        /// Gets a date time object
        /// </summary>
        /// <param name="d">Date Time Object</param>
        /// <returns>Configured Shrot Date string</returns>
        public static string GetDateTimeToString(object datetime, DateDisplayOption option = DateDisplayOption.Date)
        {
            string datetimestring = string.Empty;
            if (datetime is DateTime)
            {
                datetimestring = ((DateTime)datetime).ToString("d");
                if (option == DateDisplayOption.DateTime)
                    datetimestring = ((DateTime)datetime).ToString("g");
                else if (option == DateDisplayOption.Time)
                    datetimestring = ((DateTime)datetime).ToString("t");
                else if (option == DateDisplayOption.DateTimeHR24)
                    datetimestring = ((DateTime)datetime).ToString("d") + " " + ((DateTime)datetime).ToString("HH:mm");
                else if (option == DateDisplayOption.TimeHR24)
                    datetimestring = ((DateTime)datetime).ToString("HH:mm");
            }
            return datetimestring;
        }

        /// <summary>
        /// Gets a date time object
        /// </summary>
        /// <param name="d">Date Time</param>
        /// <returns>Configured Shrot Date string</returns>
        public static string GetDateTimeToString(DateTime datetime, DateDisplayOption option = DateDisplayOption.Date)
        {

            string datetimestring = datetime.ToString("d");
            if (option == DateDisplayOption.DateTime)
                datetimestring = datetime.ToString("g");
            else if (option == DateDisplayOption.Time)
                datetimestring = datetime.ToString("t");
            else if (option == DateDisplayOption.DateTimeHR24)
                datetimestring = datetime.ToString("d") + " " + datetime.ToString("HH:mm");
            else if (option == DateDisplayOption.TimeHR24)
                datetimestring = datetime.ToString("HH:mm");

            return datetimestring;
        }

        public static string GetMixedCase(string myString)
        {

            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            string mixedCaseString = textInfo.ToTitleCase(myString.ToLower());
            return mixedCaseString;
        }

        public static byte? GetNullableByte(string value)
        {
            byte? i = null;
            byte ii;

            if (byte.TryParse(value, out ii))
                i = ii;
            return i;
        }



        public static bool IsvalidEmail(string email)
        {
            email = email.Replace(';', ',');
            email = email.Replace(" ", "");
            string[] mailids = email.Split(new char[] { ',' });

            foreach (string id in mailids)
            {
                string regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                Regex re = new Regex(regex, RegexOptions.IgnoreCase);
                if (!re.IsMatch(id))
                    return (false);
            }
            return (true);
        }
        public static bool IsValidPhoneNumber(string phonenumber)
        {
            phonenumber = phonenumber.Contains("~") ? phonenumber.Split('~')[1] : phonenumber;
            // Remove symbols (dash, space and parentheses, etc.)
            string strPhone = Regex.Replace(phonenumber, @"[- ()\*\!]", String.Empty);
            Regex isnumber = new Regex("[^0-9]");
            return string.IsNullOrEmpty(phonenumber) ? false : !isnumber.IsMatch(strPhone);
        }

        public static string DataTableToJSONWithJSONNet(DataTable table)
        {
            try
            {
                string JSONString = string.Empty;
                JSONString = JsonConvert.SerializeObject(table, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore

                });

                return JSONString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string DataSetToJSONWithJSONNet(DataSet ds)
        {
            try
            {
                string JSONString = string.Empty;
                JSONString = JsonConvert.SerializeObject(ds, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore

                });

                return JSONString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
    public enum DateDisplayOption
    {
        Date,
        DateTime,
        Time,
        DateTimeHR24,
        TimeHR24
    }
}