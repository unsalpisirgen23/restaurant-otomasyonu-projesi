using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class Model
    {
        private static UnitOfWork DB;

        public static UnitOfWork Db
        {
            get
            {                
                DB = new UnitOfWork(new RestaurantContext("name=RMSContext"));
                
                return DB;
            }
        }


        public static int Save (){
                return DB.Complete();
        }

    }
}
