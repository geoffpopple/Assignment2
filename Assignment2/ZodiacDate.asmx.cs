using System;
using System.Collections.Generic;
using System.Web.Services;

namespace Assignment2
{
    /// <summary>
    /// Summary description for ZodiacDate
    /// </summary>
    [WebService(Namespace = "http://example.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ZodiacDate : global::System.Web.Services.WebService
    {
        private readonly Dictionary<ZodiacSign, String> _zodiac;

        public ZodiacDate()
        {
            _zodiac = new Dictionary<ZodiacSign, String>()
            {
                {new ZodiacSign {DayFrom = "21", DayTo = "20", MonthFrom = "03", MonthTo = "04"}, "Aries"},
                {new ZodiacSign {DayFrom = "21", DayTo = "21", MonthFrom = "04", MonthTo = "05"}, "Taurus"},
                {new ZodiacSign {DayFrom = "22", DayTo = "21", MonthFrom = "05", MonthTo = "06"}, "Gemini"},
                {new ZodiacSign {DayFrom = "22", DayTo = "22", MonthFrom = "06", MonthTo = "07"}, "Cancer"},
                {new ZodiacSign {DayFrom = "23", DayTo = "22", MonthFrom = "07", MonthTo = "08"}, "Leo"},
                {new ZodiacSign {DayFrom = "23", DayTo = "23", MonthFrom = "08", MonthTo = "09"}, "Virgo"},
                {new ZodiacSign {DayFrom = "24", DayTo = "23", MonthFrom = "09", MonthTo = "10"}, "Libra"},
                {new ZodiacSign {DayFrom = "24", DayTo = "22", MonthFrom = "10", MonthTo = "11"}, "Scorpio"},
                {new ZodiacSign {DayFrom = "23", DayTo = "21", MonthFrom = "11", MonthTo = "12"}, "Sagittarius"},
                {new ZodiacSign {DayFrom = "22", DayTo = "20", MonthFrom = "12", MonthTo = "01"}, "Capricorn"},
                {new ZodiacSign {DayFrom = "21", DayTo = "19", MonthFrom = "01", MonthTo = "02"}, "Aquarius"},
                {new ZodiacSign {DayFrom = "20", DayTo = "20", MonthFrom = "02", MonthTo = "03"}, "Pisces"}
            };
        }

        [WebMethod]
        public string GetSign(String month, String day)
        {
            string output = "Wrong Input Date"; //default output

            int monthAsInt;
            int dayAsInt;

            //test to see if the values from the input text can be converted t numbers, if not return invald.
            bool result = int.TryParse(month, out monthAsInt);
            bool result2 = int.TryParse(day, out dayAsInt);

            if ((result || result2) == false)
            {
                return output;
            }

            //test if integers entered match validate date
            if (!ValidateDate(monthAsInt, dayAsInt)) return output;

            DateTime inputTime =
                Convert.ToDateTime(dayAsInt + "/" + monthAsInt + (monthAsInt == 1 && dayAsInt <= 20 ? "/2001" : "/2000"));

            foreach (KeyValuePair<ZodiacSign, String> entry in _zodiac)

            {
                //Create a datetime string from the data in the dictionary.  Acknoldge using a magic number her to
                //for create a valid date time. Yr2000 chosen as leap yesr.  If the end date month is Jan flick this date
                //over to 2001 so the date falls between correctly 
                DateTime fromDate = Convert.ToDateTime(entry.Key.DayFrom + "/" + entry.Key.MonthFrom + "/2000");
                DateTime toDate =
                    Convert.ToDateTime(entry.Key.DayTo + "/" + entry.Key.MonthTo +
                                       (entry.Key.MonthTo == "01" ? "/2001" : "/2000"));

                //check if my input date falls within the 2 date constructs built above.
                if (inputTime.Ticks < fromDate.Ticks || inputTime.Ticks > toDate.Ticks) continue;
                output = entry.Value;
                break;
            }
            return output;
        }

        private static bool ValidateDate(int month, int day)
        {
            //elimate dud months
            if (month <= 0 || month > 12)
            {
                return false;
            }
            else
            {
                //catch dates that are not appropriate for the month, using year 2000 in order 29 feb is permitted.
                return (day <= DateTime.DaysInMonth(2000, month) && day >= 1) ? true : false;
            }
        }

        private class ZodiacSign
        {
            public string DayFrom { get; set; }
            public string DayTo { get; set; }
            public string MonthFrom { get; set; }
            public string MonthTo { get; set; }
        }
    }
}