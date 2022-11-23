using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace GLOBAL2
{
    /// <summary>
    /// Логика взаимодействия для SIZ.xaml
    /// </summary>
    public partial class SIZ : Page
    {
        public SIZ()
        {
            InitializeComponent();
        }

        private void Roboflow_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://olgachubova205.github.io/Kaski/"); //открытие ссылки в браузере 
        }
    }
}
