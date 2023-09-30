using System;
using System.Collections.Generic;
using System.Data.Common;
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
using test.DB;


namespace test.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        public static List<Client> clients { get; set; }
        public MainMenuPage()
        {
            InitializeComponent();
            clients = new List<Client>(DbConnection1.parik_PM_AkEntities.Client.ToList());
            this.DataContext = this;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var dcvh = FirtsNameTb.Text + " " + PhoneTb.Text;
            if (MessageBox.Show(dcvh, " Проверьте корректность введеных данных", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                Client clients = new Client();
                clients.FirstName = FirtsNameTb.Text;

               
                clients.telepnone = PhoneTb.Text;
                DbConnection1.parik_PM_AkEntities.Client.Add(clients);
                DbConnection1.parik_PM_AkEntities.SaveChanges();

                ClientsLv.ItemsSource = new List<Client>(DbConnection1.parik_PM_AkEntities.Client.ToList());
            }

        }

        private void ClientsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Client clients = ClientsLv.SelectedItem as Client;
            NavigationService.Navigate(new Sign_For_Services());
        }

    }
}