using IMDBProject.AccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.AccessLayer.Repositories.Concrete
{
    public class EfBaseRepository
    {
        public ProjectContext db;

        public EfBaseRepository()
        {
            db = new ProjectContext();
        
        }
    }
}
