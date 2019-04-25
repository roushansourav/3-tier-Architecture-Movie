using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieModel;
using MovieDL;

namespace MovieBL
{
    public class MovieBAL
    {
        public static bool Validate_Insert(Movie m)
        {
            if(m.mid!=null & m.mname!=null & m.duration>60 &m.director!=null)
            {
                return MovieDAL.Insert_Movie(m);
                    
            }
            else
                return false;
        }

        public static bool Validate_Delete(string id)
        {
            if (id != null)
                return MovieDAL.Delete_Movie(id);
            else
                return false;
        }

        public static bool Validate_Update(string id,string mname,int duration, string director)
        {
            if (mname != null & duration >60 & director != null)
                return MovieDAL.UpdateMovieDetails(id, mname, duration, director);
            else
                return false;
        }
        public static bool Validate_Search_Movie_Id(string id)
        {
            if (id != null)
                return MovieDAL.SearchMovieId(id);
            else
                return false;
        }
    }
}
