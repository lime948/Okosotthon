using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon.Models
{
    internal class Email : Ertesitesek
    {
        public string EmailCim { get; set; }
        public string Targy { get; set; }
        public Email(string uzenet, string emailCim, string targy) : base(uzenet)
        {
            EmailCim = emailCim;
            Targy = targy;
        }
        public override void Kuld()
        {
            Console.WriteLine($"E-mail küldése a következő címre: {EmailCim}, {IdoBelyeg}-kor, tárgy: {Targy}, {Uzenet} üzenettel.");
        }
    }
}
