using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyager.Entities;

namespace Voyager.DAL
{
    public class ExpeditionRepo : BaseRepo<ExpeditionPoc>, IRepo<ExpeditionPoc>
    {
        public ExpeditionRepo(DbContext voyagerContext) : base(voyagerContext)
        {

        }
    }
}
