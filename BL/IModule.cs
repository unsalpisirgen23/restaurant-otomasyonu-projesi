using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL
{
    public interface IModule
    {
         string ConectionString { get; set; }

         void ConnectionString(string connectionString);

        void Menu(string menuItem);
        Form FormLoad(Form frm);
    }


}
