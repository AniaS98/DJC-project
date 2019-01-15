﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class MenuDieta : Dieta, ICloneable
    {
        List<Dieta> menu;

        public List<Dieta> Menu { get => menu; set => menu = value; }

        public MenuDieta()
        {
            Menu = new List<Dieta>();

            SAlergen S0 = new SAlergen(ERodzajAlergenu.brak, 0);
            SAlergen S1 = new SAlergen(ERodzajAlergenu.gluten, 4.0);
            SAlergen S2 = new SAlergen(ERodzajAlergenu.mleko, 3.5);
            SAlergen S3 = new SAlergen(ERodzajAlergenu.jajka, 3.5);
            SAlergen S4 = new SAlergen(ERodzajAlergenu.ryby, 2.0);
            SAlergen S5 = new SAlergen(ERodzajAlergenu.skorupiaki, 1.0);
            SAlergen S6 = new SAlergen(ERodzajAlergenu.orzechy, 1.5);
            SAlergen S8 = new SAlergen(ERodzajAlergenu.soja, 2.0);
            SAlergen S9 = new SAlergen(ERodzajAlergenu.sezam, 1.0);
            SAlergen S11 = new SAlergen(ERodzajAlergenu.gorczyca, 3.0);
            SAlergen S12 = new SAlergen(ERodzajAlergenu.łubin, 2.5);
            SAlergen S13 = new SAlergen(ERodzajAlergenu.seler, 2.0);
            SAlergen S14 = new SAlergen(ERodzajAlergenu.mięczaki, 3.0);

            List<SAlergen> alergenyPodstawowa = new List<SAlergen>();
            alergenyPodstawowa.Add(S0);
            alergenyPodstawowa.Add(S1);
            alergenyPodstawowa.Add(S2);
            alergenyPodstawowa.Add(S3);
            alergenyPodstawowa.Add(S4);
            alergenyPodstawowa.Add(S5);
            alergenyPodstawowa.Add(S6);
            alergenyPodstawowa.Add(S8);
            alergenyPodstawowa.Add(S9);
            alergenyPodstawowa.Add(S11);
            alergenyPodstawowa.Add(S12);
            alergenyPodstawowa.Add(S13);
            alergenyPodstawowa.Add(S14);

            List<SAlergen> alergenyWegetarianska = new List<SAlergen>();
            alergenyWegetarianska.Add(S0);
            alergenyWegetarianska.Add(S1);
            alergenyWegetarianska.Add(S2);
            alergenyWegetarianska.Add(S3);
            alergenyWegetarianska.Add(S6);
            alergenyWegetarianska.Add(S8);
            alergenyWegetarianska.Add(S9);
            alergenyWegetarianska.Add(S11);
            alergenyWegetarianska.Add(S12);
            alergenyWegetarianska.Add(S13);

            List<SAlergen> alergenyWeganska = new List<SAlergen>();
            alergenyWeganska.Add(S0);
            alergenyWeganska.Add(S1);
            alergenyWeganska.Add(S6);
            alergenyWeganska.Add(S8);
            alergenyWeganska.Add(S9);
            alergenyWeganska.Add(S11);
            alergenyWeganska.Add(S12);
            alergenyWeganska.Add(S13);

            List<SAlergen> alergenyBezlaktozowa = new List<SAlergen>();
            alergenyBezlaktozowa.Add(S0);
            alergenyBezlaktozowa.Add(S1);
            alergenyBezlaktozowa.Add(S3);
            alergenyBezlaktozowa.Add(S4);
            alergenyBezlaktozowa.Add(S5);
            alergenyBezlaktozowa.Add(S6);
            alergenyBezlaktozowa.Add(S8);
            alergenyBezlaktozowa.Add(S9);
            alergenyBezlaktozowa.Add(S11);
            alergenyBezlaktozowa.Add(S12);
            alergenyBezlaktozowa.Add(S13);
            alergenyBezlaktozowa.Add(S14);

            List<SAlergen> alergenyBezglutenowa = new List<SAlergen>();
            alergenyBezglutenowa.Add(S0);
            alergenyBezglutenowa.Add(S2);
            alergenyBezglutenowa.Add(S3);
            alergenyBezglutenowa.Add(S4);
            alergenyBezglutenowa.Add(S5);
            alergenyBezglutenowa.Add(S6);
            alergenyBezglutenowa.Add(S8);
            alergenyBezglutenowa.Add(S9);
            alergenyBezglutenowa.Add(S11);
            alergenyBezglutenowa.Add(S12);
            alergenyBezglutenowa.Add(S13);
            alergenyBezglutenowa.Add(S14);

            Dieta podstawowa = new Dieta(ERodzajeDiet.podstawowa, 25.0, alergenyPodstawowa);
            Dieta wegetariańska = new Dieta(ERodzajeDiet.wegetariańska, 32.50, alergenyWegetarianska);
            Dieta wegańska = new Dieta(ERodzajeDiet.wegańska, 35.00, alergenyWeganska);
            Dieta bezlaktozowa = new Dieta(ERodzajeDiet.bezlaktozowa, 36.00, alergenyBezlaktozowa);
            Dieta bezglutenowa = new Dieta(ERodzajeDiet.bezglutenowa, 37.50, alergenyBezglutenowa);

            Menu.Add(podstawowa);
            Menu.Add(wegetariańska);
            Menu.Add(wegańska);
            Menu.Add(bezlaktozowa);
            Menu.Add(bezglutenowa);
        }

        public object Clone()
        {
            MenuDieta kopia = new MenuDieta();
            kopia.menu = new List<Dieta>();

            foreach (Dieta d in menu)
            {
                kopia.menu.Add(d.Clone1());
            }

            return kopia;
        }

    }
}
