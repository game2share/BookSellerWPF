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
    /// Logique d'interaction pour detailLivre.xaml
    /// </summary>
    public partial class detailLivrePanier : Window
    {

        private MainWindow main = null;
        private BookSellerService.Book b = null;
        public detailLivrePanier(MainWindow main, BookSellerService.Book b) 
        {
            this.b = b;
            this.main = main;
            InitializeComponent();
            title.Text = b.Title;
            author.Text = b.Author;
            id.Text = b.Id;
            price.Text = ""+b.Price;
            //stock.Text = b
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
