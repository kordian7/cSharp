using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class WyswietlaczPotwierdzeniaStandard : WyswietlaczPotwierdzenia {
        public override String wyswietlPotwierdzenie(Wypozyczenie wyp) {
            return "Zwykle Potwierdzenie\nTytul: " +
                wyp.getFilm().getTytul() + " Ilosc dni: " + wyp.getIloscDni() + " Nazwisko klienta: " + wyp.getKlient().getNazwisko() +
                " Rodzaj filmu: " + wyp.getFilm().getRodzajFilmu() + " Kwota: " + wyp.getKwota() + " Obecna ilosc puntow klienta: " + wyp.getKlient().getPunkty() + "\n";

        }
    }
}
