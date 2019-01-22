﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Logika interakcji dla klasy WindowPracownikKoniec.xaml
    /// </summary>
    public partial class WindowPracownikKoniec : Window
    {
        public WindowPracownikKoniec(Pracownik wybrany, int indeks)
        {
            InitializeComponent();

            texbox_data.Text = indeks.ToString();

        }

        private void Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowListaPracownikow okno = new WindowListaPracownikow();
            okno.ShowDialog();
        }

        private void listbox_zamowienia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void texbox_data_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}