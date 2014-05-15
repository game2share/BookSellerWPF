using System;
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
        public MainWindow()
        {
            
            InitializeComponent();
            BookSellerServiceClient b = new BookSellerServiceClient();
            
            listeLivres.ItemsSource=b.getAllBooks();

        
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
            auteur a = new auteur();
            a.Show();
        }

        private void SendType(object sender, RoutedEventArgs e)
        {
            type t = new type();
            t.Show();
        }

        private void ISBN(object sender, RoutedEventArgs e)
        {
            this.Show();  
  
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lv = (ListView)sender;
            selectedBook = (BookSellerService.Book) lv.SelectedItem;
            detailLivre d = new detailLivre(this, selectedBook);
            d.Show();
        }

        public void AjoutPanier()
        {
            if(selectedBook != null)
                panierBooks.Add(selectedBook);
        }
    }
}
