using IMDBProject.EntityLayer.Abstract;
using IMDBProject.EntityLayer.Entities.Interface;
using IMDBProject.EntityLayer.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.EntityLayer.Entities.Concrete
{
    [Table("Movie")]
    public class Movie : BaseEntity<int>,IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get ; set ; }
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string MovieName { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Content { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]        
        public DateTime ProductionDate { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(20)]
        public string MovieReview { get; set; }

        public List<AssignedMovieToGenre> AssignedMovieToGenres { get; set; } //AssignedMovieToGenre tablomuz ile movie tablosu arasındaki 1'e çok ilişki bağlantısı yapıldı.
        public List<AssignedMovieToDirektor> AssignedMovieToDirektors { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get ; set ; }
        public DateTime? PassivedDAte { get ; set ; }
        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }

    }
}
