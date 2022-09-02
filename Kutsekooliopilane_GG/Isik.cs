using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutsekooliopilane_GG
{
    abstract class Isik
    {
        public string nimi;
        public int synniAasta;
        public enum sugu { mees, naine };
        public sugu Sugus;
        public Isik(string nimi, int synniAasta, sugu sugus)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            Sugus = sugus;
        }

        public Isik() {
          
        }
        public abstract void print_Info();
        public abstract void calculateAge();
        public abstract void changeName();
        public abstract void calculateIncome();

    }
}
