using IMDBProject.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.AccessLayer.Context
{
    public class ProjectContext:DbContext //EntityFramework sayesinde DBContext nesnemizi tanımladık.
    {
        public  ProjectContext()//CBağlantı yolu constructor methodunun içine yazıldı.
        {
            Database.Connection.ConnectionString = @"Server=(localdb)\MSSQLLocalDB; Database=IMDBPRoject; Integrated Security=true;";
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<AssignedMovieToDirektor> AssignedMovieToDirektors { get; set; }
        public DbSet<AssignedMovieToGenre> AssignedMovieToGenres { get; set; }
        
    }
}
