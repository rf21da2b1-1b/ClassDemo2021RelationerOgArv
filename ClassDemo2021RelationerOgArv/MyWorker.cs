using System;
using System.Collections.Generic;
using ClassDemo2021RelationerOgArv.model;

namespace ClassDemo2021RelationerOgArv
{
    internal class MyWorker
    {
        public MyWorker()
        {
        }

        public void Start()
        {
            TraekKrog krog = new TraekKrog();
            List<Hjul> hjul = new List<Hjul>()
            {
                new Hjul(16, "Firestone"),
                new Hjul(16, "Firestone"),
                new Hjul(16, "Firestone"),
                new Hjul(16, "Firestone")
            };

            Ejer ejer = new Ejer("Peter", "33445566");
            Car minBil = new Car("aa12345", "vW", 234000, ejer, hjul);
            Console.WriteLine(minBil);

            Car minBil2 = new Car("ZZ12345", "Ford", 456000, ejer, hjul, 350, "Tja");
            
            minBil2.AddHjul(16, "bridgestone");
            Console.WriteLine(minBil2);

        }
    }
}