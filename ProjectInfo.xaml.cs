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
    /// Логика взаимодействия для ProjectInfo.xaml
    /// </summary>
    public partial class ProjectInfo : Window
    {
        public ProjectInfo()
        {
            InitializeComponent();
            AppContext db = new AppContext();
            List<Project> projects = db.Projects.ToList();
            
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {

        }
    }
}
