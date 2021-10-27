using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021RelationerOgArv.model
{
    class Ejer
    {
        private string _navn;
        private string _tlf;

        public Ejer()
        {
        }

        public Ejer(string navn, string tlf)
        {
            _navn = navn;
            _tlf = tlf;
        }

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public string Tlf
        {
            get => _tlf;
            set => _tlf = value;
        }

        public override string ToString()
        {
            return $"{nameof(Navn)}: {Navn}, {nameof(Tlf)}: {Tlf}";
        }
    }
}
