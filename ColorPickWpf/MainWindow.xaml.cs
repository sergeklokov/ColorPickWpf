using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace ColorPickWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (e.NewValue.HasValue)
            {
                btnPickColor.Background = new SolidColorBrush(e.NewValue.Value);
                colorPicker.Visibility = Visibility.Collapsed; // Hide after selection
            }
        }

        private void btnPickColor_Click(object sender, RoutedEventArgs e)
        {
            colorPicker.Visibility = Visibility.Visible;
            colorPicker.IsOpen = true; // Open the dropdown immediately
            colorPicker.Focus();
        }
    }
}