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
using Yudin203.ApplicationData;

namespace Yudin203.Page
{
    /// <summary>
    /// Логика взаимодействия для Tovar.xaml
    /// </summary>
    public partial class Tovar : Page
    {
        public Tovar()
        {
            InitializeComponent();
            DGridTovar.ItemsSource = Bd_YudinEntities2.GetContext().Tovar.ToList();
        }

        private void DGridTovar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
