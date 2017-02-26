using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Car
    {
        public NameChangeDelegate NameChanged;

        // prywatne pole
        private string _name;
        // publiczna właściwość (propercja)
        public string Name
        {
            // zwraca pole _name
            get { return _name; }

            // ustawia nazwę samochodu
            set
            {
                // sprawdza czy nowa nazwa nie jest identyczna jak poprzednia
                if (_name != value)
                {
                    var oldName = _name;
                    _name = value;

                    // sprawdza czy ktoś nasłuchuje
                    if (NameChanged != null)
                    {
                        // wywoluje zdarzenie informując innych
                        NameChanged(oldName, value);
                    }
                }
            }
        }
    }
}
