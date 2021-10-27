using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021RelationerOgArv.model
{
    class Car
    {
        private string _regNo;
        private string _vendor;
        private int _price;


        /*
         * Composite - kun oprette og slette inde i klassen
         */
        private TraekKrog _traekKrog;

        /*
         * Aggregering - kan oprette og slette i klassen eller uden for klassen
         */
        private List<Hjul> _hjul;

        /*
         * Associering - opretter og sletter udenfor klassen
         */
        private Ejer _ejer;

        public Car()
        {
        }

        public Car(string regNo, string vendor, int price, Ejer ejer, List<Hjul> hjul, int traekkrogKilo = 0, string traekkrogVendor = "")
        {
            _regNo = regNo;
            _vendor = vendor;
            _price = price;
            _ejer = ejer;

            if (traekkrogKilo >= 0)
            {
                _traekKrog = new TraekKrog(traekkrogKilo, traekkrogVendor);
            }
            else
            {
                _traekKrog = null;
            }
            _hjul = new List<Hjul>(hjul);
        }

        public void AddHjul(int size, string vendor)
        {
            Hjul hjul = new Hjul(size, vendor);
            _hjul.Add(hjul);

        }


        public string RegNo
        {
            get => _regNo;
            set => _regNo = value;
        }

        public string Vendor
        {
            get => _vendor;
            set => _vendor = value;
        }

        public TraekKrog TraekKrog
        {
            get => _traekKrog;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public override string ToString()
        {
            return $"Ejer: {_ejer}, {nameof(RegNo)}: {RegNo}, {nameof(Vendor)}: {Vendor}, {nameof(TraekKrog)}: {TraekKrog}, {nameof(Price)}: {Price}, Hjul: {String.Join(',', _hjul)}";
        }
    }
}
