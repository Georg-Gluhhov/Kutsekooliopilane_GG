using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutsekooliopilane_GG
{
     class Kutsekooliopilane : Isik
    {
        // Kutsekooliõpilane(oppeasutus,eriala,kursus,toetus)
        string oppeasutus;
        string eriala;
        int kursus;
        int toetus;

        public Kutsekooliopilane(string oppeasutus, string eriala,int kursus, int toetus, string nimi, int synniAasta, sugu sugus) : base(nimi, synniAasta, sugus)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
        }
        public Kutsekooliopilane(Kutsekooliopilane kutsekooliopilane)
        {
            this.oppeasutus = kutsekooliopilane.oppeasutus;
            this.eriala = kutsekooliopilane.eriala;
            this.kursus = kutsekooliopilane.kursus;
            this.toetus = kutsekooliopilane.toetus;
            this.nimi = kutsekooliopilane.nimi;
            this.synniAasta = kutsekooliopilane.synniAasta;
            this.Sugus = kutsekooliopilane.Sugus;
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
            double end = (toetus - 500) * 0.8 + 500;
            Console.WriteLine($"palk - {end}");

        }

        public override void changeName()
        {
            Console.WriteLine("\nEnter name");

            this.nimi = Console.ReadLine();

        }

        public override void print_Info()
        {
            Console.WriteLine($"\nnimi on {nimi}, sugus on {Sugus}, synniaasta on {synniAasta}, oppeasutus - {oppeasutus}, eriala - {eriala},kursus - {kursus},toetus - {toetus}");
        }

    }
}
