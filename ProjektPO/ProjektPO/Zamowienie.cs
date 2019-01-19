﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    [Serializable]
    class Zamowienie : ICloneable, IComparable<Zamowienie>
    {
        string numerZamowienia;
        DateTime dataRozpoczeciaZamowienia;
        DateTime dataKoncaZamowienia;
        static int liczbaZamowien;
        Adres adres;
        Dieta wybranaDieta;
        MenuDieta menuWybor;


        public DateTime DataRozpoczeciaZamowienia { get => dataRozpoczeciaZamowienia; set => dataRozpoczeciaZamowienia = value; }
        public DateTime DataKoncaZamowienia { get => dataKoncaZamowienia; set => dataKoncaZamowienia = value; }
        internal Adres Adres { get => adres; set => adres = value; }
        public Dieta WybranaDieta { get => wybranaDieta; set => wybranaDieta = value; }
        internal MenuDieta MenuWybor { get => menuWybor; set => menuWybor = value; }

        static Zamowienie()
        {
            liczbaZamowien = 100;
        }

        public Zamowienie()
        {
            dataRozpoczeciaZamowienia = DateTime.Now;
            dataKoncaZamowienia = DateTime.Now;
            liczbaZamowien++;
            numerZamowienia = liczbaZamowien + "/" + dataRozpoczeciaZamowienia.Year;
            wybranaDieta = new Dieta();
            menuWybor = new MenuDieta();
        }

        public Zamowienie(DateTime dataRozpoczeciaZamowienia, DateTime dataKoncaZamowienia, Adres adres, Dieta wybranaDieta, MenuDieta menuWybor)
        {
            liczbaZamowien++;
            numerZamowienia = liczbaZamowien + "/" + dataRozpoczeciaZamowienia.Year;
            this.dataRozpoczeciaZamowienia = dataRozpoczeciaZamowienia;
            this.dataKoncaZamowienia = dataKoncaZamowienia;
            this.adres = adres;
            this.wybranaDieta = wybranaDieta;
            this.menuWybor = menuWybor;
        }

        /// <summary>
        /// Funkcja wyświetlająca listę diet możliwych do wyboru i pozwalająca na wybranie jednej z nich
        /// </summary>
        public void WybierzDiete()
        {
            int n, pozycja = 0;
            foreach (Dieta d in menuWybor.Menu)
            {
                pozycja++;
                string s = pozycja + ". " + d.Typ.ToString();
                Console.WriteLine(s);
            }

            Console.WriteLine("Wybierz numer diety: ");
            if (Int32.TryParse(Console.ReadLine(), out n)) 
            {
                if (n > 0 && n < pozycja)
                    WybranaDieta = MenuWybor.Menu[n - 1];
                else
                {
                    throw new ArgumentOutOfRangeException("Nieistniejąca dieta!");

                }
            }
        }

        /// <summary>
        /// Funkcja wyświetlająca listę alergenów dla wybranej wcześniej diety i pozwalająca na wybranie kilku alergenów lub braku(co oznacza, że nie wybierasz żadnego)
        /// </summary>
        public void WybierzAlergent()
        {
            int pozycja = 0, n;
            foreach (SAlergen a in WybranaDieta.Alergeny)
            {
                pozycja++;
                string s = pozycja + ". " + a.Nazwa.ToString();
                Console.WriteLine(s);
            }
            
            Console.WriteLine("Wybierz numer alergenu: ");

            do
            {
                if (Int32.TryParse(Console.ReadLine(), out n)) 
                {
                    if (n > 0 && n < pozycja)
                        WybranaDieta.Alergeny[n - 1].Wybrane = true;

                    else
                    {
                        throw new ArgumentOutOfRangeException("Nieistniejący alergen!");
                    }
                }
            } while (n != 0);
        }

        /// <summary>
        ///Funkcja obliczająca cenę końcową zamówienia = cena wybranej diety + ceny wybranych alergenów
        /// </summary>
        public double CenaKoncowa()
       
        {
            double cenaKoncowa;
            cenaKoncowa = WybranaDieta.Cena;

            foreach (SAlergen a in WybranaDieta.Alergeny)
            {
                if (a.Wybrane == true)
                {
                    cenaKoncowa = cenaKoncowa + a.Cena;
                }
            }
            Console.WriteLine(cenaKoncowa);
            return cenaKoncowa;
        }

        public object Clone()
        {
            return new Zamowienie(dataRozpoczeciaZamowienia, dataKoncaZamowienia, (Adres)Adres.Clone(), wybranaDieta.Clone1(), (MenuDieta)menuWybor.Clone());
        }

        public int CompareTo(Zamowienie z)
        {
            return numerZamowienia.CompareTo(z.numerZamowienia);
        }

    }
}
