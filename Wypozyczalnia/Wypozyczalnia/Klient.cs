using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class Klient {
        private string imie;
        private string nazwisko;
        private int wiek;
        private string adres;
        private string pesel;
        private int punkty;

        public Klient(string imie, string nazwisko, int wiek, string adres, string pesel) {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.adres = adres;
            this.pesel = pesel;

            this.punkty = 0;
        }
    }
}
