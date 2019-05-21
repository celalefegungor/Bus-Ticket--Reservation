using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyager.Entities;

namespace Voyager.DAL
{
    public class TicketRepo : BaseRepo<TicketPoc>, IRepo<TicketPoc>
    {
        public TicketRepo(DbContext voyagerContext) : base(voyagerContext)
        {

        }
    }
}
