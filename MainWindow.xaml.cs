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

namespace Them
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetTheme("Light");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == buttonLight)
                SetTheme("Light");
            else if (sender == buttonDark)
                SetTheme("Dark");
        }

        private void SetTheme(string themeName)
        {
            Uri uri = new Uri($"Thems/{themeName}Theme.xaml", UriKind.RelativeOrAbsolute);
            ResourceDictionary resourceDict = (ResourceDictionary)Application.LoadComponent(uri);
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
    }
}
