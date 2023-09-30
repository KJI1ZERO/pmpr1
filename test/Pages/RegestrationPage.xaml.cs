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
    /// Логика взаимодействия для RegestrationPage.xaml
    /// </summary>
    public partial class RegestrationPage : Page
    {
        public static List<Doljnost> doljnosts { get; set; }
        public object NameTb { get; private set; }

        public RegestrationPage()
        {
            InitializeComponent();
            Doljnost doljnost = new Doljnost();
            doljnosts = new List<Doljnost>(DbConnection1.parik_PM_AkEntities.Doljnost.ToList());
            this.DataContext = this;
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            Rabotnik Rabotnik = new Rabotnik();
            if (SurnameTb.Text.Trim() != "")
                Rabotnik.Name_rab = SurnameTb.Text.Trim();
            else
                MessageBox.Show("Введите ФИО!!!");
            if (LoginTb.Text.Trim() != "")
                Rabotnik.Login = LoginTb.Text.Trim();
            else MessageBox.Show("Введите логин");
            if (PasswordPb.Password.Trim() != null)
                Rabotnik.Password = PasswordPb.Password.Trim();
            else MessageBox.Show("Введите пароль");
            if (DoljnostCb.SelectedItem != null)
                Rabotnik.Doljnost = DoljnostCb.SelectedItem as Doljnost;
            else
            {
                MessageBox.Show("Выберите должность");
            }

            if (SurnameTb.Text.Trim() != "" && SurnameTb.Text.Trim() != "" && LoginTb.Text.Trim() != "" && PasswordPb.Password.Trim() != null && DoljnostCb.SelectedItem != null)
            {
                DbConnection1.parik_PM_AkEntities.Rabotnik.Add(Rabotnik);
                DbConnection1.parik_PM_AkEntities.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно теперь выполните вход");
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Вы не ввели всю требуемую информацию");
            }



        }
    }
}