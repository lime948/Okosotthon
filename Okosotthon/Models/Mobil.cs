using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon.Models
{
    internal class Mobil : Ertesitesek
    {
        public string Eszkoz { get; set; }
        public Mobil(string uzenet) : base(uzenet)
        {
        }

        public override void Kuld()
        {
            Console.WriteLine($"Push értesítés küldése a következő eszközre: {Eszkoz}, {IdoBelyeg}-kor, {Uzenet} üzenettel.");
        }
    }
}
