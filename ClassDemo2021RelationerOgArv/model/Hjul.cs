using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021RelationerOgArv.model
{
    class Hjul
    {
        private int _size;
        private string _vendor;

        public Hjul()
        {
        }

        public Hjul(int size, string vendor)
        {
            _size = size;
            _vendor = vendor;
        }

        public int Size
        {
            get => _size;
            set => _size = value;
        }

        public string Vendor
        {
            get => _vendor;
            set => _vendor = value;
        }

        public override string ToString()
        {
            return $"{nameof(Size)}: {Size}, {nameof(Vendor)}: {Vendor}";
        }
    }
}
