﻿using System;
using System.Collections.Generic;
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

namespace gui
{
    /// <summary>
    /// Logika interakcji dla klasy WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        public WindowLogin()
        {
            InitializeComponent();
        }

        private void Zaloguj(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowListaPracownikow okno = new WindowListaPracownikow();
            okno.ShowDialog();
        }

        private void Powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
