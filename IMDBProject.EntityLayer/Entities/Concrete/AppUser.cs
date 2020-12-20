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
    [Table("AppUser")] //Tabloadı tanımlandı //Maping işlemleri kapsamında yapılmaktadır.
    public class AppUser : BaseEntity<int>,IBaseEntity // BaseEntity İnherit edildi.
    {
        [Key] //Primary key verildi
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set ; } // BaseEntityClass'ındaki abstract olarak tanımlanan ıd override edildi
        [Required] // Doldurulması zorunlu alan tanımı yapıldı
        [MaxLength(15)]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(2)]
        public string PAssword { get; set; }
        public Role Role { get; set; } //Enum Role classından Role türünde role alındı

        public List<AssignedMovieToDirektor> AssignedMovieToDirektors { get; set; }
        public DateTime? CreateDate { get ; set ; }
        public DateTime? ModifiedDate { get ; set ; }
        public DateTime? PassivedDAte { get ; set; }
        private Status _status=Status.Active;
        public Status Status { get { return _status;} set { _status=value ; } }
    }
}
