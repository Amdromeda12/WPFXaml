using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Exam2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int number = 1;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button testButton = new Button
            {
                Content = "Button " + number,
                Background = Brushes.Aqua,
                Foreground = Brushes.Black,
                Height = 20,
            };
            testButton.Click += CreatedButtonClick;

            smallButtonContainer.Children.Add(testButton);
            number++;
        }

        private void CreatedButtonClick(object sender, RoutedEventArgs e)
        {
            var smallbutton = sender as Button;
            smallButtonContainer.Children.Remove(smallbutton);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rotateTransform1.Angle += 45;
            rotateTransform2.Angle -= 45;
        }
    }
}