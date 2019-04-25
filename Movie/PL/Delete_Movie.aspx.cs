using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBL;

namespace Movie.PL
{
    public partial class Delete_Movie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = TextBox1.Text;
            if (MovieBAL.Validate_Delete(id))
                Response.Write("<script>alert('Movie Deleted')</script>");
            else
                Response.Write("<script>alert('Movie Not Found')</script>");
        }
    }
}