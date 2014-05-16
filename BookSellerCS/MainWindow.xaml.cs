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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookSellerCS.BookSellerService;

namespace BookSellerCS
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookSellerService.Book selectedBook = null;
        private List<BookSellerService.Book> panierBooks = new List<Book>();
        private BookSellerServiceClient client = new BookSellerServiceClient();
        public MainWindow()
        {
            
            InitializeComponent();
            
            listeLivres.ItemsSource=client.getAllBooks();

        
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Panier p = new Panier(panierBooks);
            p.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            authentification a = new authentification();
            a.Show();
            

        }

        private void SendAuteur(object sender, RoutedEventArgs e)
        {
            List<BookSellerService.Book> list = new List<BookSellerService.Book>();
            String id = authorN.Text;
            if (id == null || id == "")
                listeLivres.ItemsSource = client.getAllBooks();
            else
            {
                list = client.getBooksByAuthor(id).ToList();
                listeLivres.ItemsSource = list;
            }

            Btype.Text = "";
            tbISBN.Text = "";
        }

        private void SendType(object sender, RoutedEventArgs e)
        {
            List<BookSellerService.Book> list = new List<BookSellerService.Book>();
            String id =Btype.Text;
            if (id == null || id == "")
                listeLivres.ItemsSource = client.getAllBooks();
            else
            {
                list = client.getBookByGenre(id).ToList();
                listeLivres.ItemsSource = list;
            }

            authorN.Text = "";
            tbISBN.Text = "";
        }

        private void ISBN(object sender, RoutedEventArgs e)
        {
            List<BookSellerService.Book> list = new List<BookSellerService.Book>();
            String id = tbISBN.Text;
            if(id == null || id == "")
                listeLivres.ItemsSource = client.getAllBooks();
            else
            {
                list.Add(client.getBookById(id));
                listeLivres.ItemsSource = list;
            }

            authorN.Text = "";
            Btype.Text = "";
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lv = (ListView)sender;
            selectedBook = (BookSellerService.Book) lv.SelectedItem;

            if(selectedBook != null)
            {
                detailLivre d = new detailLivre(this, selectedBook);
                d.Show();
            }
        }

        public void AjoutPanier(int nb)
        {
            if (selectedBook != null)
            {
                bool found = false;
                foreach(BookSellerService.Book book in panierBooks)
                {
                    if (book.Id == selectedBook.Id)
                    {
                        found = true;

                        book.Stock += nb;
                    }
                }

                if(!found)
                {
                    BookSellerService.Book b = new BookSellerService.Book();
                    b.Id = selectedBook.Id;
                    b.Author = selectedBook.Author;
                    b.Title = selectedBook.Title;
                    b.Price = selectedBook.Price;
                    b.Genre = selectedBook.Genre;
                    b.Stock = nb;
                    panierBooks.Add(b);
                }
            }
        }

    }
}
