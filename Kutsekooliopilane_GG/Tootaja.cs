using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutsekooliopilane_GG
{
    //    Töötaja (asutus, amet,tootasu),
    class Tootaja : Isik
    {
        string asutus;
        string amet;
        double palk;

        public Tootaja(string asutus, string amet,double palk, string nimi, int synniAasta, sugu sugus) : base(nimi, synniAasta, sugus)
        {
            this.asutus = asutus;
            this.amet = amet;   
            this.palk = palk;
        }
        public Tootaja(Tootaja tootaja)
        {
            this.asutus=tootaja.asutus;
            this.amet=tootaja.amet;
            this.palk = tootaja.palk;
            this.nimi = tootaja.nimi;
            this.synniAasta = tootaja.synniAasta;
            this.Sugus = tootaja.Sugus;
        }

        public override void calculateAge()
        {
            System.DateTime moment = System.DateTime.Now;

            int today = moment.Year;
            var Age = today - synniAasta;
            Console.WriteLine($"age - {Age}");

        }

        public override void calculateIncome()
        {
            double end = (palk - 500) * 0.8 + 500;
            Console.WriteLine($"palk - {end}");          

        }

        public override void changeName()
        {
            Console.WriteLine("\nEnter name");

            this.nimi = Console.ReadLine();

        }

        public override void print_Info()
        {
            Console.WriteLine($"\nnimi on {nimi}, sugus on {Sugus}, synniaasta on {synniAasta}, amet - {amet}, asutus {asutus}");
        }
    }
}
