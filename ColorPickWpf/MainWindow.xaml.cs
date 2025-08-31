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

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            // Example: Draw a point at (120, 120) with a radius of 6
            double x = 120;
            double y = 120;
            double radius = 6;

            Ellipse point = new Ellipse
            {
                Width = radius * 2,
                Height = radius * 2,
                Fill = btnPickColor.Background // Use the button's background color
            };

            // Center the ellipse at (x, y)
            Canvas.SetLeft(point, x - radius);
            Canvas.SetTop(point, y - radius);

            drawCanvas.Children.Add(point);
        }
    }
}