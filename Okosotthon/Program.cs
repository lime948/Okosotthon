using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Okosotthon.Models;

namespace Okosotthon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ertesitesek> csatornak = new List<Ertesitesek>();
            csatornak.Add(new Mobil("Mozgásérzékelő riasztása"));
            csatornak.Add(new Email("Hőmérséklet-csökkenés", "pelda@gmail.com", "Hőmérsékleti riasztás"));
            csatornak.Add(new SMS("Nyitva felejtett ajtó", "+36123456789"));

            foreach (Ertesitesek csatorna in csatornak)
            {
                csatorna.Kuld();
            }
        }
    }
}
