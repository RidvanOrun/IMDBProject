using IMDBProject.EntityLayer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.EntityLayer.Entities.Interface
{
    public interface IBaseEntity // Assigned tabloların sadece BaseEntityden kalıtım aldıkları "Id" parameteresinin görünmesi açısından IBaseEntity.cs interface ini kullandık 
        //Burada önemli olan Assigned tabloların sadeliği
    {
        DateTime? CreateDate { get; set ;  }
        DateTime? ModifiedDate { get; set; }
        DateTime? PassivedDAte { get; set; }       
        Status Status { get ; set ; }
    }
}
