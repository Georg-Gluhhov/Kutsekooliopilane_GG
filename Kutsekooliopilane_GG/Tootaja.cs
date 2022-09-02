using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutsekooliopilane_GG
{
    class Tootaja : Isik
    {
        double palk;
        public Tootaja(double palk, string nimi, int synniAasta, sugu sugus) : base(nimi, synniAasta, sugus)
        {
            this.palk = palk;
        }
        public Tootaja(Tootaja tootaja)
        {
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
            Console.WriteLine($"{Age}");
            Console.WriteLine(today);

        }

        public override void calculateIncome()
        {
            double end = (palk - 500) * 0.8 + 500;
            Console.WriteLine(end);          

        }

        public override void changeName()
        {
            Console.WriteLine("Enter name");

            this.nimi = Console.ReadLine();

        }

        public override void print_Info()
        {
            Console.WriteLine($"{nimi}, {Sugus}, {synniAasta}");
        }
    }
}
