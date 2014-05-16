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
using System.Windows.Shapes;

namespace BookSellerCS
{
    /// <summary>
    /// Logique d'interaction pour Panier.xaml
    /// </summary>
    public partial class Panier : Window
    {

        private BookSellerService.Book selectedBook = null;
        private List<BookSellerService.Book> panierBooks = new List<BookSellerService.Book>();
        List<BookSellerService.Book> listeBook = null;
        public Panier(List<BookSellerService.Book> b)
        {
            double prix = 0;
            listeBook = b;
            InitializeComponent();
            foreach (BookSellerService.Book book in b)
            {
                prix = prix + book.Price;
            }
            listeLivres.ItemsSource = listeBook;
            HT.Text = "" + prix;
            TTC.Text = "" + prix * 1.055;


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Commander(object sender, RoutedEventArgs e)
        {
            commande c = new commande();
            c.Show();
            this.Close();
        }

        private void listeLivres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lv = (ListView)sender;
            selectedBook = (BookSellerService.Book) lv.SelectedItem;
            detailLivrePanier d = new detailLivrePanier(null, selectedBook);
            d.Show();
        } 
    }
}
