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

            wypozyczeniaDAO.addWypozyczenie(new Wypozyczenie(klientDAO.getKlienci().ElementAt(0), filmDAO.getFilm().ElementAt(0), new DateTime(2016, 10, 25), new DateTime(2016, 12, 25)));

            foreach (Wypozyczenie wyp in wypozyczeniaDAO.getWypozyczenia())
                wypozyczeniaDAO.getWypozyczenia().ElementAt(0).drukujPotwierdzenie(standard);

            foreach (Wypozyczenie wyp in wypozyczeniaDAO.getWypozyczenia())
            wypozyczeniaDAO.getWypozyczenia().ElementAt(0).drukujPotwierdzenie(html);

            Console.ReadLine();

        }
    }
}
