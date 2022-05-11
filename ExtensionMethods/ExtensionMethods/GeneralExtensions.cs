using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class GeneralExtensions
    {
        public static string RemoveSpaces(this string value)
        {
            return value.Replace(" ", "");
        }

        public static char NextChar(this Random value)
        {
            return (char)value.Next(65, 90);
        }

        public static char NextChar(this Random value, bool upperCase = true, bool includeNumbers = false)
        {
            var generatedChar = char.MinValue;
            if (upperCase)
                generatedChar = (char)value.Next(65, 90);
            else
                generatedChar = (char)value.Next(97, 122);



            if (includeNumbers)
                generatedChar = (char)value.Next(48, 57);

            return generatedChar;
        }




        public static string NextString(this Random value, int length)
        {

            string result = "";
            for (int i = 0; i < length; i++)
            {
                result += value.NextChar();
            }
            return result;

        }

        public static int TotalWorkDaysInYear(this DateTime value)
        {
            var totalWorkDays = 0;

            DateTime start = new DateTime(value.Year, 1, 1);
            DateTime end = new DateTime(value.Year, 12, 31);

            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                if (!(i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday))
                {
                    totalWorkDays++;
                }
            }

            return totalWorkDays;

        }
    }
}
