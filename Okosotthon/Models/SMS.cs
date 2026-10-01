using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon.Models
{
    internal class SMS : Ertesitesek
    {
        public string TelefonSzam { get; set; }
        public SMS(string uzenet, string telefonSzam) : base(uzenet)
        {
            TelefonSzam = telefonSzam;
        }
        public override void Kuld()
        {
            Console.WriteLine($"SMS küldése a következő telefonszámra: {TelefonSzam}, {IdoBelyeg}-kor, {Uzenet} üzenettel.");
        }
    }
}
