using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace yourFirstName_yourLastName
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myListBox.Items.Add(text_box);
            myListBox.Items.Clear();

        }

        private void numberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (var child in stackPanel.Children)
            {
                if (child is TextBox textBox)
                {
                    myListBox.Items.Add(textBox.Text);
                }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myListBox.SelectedItem is ListBoxItem listBoxItem)
            {
                text_box.Text = listBoxItem.Content.ToString();
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            text_box.Text = slider1.Value.ToString("0");
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            text_box.Text = slider2.Value.ToString("0");
        }
    }
}