using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class VipKlientState :KlientState {
        public override int liczPunkty(Wypozyczenie wyp) {
            return (wyp.getIloscDni() + 4) * wyp.getFilm().getFilmTyp().getIloscPkt() + wyp.getFilm().getFilmTyp().getIloscPkt();
        }
    }
}
