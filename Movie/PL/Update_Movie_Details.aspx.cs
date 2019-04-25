using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBL;

namespace Movie.PL
{
    
    public partial class Update_Movie_Details : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = TextBox1.Text;
            Response.Write(MovieBAL.Validate_Search_Movie_Id(s));
            if(MovieBAL.Validate_Search_Movie_Id(s))
            {
                Label4.Visible = false;
                TextBox1.Visible = false;
                Button1.Visible = false;
                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;

            }
        }
    }
}