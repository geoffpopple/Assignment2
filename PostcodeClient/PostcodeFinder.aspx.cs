using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostcodeClient
{
    public partial class PostcodeFinder : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //set the current time on the form when the page loads
            lblDTNow.Text = $"{DateTime.Now:HH:mm:ss tt}";
            //load the dropdownlist with the key values from the text file.
            try
            {
                var lineOfContents =
                        File.ReadAllLines(@"C:\Users\geoffpopple\Source\Repos\Assignment2\Assignment2\Postcodes.txt");
                foreach (var line in lineOfContents)
                {
                    var tokens = line.Split(',');
                    DropDownList1.Items.Add(tokens[0]);
                }
            }
            catch (Exception)
            {
                //would typically log this error, but this is simple app so will just  write
                //the exception type desction to console and continue
                Console.WriteLine(typeof(Exception).ToString());   
            }   
        }

        protected void btnShowPostcode_Click(object sender, EventArgs e)
        {
            var pc = new PCFinder.PostCodeFinderSoapClient();
            Label1.Text = pc.GetPostCode(DropDownList1.Text);
        }
    }
}