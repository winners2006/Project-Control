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
    /// Логика взаимодействия для RegForm.xaml
    /// </summary>
    public partial class RegForm : Window
    {
        AppContext db;

        public RegForm()
        {
            InitializeComponent();
            db = new AppContext();
        }

        private void Button_Enter_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            string fio = textBoxFIO.Text.ToUpper().Trim();
            string level = levelBox.Text.Trim();
            string login = textBoxLogin.Text.Trim();
            string pass = textBoxPass.Password.Trim();
            string pass2 = textBoxPass2.Password.Trim();
            string email = textBoxEmailn.Text.ToLower().Trim();

            if (login.Length < 3)
            {
                textBoxLogin.ToolTip = "Введите не мение 3-х символов";
                textBoxLogin.Background = Brushes.Red;
            }
            else if (fio.Length < 6)
            {
                textBoxFIO.ToolTip = "Введите не мение 6-u символов";
                textBoxFIO.Background = Brushes.Red;
            }
            else if (pass.Length < 6)
            {
                textBoxPass.ToolTip = "Введите не мение 6-u символов";
                textBoxPass.Background = Brushes.Red;
            }
            else if (pass != pass2)
            {
                textBoxPass2.ToolTip = "пароли не совпадают";
                textBoxPass2.Background = Brushes.Red;
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                textBoxEmailn.ToolTip = "Введите корректный E-mail";
                textBoxEmailn.Background = Brushes.Red;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                textBoxFIO.ToolTip = "";
                textBoxFIO.Background = Brushes.Transparent;
                textBoxPass.ToolTip = "";
                textBoxPass.Background = Brushes.Transparent;
                textBoxPass2.ToolTip = "";
                textBoxPass2.Background = Brushes.Transparent;
                textBoxEmailn.ToolTip = "";
                textBoxEmailn.Background = Brushes.Transparent;

                MessageBox.Show("Вы успешно зарегестрированы в системе!");
                User user = new User(login, pass, email, fio, level);
                db.Users.Add(user);
                db.SaveChanges();
                Login login1 = new Login();
                login1.Show();
                Hide();
            }
        }
    }
}
