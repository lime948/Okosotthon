using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon.Models
{
    internal class Ertesitesek
    {
        public string Uzenet { get; set; }

        public DateTime IdoBelyeg { get; set; }

        public Ertesitesek(string uzenet)
        {
            Uzenet = uzenet;
            IdoBelyeg = DateTime.Now;
        }

        public virtual void Kuld()
        {
            Console.WriteLine($"Értesítés elküldve: {Uzenet} Időbélyeg: {IdoBelyeg}");
        }
    }
}
