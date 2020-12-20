using IMDBProject.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMDBProject.AccessLayer.Repositories.Interface
{
    public interface IMovieRepository
    {
        void CreateMovie(string movieName, string content, string ımageUrl, DateTime productionDate, string movieReview);
        void ModifiedMovie(int id, string movieName, string content, string ımageUrl, DateTime productionDate, string movieReview);
        void PassiveMovie(int id);
      

        List<Movie> GetMovie();
       

    }
}
