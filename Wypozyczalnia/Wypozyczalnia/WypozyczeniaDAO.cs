using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class WypozyczeniaDAO {
        List<Wypozyczenie> lista = new List<Wypozyczenie>();
        public List<Wypozyczenie> getWypozyczenia() {
            
            return lista;
        }

        public Wypozyczenie addWypozyczenie(Wypozyczenie wyp) {
            lista.Add(wyp);
            return wyp;
        }
    }
}
