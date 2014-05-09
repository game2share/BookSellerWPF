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
    /// Logique d'interaction pour authentification.xaml
    /// </summary>
    public partial class authentification : Window
    {
        public authentification()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(pwd.Password);

            if (pwd.Password.Equals("test")){
                // lancement de la fenêtre d'administration
                admin a = new admin();
                a.Show();
                this.Close();
            }else{
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
        }
    }
}
