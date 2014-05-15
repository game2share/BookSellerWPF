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
    /// Logique d'interaction pour detailLivreAdmin.xaml
    /// </summary>
    public partial class detailLivreAdmin : Window
    {
        private BookSellerService.Book b = null;
        public detailLivreAdmin(BookSellerService.Book b)
        {
            InitializeComponent();
            this.b = b;
            title.Text = b.Title;
            author.Text = b.Author;
            id.Text = b.Id;
            price.Text = "" + b.Price;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
      
            this.Close();
        }
    }
}
