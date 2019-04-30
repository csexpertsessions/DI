using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    public class DataContext: DbContext
    {

        public DataContext(): base("dbConnectionString")
        {

        }

        public DbSet<Kontakt> Kontakter { get; set; }
    }
}
