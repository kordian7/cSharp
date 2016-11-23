using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class WyswietlaczPotwierdzeniaHTML : WyswietlaczPotwierdzenia {
        public override String wyswietlPotwierdzenie(Wypozyczenie wyp) {
            return "Potwierdzenie HTML\nTytul: " +
                wyp.getFilm().getTytul() + " Ilosc dni: " + wyp.getIloscDni() + " Nazwisko klienta: " + wyp.getKlient().getNazwisko() +
                " Rodzaj filmu: " + wyp.getFilm().getRodzajFilmu() + " Kwota: " + wyp.getKwota() + " Obecna ilosc puntow klienta: " + wyp.getKlient().getPunkty() + "\n";
        }
    }
}
