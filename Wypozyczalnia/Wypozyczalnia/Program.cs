using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class Program {
        static void Main(string[] args) {
            WypozyczeniaDAO wypozyczeniaDAO = new WypozyczeniaDAO();
            FilmDAO filmDAO = new FilmDAO();
            KlientDAO klientDAO = new KlientDAO();

            WyswietlaczPotwierdzenia standard = new WyswietlaczPotwierdzeniaStandard();
            WyswietlaczPotwierdzenia html = new WyswietlaczPotwierdzeniaHTML();
            Wypozyczenie wyp;
            wyp = wypozyczeniaDAO.addWypozyczenie(new Wypozyczenie(klientDAO.getKlienci().ElementAt(0), filmDAO.getFilm().ElementAt(0), new DateTime(2016, 8, 20), new DateTime(2016, 12, 25)));
            wyp.drukujPotwierdzenie(standard);
            wyp.drukujPotwierdzenie(html);
            wyp = wypozyczeniaDAO.addWypozyczenie(new Wypozyczenie(klientDAO.getKlienci().ElementAt(1), filmDAO.getFilm().ElementAt(6), new DateTime(2016, 9, 25), new DateTime(2016, 10, 11)));
            wyp.drukujPotwierdzenie(standard);
            wyp = wypozyczeniaDAO.addWypozyczenie(new Wypozyczenie(klientDAO.getKlienci().ElementAt(0), filmDAO.getFilm().ElementAt(0), new DateTime(2016, 8, 20), new DateTime(2016, 12, 25)));
            wyp.drukujPotwierdzenie(standard);

            wyp = wypozyczeniaDAO.addWypozyczenie(new Wypozyczenie(klientDAO.getKlienci().ElementAt(2), filmDAO.getFilm().ElementAt(1), new DateTime(2016, 8, 20), new DateTime(2016, 12, 25)));
            wyp.drukujPotwierdzenie(html);

            wyp = wypozyczeniaDAO.addWypozyczenie(new Wypozyczenie(klientDAO.getKlienci().ElementAt(2), filmDAO.getFilm().ElementAt(2), new DateTime(2016, 8, 20), new DateTime(2016, 12, 25)));
            wyp.drukujPotwierdzenie(html);


            Console.ReadLine();

        }
    }
}
