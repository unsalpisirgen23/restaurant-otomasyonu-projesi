using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;
using DAL.Entities.Communications;

namespace DAL.Repositories.Communications
{
    public class CommunicationRepository : Repository<Communication>, IRepository<Communication>
    {
        public CommunicationRepository(DbContext con) : base(con)
        {
        }
    }
}
