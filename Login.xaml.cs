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

namespace Project_Control
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public static int idUser;
        public static string fioUser;
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            Hide();
        }

        private void authButton_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = textBoxPass.Password.Trim();

            if (login.Length < 3)
            {
                textBoxLogin.ToolTip = "Введите не мение 3-х символов";
                textBoxLogin.Background = Brushes.Red;
            }
            else if (pass.Length < 6)
            {
                textBoxPass.ToolTip = "Введите не мение 6-u символов";
                textBoxPass.Background = Brushes.Red;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                textBoxPass.ToolTip = "";
                textBoxPass.Background = Brushes.Transparent;

                User authUser = null;
                using (AppContext context = new AppContext())
                {
                    authUser = context.Users.Where(b => b.Login == login && b.Pass == pass).FirstOrDefault();
                }
                if (authUser != null && authUser.Level == "Администратор")
                {
                    authUser.id = idUser;
                    authUser.FIO = fioUser;
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Hide();
                }
                else if(authUser != null && authUser.Level == "Исполнитель")
                {
                    authUser.id = idUser;
                    authUser.FIO = fioUser;
                    WorkWindow workWindow = new WorkWindow();
                    workWindow.Show();
                    Hide();
                }
                else MessageBox.Show("Логин или пароль не верны!");
            }
        }
    }
}
