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

namespace BookSellerCS
{
    /// <summary>
    /// Logique d'interaction pour auteur.xaml
    /// </summary>
    public partial class auteur : Window
    {
        public auteur()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // TODO send entered data to MainWindow
            this.Close();
        }
    }
}