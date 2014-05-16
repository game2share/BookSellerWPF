using BookSellerCS.BookSellerService;
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
    /// Logique d'interaction pour commande.xaml
    /// </summary>
    public partial class commande : Window
    {
        private List<BookSellerService.Book> books = null;
        private BookSellerServiceClient client = new BookSellerServiceClient();

        public commande(List<BookSellerService.Book> books)
        {
            this.books = books;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(BookSellerService.Book book in books)
            {
                client.takeBooks(book.Id, book.Stock);
            }
            this.Close();
        }
    }
}
