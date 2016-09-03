using System;
using System.IO;
using System.Web.UI;

namespace PostcodeClient
{
    public partial class PostcodeFinder : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //set the current time on the form when the page loads
            lblDTNow.Text = $"{DateTime.Now:HH:mm:ss tt}";
            //load the dropdownlist with the key values from the text file.
            var fileData =
                File.ReadAllLines(@"C:\Users\geoffpopple\Source\Repos\Assignment2\Assignment2\Postcodes.txt");
            foreach (var line in fileData)
            {
                var tokens = line.Split(',');
                postcodeList.Items.Add(tokens[0]);
            }
        }

        //Function used to access the webservice and update the label
        protected void btnShowPostcode_Click(object sender, EventArgs e)
        {
            var pc = new PCFinder.PostCodeFinderSoapClient();
            lblPostcode.Text = pc.GetPostCode(postcodeList.Text);
        }
    }
}