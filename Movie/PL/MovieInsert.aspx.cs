using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieModel;
using MovieBL;

namespace Movie.PL
{
    public partial class MovieInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mid = TextBox1.Text;
            string mname = TextBox2.Text;
            int duration = int.Parse(TextBox3.Text);
            string director = TextBox4.Text;
            MovieModel.Movie m = new MovieModel.Movie();
            m.mid = mid;m.mname = mname;m.duration = duration;m.director = director;
            if (MovieBAL.Validate_Insert(m))
                Response.Write("<script>alert('Movie Added Successfully')</script>");
            else
                Response.Write("<script>alert('Invalid Data')</script>");


        }
    }
}