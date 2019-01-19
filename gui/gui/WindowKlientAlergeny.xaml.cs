﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Projekt;


namespace gui
{
    /// <summary>
    /// Logika interakcji dla klasy WindowKlientAlergeny.xaml
    /// </summary>
    partial class WindowKlientAlergeny : Window
    {
        Projekt.Dieta dieta = new Projekt.Dieta();
        ObservableCollection<SAlergen> lista;

        public WindowKlientAlergeny()
        {
            InitializeComponent();
            lista = new ObservableCollection<SAlergen>();

        }

        private void Button_Wstecz(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowKlientZamowienie okno = new WindowKlientZamowienie();
            okno.ShowDialog();
        }

        private void Button_Dalej(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowSzczegolyZamowienia okno = new WindowSzczegolyZamowienia();
            okno.ShowDialog();
        }
    }
}
