using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kutsekooliopilane_GG.Isik;

namespace Kutsekooliopilane_GG
{
    class Opilane : Isik
    {
        //    Opilane(koolinimi,klass,spetsialiseerumine)
        string koolinimi;
        string klass;
        string spetsialiseerumine;

        public Opilane(string koolinimi, string klass, string spetsialiseerumine, string nimi, int synniAasta, sugu sugus) : base(nimi, synniAasta, sugus)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
        }
        public Opilane(Opilane opilane)
        {
            this.koolinimi = opilane.koolinimi;
            this.klass = opilane.klass;
            this.spetsialiseerumine = opilane.spetsialiseerumine;
            this.nimi = opilane.nimi;
            this.synniAasta = opilane.synniAasta;
            this.Sugus = opilane.Sugus;
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
            double end = (60 - 500) * 0.8 + 500;
            Console.WriteLine($"palk - {end}");

        }

        public override void changeName()
        {
            Console.WriteLine("\nEnter name");

            this.nimi = Console.ReadLine();

        }

        public override void print_Info()
        {
            Console.WriteLine($"\nnimi on {nimi}, sugus on {Sugus}, synniaasta on {synniAasta}, koolinimi - {koolinimi}, klass - {klass},spetsialiseerumine - {spetsialiseerumine}");
        }
    }
}
