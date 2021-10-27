using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021RelationerOgArv.model
{
    class TraekKrog
    {
        private int _kilo;
        private string _vendor;

        public TraekKrog()
        {
        }

        public TraekKrog(int kilo, string vendor)
        {
            _kilo = kilo;
            _vendor = vendor;
        }

        public int Kilo
        {
            get => _kilo;
            set => _kilo = value;
        }

        public string Vendor
        {
            get => _vendor;
            set => _vendor = value;
        }

        public override string ToString()
        {
            return $"{nameof(Kilo)}: {Kilo}, {nameof(Vendor)}: {Vendor}";
        }
    }
}
