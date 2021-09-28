using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Логика взаимодействия для CreatProject.xaml
    /// </summary>
    public partial class CreatProject : Window
    {
        AppContext db;
        public CreatProject()
        {
            InitializeComponent();
            db = new AppContext();
            List<User> users = db.Users.ToList();
            userWork.ItemsSource = users;
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            string namePrj = nameProject.Text.Trim();
            string descPrj = descProject.Text.Trim();
            string namePrjBay = nameProjectBay.Text.Trim();
            string dataPrjStart = dataStart.Text.Trim();
            string dataPrjStop = dataStop.Text.Trim();
            string userPrjWork = userWork.Text.Trim();
            int ammountPrj = Convert.ToInt32(ammountProject.Text.Trim());

            if(namePrj.Length < 3)
            {
                nameProject.ToolTip = "Введите не мение 3-х символов";
                nameProject.Background = Brushes.Red;
            }
            else if (descPrj.Length < 25)
            {
                descProject.ToolTip = "Введите не мение 25-и символов";
                descProject.Background = Brushes.Red;
            }
            else
            {
                nameProject.ToolTip = "";
                nameProject.Background = Brushes.Transparent;
                descProject.ToolTip = "";
                descProject.Background = Brushes.Transparent;
            }

            Project project = new Project(namePrj, descPrj, namePrjBay, dataPrjStart, dataPrjStop, userPrjWork, ammountPrj);
            db.Projects.Add(project);
            db.SaveChanges();
            MessageBox.Show("Проект сохранен!");
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
