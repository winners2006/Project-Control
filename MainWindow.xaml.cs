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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;

namespace Project_Control
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContext db;
        public int id_User = Login.idUser;
       
        
        public MainWindow()
        {
            InitializeComponent();

            db = new AppContext();
            List<Project> projects = db.Projects.ToList();
            listPrj.ItemsSource = projects;
            User authUser = null;
            using (AppContext context = new AppContext())
            {
                authUser = context.Users.Where(b => b.id == id_User).FirstOrDefault();
            }
            if (authUser != null) userName.Text = Convert.ToString(authUser.FIO);
/*
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source=Project.db"));
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT 'FOI' FROM Users WHERE id=" + id_User, connection);
            SQLiteDataReader reader = command.ExecuteReader();*/
                /*foreach(IDataRecord record in reader)
                {
                    string fioUser = record["FIO"].ToString();
                    userName.Text = fioUser;
                }*//*
            userName.Text = Convert.ToString(reader);
            *//*connection.Close();*/
        }

        private void Button_Click_New_Project(object sender, RoutedEventArgs e)
        {
            CreatProject creatProject = new CreatProject();
            creatProject.Show();
            Hide();
        }

        private void listPrj_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ProjectInfo projectInfo = new ProjectInfo();
            projectInfo.Show();
        }
    }
}
