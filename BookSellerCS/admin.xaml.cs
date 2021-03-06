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
using BookSellerCS.BookSellerService;


namespace BookSellerCS
{
    /// <summary>
    /// Logique d'interaction pour admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        BookSellerService.Book SelectedBook = null;
        public admin()
        {
            InitializeComponent();
            BookSellerServiceClient b = new BookSellerServiceClient();

            listeLivres.ItemsSource = b.getAllBooks();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ListView lv = (ListView)sender;
            SelectedBook = (BookSellerService.Book)lv.SelectedItem; 
            detailLivreAdmin d = new detailLivreAdmin(SelectedBook);
            d.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            create c = new create();
            c.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
