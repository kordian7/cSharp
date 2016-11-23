using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class FilmDAO {

        List<Film> lista = new List<Film>();
        FilmTyp normalny = new FilmTyp("normalny", 1, 1.5);
        FilmTyp dzieciecy = new FilmTyp("dzieciecy", 1, 1.2);
        FilmTyp nowosc = new FilmTyp("nowosc", 2, 2.25);
        FilmTyp western = new FilmTyp("western", 1, 1.0);

        public FilmDAO()
        {
            lista.Add(new Film("Film1", "Rezyser1", normalny));
            lista.Add(new Film("Film2", "Rezyser2", dzieciecy));
            lista.Add(new Film("Film3", "Rezyser1", nowosc));
            lista.Add(new Film("Film4", "Rezyser3", nowosc));
            lista.Add(new Film("Film5", "Rezyser4", normalny));
            lista.Add(new Film("Film6", "Rezyser2", nowosc));
            lista.Add(new Film("Film7", "Rezyser5", western));
        }

        public List<Film> getFilm() {

            return lista;
        }
    }
}
