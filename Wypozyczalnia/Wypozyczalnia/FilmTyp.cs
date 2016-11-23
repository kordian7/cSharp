using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class FilmTyp {
        private string typ;
        private int iloscPkt;
        private double kosztDnia;

        public FilmTyp(string typ, int iloscPkt, double kosztDnia) {
            this.typ = typ;
            this.iloscPkt = iloscPkt;
            this.kosztDnia = kosztDnia;
        }

        public double getKosztDnia() {
            return this.kosztDnia;
        }

        public int getIloscPkt() {
            return iloscPkt;
        }

        public string getTyp()
        {
            return this.typ;
        }
    }
}
