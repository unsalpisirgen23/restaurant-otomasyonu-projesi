
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;
using DAL.Entities.Employees;

namespace DAL.Repositories.Employees
{
    public class EmployeRepository : Repository<Employe>, IRepository<Employe>
    {
        public EmployeRepository(DbContext con) : base(con)
        {
        }
    }
}
