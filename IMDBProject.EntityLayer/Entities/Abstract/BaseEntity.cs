using IMDBProject.EntityLayer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.EntityLayer.Abstract
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }
     
    }
}
