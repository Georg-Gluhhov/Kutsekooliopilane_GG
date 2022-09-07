using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutsekooliopilane_GG
{
    internal class EnterValue
    {
        public void NewTootaja()
        {


            Tootaja Tootaja = new Tootaja(
                "Test",
                "Test", 
                1600, 
                "Oleg", 
                1993,
                Tootaja.sugu.mees);

        }
    }
}
