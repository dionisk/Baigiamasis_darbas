using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Linq;

namespace Baigiamasis_Darbas
{
    public static class DB_Connection
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Baigiamasis_Darbas.Properties.Settings.QuizConnectionString"].ConnectionString;
        public static DataContext db = new DataContext(connectionString);
    }
}
