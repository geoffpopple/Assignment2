using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    public class ZodiacDate : System.Web.Services.WebService
    {
        private Dictionary<ZodiacSign, String> zodiac;

        public ZodiacDate()
        {
            zodiac = new Dictionary<ZodiacSign, String>()
            {
                {new ZodiacSign {DayFrom="21", DayTo="20",MonthFrom="03",MonthTo="04"}, "Aries"},
                {new ZodiacSign {DayFrom="21", DayTo="21",MonthFrom="04",MonthTo="05"}, "Taurus"},
                {new ZodiacSign {DayFrom="22", DayTo="21",MonthFrom="05",MonthTo="06"}, "Gemini"},
                {new ZodiacSign {DayFrom="22", DayTo="22",MonthFrom="06",MonthTo="07"}, "Cancer"},
                {new ZodiacSign {DayFrom="23", DayTo="22",MonthFrom="07",MonthTo="08"}, "Leo"},
                {new ZodiacSign {DayFrom="23", DayTo="23",MonthFrom="08",MonthTo="09"}, "Virgo"},
                {new ZodiacSign {DayFrom="24", DayTo="23",MonthFrom="09",MonthTo="10"}, "Libra"},
                {new ZodiacSign {DayFrom="24", DayTo="22",MonthFrom="10",MonthTo="11"}, "Scorpio"},
                {new ZodiacSign {DayFrom="23", DayTo="21",MonthFrom="11",MonthTo="12"}, "Sagittarius"},
                {new ZodiacSign {DayFrom="22", DayTo="20",MonthFrom="12",MonthTo="01"}, "Capricorn"},
                {new ZodiacSign {DayFrom="21", DayTo="19",MonthFrom="01",MonthTo="02"}, "Aquarius"},
                {new ZodiacSign {DayFrom="20", DayTo="20",MonthFrom="02",MonthTo="03"}, "Pisces"}
            };
        }
        [WebMethod]
        public string getSign(String month, String day)
        {

            String output = "Wrong Input Date"; //default output

            int monthAsInt = Convert.ToInt32(month);
            int dayAsInt = Convert.ToInt32(day);
            
            if (validateDate(monthAsInt, dayAsInt))

            {

            DateTime inputTime = Convert.ToDateTime(dayAsInt + "/" + monthAsInt + (monthAsInt == 1 && dayAsInt <= 20?"/2001":"/2000"));

                foreach (KeyValuePair<ZodiacSign, String> entry in zodiac)
                {
                    DateTime fromDate = Convert.ToDateTime(entry.Key.DayFrom + "/" + entry.Key.MonthFrom + "/2000");
                    DateTime toDate= Convert.ToDateTime(entry.Key.DayTo + "/" + entry.Key.MonthTo +(entry.Key.MonthTo=="01"?"/2001":"/2000"));

                    if (inputTime.Ticks >= fromDate.Ticks && inputTime.Ticks <= toDate.Ticks)
                    {
                        output = entry.Value;
                        break;
                    }
                }
            }
           return output;
           
        }

        private bool validateDate(Int32 month, Int32 day)
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

        class ZodiacSign
        {
            public string DayFrom { get; set; }
            public string DayTo { get; set; }
            public string MonthFrom { get; set; }
            public string MonthTo { get; set; }
        }
    }
}
