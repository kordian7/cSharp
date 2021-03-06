﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    class Wypozyczenie {
        private Klient klient;
        private Film film;
        private DateTime dataOd;
        private DateTime dataDo;
        private double kwota;
        private KlientState klientState;

        public Wypozyczenie(Klient klient, Film film, DateTime dataOd, DateTime dataDo) {
            this.klient = klient;
            this.film = film;
            this.dataOd = dataOd;
            this.dataDo = dataDo;
            this.kwota = obliczKwote();
            if (klient.getPunkty() > 100)
                klientState = new VipKlientState();
            else
                klientState = new OrdinaryKlientState();
            this.klient.addPunkty(klientState.liczPunkty(this));

        }

        private double obliczKwote() {
            return film.getFilmTyp().getKosztDnia() * (dataDo - dataOd).TotalDays;
        }

        public void drukujPotwierdzenie(WyswietlaczPotwierdzenia wyswietlacz) {
            Console.WriteLine(wyswietlacz.wyswietlPotwierdzenie(this));
        }

        public Klient getKlient() {
            return klient;
        }

        public Film getFilm() {
            return film;
        }

        public int getIloscDni() {
            return Convert.ToInt32(Math.Round((dataDo - dataOd).TotalDays));
        }

        public double getKwota() {
            return kwota;
        }
    }
}
