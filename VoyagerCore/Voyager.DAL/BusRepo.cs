using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyager.Entities;

namespace Voyager.DAL
{
    public class BusRepo:BaseRepo<BusPoc>,IRepo<BusPoc>
    {


        public BusRepo(DbContext voyagerContext) : base(voyagerContext)
        {

        }
    }
}
