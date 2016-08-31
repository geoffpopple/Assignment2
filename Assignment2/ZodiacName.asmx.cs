using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    public class ZodiacName : System.Web.Services.WebService
    {
      private Dictionary<String, String> zodiac;
        public ZodiacName()

        {
            //create a dictionay of KV pairs to store our data
            zodiac = new Dictionary<String, String>()
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
        public string getZodiacDate(String sign)
        {
            string zodiacDate= "Not Found";
            //Iterate through the dictionary and match the sign with the key
            //convert the input to lowercaser to match the distionary key.
            foreach (KeyValuePair<String, String> entry in zodiac)
            {
                if (entry.Key.ToLower() == sign.ToLower())
                {
                    zodiacDate = entry.Value;
                    break;
                }
            }
            return zodiacDate;
        }
    }
}
