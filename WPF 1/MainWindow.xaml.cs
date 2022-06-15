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

namespace WPF_1
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

        public void Button_click_event_settings(Button button)
        {
            Random r = new Random();

            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            button.Background = brush;
            MessageBox.Show(button.Content + " Number button's color changed ");
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        { 
            Button_click_event_settings(button_1);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button_click_event_settings(button_2);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button_click_event_settings(button_3);
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Button_click_event_settings(button_4);
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Button_click_event_settings(button_5);
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Button_click_event_settings(button_6);
        }


        public void Button_remove_proses(Button button,int n1,int n2)
        {
            Label new_label = new Label();
            new_label.Content = $"{button.Content}";
            new_label.FontSize = 50;
            new_label.HorizontalContentAlignment = HorizontalAlignment.Center;
            new_label.VerticalContentAlignment = VerticalAlignment.Center;
            new_label.Foreground = Brushes.Red;
            new_label.Background = Brushes.Black;

            new_label.Height = button.Height;
            new_label.Width = button.Width;
            new_label.Margin = button.Margin;
            Grid.SetRow(new_label, n1);
            Grid.SetColumn(new_label, n2);

            myGrid.Children.Remove(button);
            myGrid.Children.Add(new_label);
            
           
        }
        private void button_1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_remove_proses(button_1,0,0);
        }
        private void button_2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_remove_proses(button_2,0,1);
        }
        private void button_3_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_remove_proses(button_3,0,2);
        }
        private void button_4_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_remove_proses(button_4,1,0);
        }
        private void button_5_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_remove_proses(button_5,1,1);
        }
        private void button_6_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_remove_proses(button_6,1,2);
        }
    }
}
