using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class Film {
        private string nazwa;
        private string rezyser;
        private FilmTyp filmTyp;

        public Film(string nazwa, string rezyser, FilmTyp filmTyp) {
            this.nazwa = nazwa;
            this.rezyser = rezyser;
            this.filmTyp = filmTyp;
        }

        public FilmTyp getFilmTyp() {
            return this.filmTyp;
        }

        public string getTytul() {
            return this.nazwa;
        }
    }

    

}
