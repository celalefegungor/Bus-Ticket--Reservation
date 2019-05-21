using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyager.Entities;

namespace Voyager.DAL
{
    public class DriverRepo : BaseRepo<DriverPoc>, IRepo<DriverPoc>
    {
        public DriverRepo(DbContext voyagerContext) : base(voyagerContext)
        {

        }
    }
}
