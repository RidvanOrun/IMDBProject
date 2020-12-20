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
    [Table("Genre")] 
    public class Genre : BaseEntity<int>,IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get ; set; }
        [Required]
        public string GenreName { get; set; }

        public List<AssignedMovieToGenre> AssignedMovieToGenres { get; set; } //AssignedMovieToGenre tablomuz ile movie tablosu arasındaki 1'e çok ilişki bağlantısı yapıldı.
        public DateTime? CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? ModifiedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? PassivedDAte { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }
    }
}
