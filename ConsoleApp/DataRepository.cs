using ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class DataRepository
    {
        private DataContext ctx = new DataContext();
        private Notifier n = new Notifier();

        public void OpretKontakt(Kontakt kontakt)
        {
            ctx.Kontakter.Add(kontakt);
            ctx.SaveChanges();
            n.Notify($"{kontakt} oprettet i databasen og har fået følgende id: {kontakt.KontaktId}");
        }

        public List<Kontakt> HentKntakter()
        {
            return ctx.Kontakter.ToList();
        }
    }
}
