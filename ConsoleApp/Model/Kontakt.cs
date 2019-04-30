using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    public class Kontakt
    {
        public int KontaktId { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public DateTime OprettelsesDato { get; set; }

    }
}
