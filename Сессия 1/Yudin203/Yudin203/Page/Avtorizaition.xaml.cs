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
    /// Логика взаимодействия для Avtorizaition.xaml
    /// </summary>
    public partial class Avtorizaition : Page
    {
        public Avtorizaition()
        {
            InitializeComponent();

        }
        private void btnVhod_Click(object sender, RoutedEventArgs e)
        {
           try
            {
                var UserObj = Bd_YudinEntities2.GetContext().Users.FirstOrDefault(x => x.Login &&)
                if (UserObj == null)                
            }
        }
    }
}
