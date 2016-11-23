using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class OrdinaryKlientState : KlientState {
        public override int liczPunkty(Wypozyczenie wyp) {
            return wyp.getIloscDni() * wyp.getFilm().getFilmTyp().getIloscPkt();
        }
    }
}
