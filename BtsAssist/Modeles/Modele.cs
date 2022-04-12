using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BtsAssist
{
    class Modele
    {
        protected MySqlConnection conn = new MySqlConnection("database=btsassist; server=localhost; user id = root; pwd=");

    }
}
