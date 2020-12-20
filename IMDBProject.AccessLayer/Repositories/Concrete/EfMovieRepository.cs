using IMDBProject.AccessLayer.Repositories.Interface;
using IMDBProject.EntityLayer.Entities.Concrete;
using IMDBProject.EntityLayer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IMDBProject.AccessLayer.Repositories.Concrete
{
    public class EfMovieRepository : EfBaseRepository, IBaseRepository,IMovieRepository
    {
        EfBaseRepository ef = new EfBaseRepository();
      
        public void CreateMovie(string movieName, string content, string ımageUrl, DateTime productionDate, string movieReview)
        {
            Movie movie = new Movie();
            movie.MovieName = movieName;
            movie.Content = content;
            movie.ImageUrl = ımageUrl;
            movie.ProductionDate = productionDate;
            movie.MovieReview = movieReview;
            movie.CreateDate = DateTime.Now;
            movie.Status = Status.Active;
            db.Movies.Add(movie);
            db.SaveChanges();
            
        }

        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        public List<Movie> GetMovie()
        {
            return db.Movies.Where(x=> x.Status !=Status.Passive).ToList();
        }

        public void ModifiedMovie(int id, string movieName, string content, string ımageUrl, DateTime productionDate, string movieReview)
        {
            Movie movie = new Movie();
            movie = db.Movies.FirstOrDefault(x=>x.Id==id);
            movie.MovieName = movieName;
            movie.Content = content;
            movie.ImageUrl = ımageUrl;
            movie.ProductionDate = productionDate;
            movie.MovieReview = movieReview;
            movie.ModifiedDate = DateTime.Now;
            movie.Status = Status.Modified;
            db.SaveChanges();
        }

        public void PassiveMovie(int id)
        {
            Movie movie = new Movie();
            movie = db.Movies.FirstOrDefault(x => x.Id == id);
            movie.PassivedDAte = DateTime.Now;
            movie.Status = Status.Passive;
            db.SaveChanges();
        }
    }
}
