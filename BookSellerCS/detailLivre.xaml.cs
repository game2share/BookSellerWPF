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
    public partial class detailLivre : Window
    {

        private MainWindow main = null;
        private BookSellerService.Book b = null;
        public detailLivre(MainWindow main, BookSellerService.Book b) 
        {
            this.b = b;
            this.main = main;
            InitializeComponent();
            title.Text = b.Title;
            author.Text = b.Author;
            id.Text = b.Id;
            price.Text = ""+b.Price;
            stock.Text = "" + b.Stock;
            if (b.Stock == 0)
            {
                addP.IsEnabled = false;
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            this.Close();
        }

        private void Ajout_Panier(object sender, RoutedEventArgs e){

            int nb = int.Parse(nbSelected.Text);
            main.AjoutPanier(nb);

        }
    }
}
