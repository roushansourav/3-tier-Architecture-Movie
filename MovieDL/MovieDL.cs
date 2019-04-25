using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieModel;
using System.Data.SqlClient;

namespace MovieDL
{
    public class MovieDAL
    {
        public static bool Insert_Movie(Movie m)
        {
            SqlConnection con = new SqlConnection
                (@"initial catalog=ADODemo;data source=CGI-JAVA-055\CGI;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into moviedetails values(@p1,@p2,@p3,@p4)", con);
            cmd.Parameters.AddWithValue("@p1",m.mid);
            cmd.Parameters.AddWithValue("@p2", m.mname);
            cmd.Parameters.AddWithValue("@p3", m.duration);
            cmd.Parameters.AddWithValue("@p4", m.director);
            int cnt=cmd.ExecuteNonQuery();
            con.Close();
            if (cnt > 0)
                return true;
            else
                return false;
        }

        public static bool Delete_Movie(string id)
        {
            SqlConnection con = new SqlConnection
                (@"initial catalog=ADODemo;data source=CGI-JAVA-055\CGI;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from moviedetails where mid=@p1", con);
            cmd.Parameters.AddWithValue("@p1",id);            
            int cnt = cmd.ExecuteNonQuery();
            con.Close();
            if (cnt > 0)
                return true;
            else
                return false;
        }

        public static bool SearchMovieId(string id)
        {
            SqlConnection con = new SqlConnection
                (@"initial catalog=ADODemo;data source=CGI-JAVA-055\CGI;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from moviedetails where mid=@p1", con);
            cmd.Parameters.AddWithValue("@p1", id);
            int cnt = cmd.ExecuteNonQuery();
            con.Close();
            if (cnt > 0)
                return true;
            else
                return false;
        }

        public static bool UpdateMovieDetails(string id,string mname,int duration,string director)
        {
            SqlConnection con = new SqlConnection
                (@"initial catalog=ADODemo;data source=CGI-JAVA-055\CGI;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("update moviedetails set mname=@p2,duration=@p3,director=@p4 where mid=@p1" , con);
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.Parameters.AddWithValue("@p2", mname);
            cmd.Parameters.AddWithValue("@p3", duration);
            cmd.Parameters.AddWithValue("@p4", director);
            int cnt = cmd.ExecuteNonQuery();
            con.Close();
            if (cnt > 0)
                return true;
            else
                return false;
        }

    }
}
