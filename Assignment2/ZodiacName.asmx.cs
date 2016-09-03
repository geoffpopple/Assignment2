using System;
using System.Collections.Generic;
using System.Web.Services;

namespace Assignment2
{
    /// <summary>
    /// Summary description for ZodiacName
    /// </summary>
    [WebService(Namespace = "http://example.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ZodiacName : WebService
    {
      private readonly Dictionary<String, String> _zodiac;
        public ZodiacName()

        {
            //create a dictionay of KV pairs to store our data
            _zodiac = new Dictionary<String, String>()
            {
                { "aries","03/21-04/20"},
                { "taurus","04/21-05/21"},
                { "gemini","05/22-06-21"},
                { "cancer","06/22-07/22"},
                { "leo","07/23-08/22"},
                { "virgo","08/23-09/23"},
                { "libra","09/24-10/23"},
                { "Scorpio","10/24-11/22"},
                { "sagittarius","11/23-12/21"},
                { "capricorn","12/22-01/20"},
                { "aquarius","01/21-02/19"},
                { "pisces","02/20-03/20"}
            };
        }

        [WebMethod]
        public string GetZodiacDate(String sign)
        {
            string zodiacDate= "Not Found";
            //Iterate through the dictionary and match the sign with the key
            //ignore the case of the input during comparison such that leo==Leo.
            foreach (KeyValuePair<String, String> entry in _zodiac)
            {
                if (!String.Equals(entry.Key, sign, StringComparison.CurrentCultureIgnoreCase)) continue;
                zodiacDate = entry.Value;
                break;
            }
            return zodiacDate;
        }
    }
}
