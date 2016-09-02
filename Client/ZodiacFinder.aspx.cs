using System;

namespace Client
{
    public partial class ZodiacFinder : System.Web.UI.Page
    {   
        protected void Button1_Click(object sender, EventArgs e)
        {
            var zod=new ServiceReference1.ZodiacNameSoapClient();
            TextBox2.Text = zod.getZodiacDate(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var zon = new ServiceReference2.ZodiacDateSoapClient();
            TextBox5.Text = zon.GetSign(TextBox3.Text, TextBox4.Text);
        }
    }
}