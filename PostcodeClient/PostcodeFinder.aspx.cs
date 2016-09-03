using System;
using System.IO;
using System.Web.UI;


namespace PostcodeClient
{
    public partial class PostcodeFinder : Page
    {
        private const string PostcodePath = @"C:\Users\geoffpopple\Source\Repos\Assignment2\Assignment2\Postcodes.txt";

        protected void Page_Load(object sender, EventArgs e)
        {
            //set the current time on the form when the page loads
            lblDTNow.Text = $"{DateTime.Now:HH:mm:ss tt}";
            //load the dropdownlist with the key values from the text file.
            try
            {
                var lineOfContents =
                        File.ReadAllLines(PostcodePath);
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