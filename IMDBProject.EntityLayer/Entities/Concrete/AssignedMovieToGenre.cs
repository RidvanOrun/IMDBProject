using IMDBProject.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.EntityLayer.Entities.Concrete
{
    //Bir filmin birden fazla türü, bir türde de birden fazla filmi olabileceği için çoka çok ilişkiden dolayı assigned tabloya ihtiyaç vardır.
    [Table("AssignedMovieToGenre")]
    public class AssignedMovieToGenre : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [ForeignKey("Movie")] // Movie tablosunun Primary key si burada foreign key yapıldı.
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        [ForeignKey("Genre")]// Primary tablosunun Primary key si burada foreign key yapıldı.
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

    }
}
