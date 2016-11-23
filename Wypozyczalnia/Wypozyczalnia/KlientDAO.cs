using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class KlientDAO {

        List<Klient> lista = new List<Klient>();
        public KlientDAO()
        {
            lista.Add(new Klient("Adam", "Nowak", 32, "Krakow, Dluga 32", "84050311122"));
            lista.Add(new Klient("Alina", "Kowalska", 32, "Krakow, Dluga 34", "84050311122"));
            lista.Add(new Klient("Marek", "Krasinski", 32, "Krakow, Krotka 32", "84050311122"));
            lista.Add(new Klient("Jozef", "Mickiewicz", 32, "Krakow, Dluga 32", "84050311122"));
            lista.Add(new Klient("Jan", "Chopin", 32, "Krakow, Dluga 32", "84050311122"));
            lista.Add(new Klient("Maria", "Nowak", 32, "Krakow, Dluga 32", "84050311122"));
        }

        public List<Klient> getKlienci() {
            
            return lista;
        }
    }
}
