using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Services;

namespace Assignment2
{
    /// <summary>
    /// Summary description for PostCodeFinder
    /// </summary>
    [WebService(Namespace = "http://example.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class PostCodeFinder : global::System.Web.Services.WebService
    {
        private const string PostcodeFile = @"C:\Users\geoffpopple\Source\\Repos\Assignment2\Assignment2\\Postcodes.txt";
        private Dictionary<String, String> _postcodes;
        private readonly bool _loadFlag = false;

        public PostCodeFinder()

        {
            //create a dictionary to store our data
            _postcodes = new Dictionary<String, String>();
            //see if we can load the data
            _loadFlag = Load_Postcodes();
        }

        [WebMethod]
        public string GetPostCode(String name)
        {
            if (_loadFlag == false)
            {
                return "File not Found";
            }
            string myValue;

            if (!_postcodes.TryGetValue(name, out myValue)) return "PostCode Not Found";

            return myValue;
        }

        private bool Load_Postcodes()
        {
            try
            {
                _postcodes = File.ReadLines(PostcodeFile)
                    .Select(line => line.Split(','))
                    .ToDictionary(line => line[0], line => line[1]);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}