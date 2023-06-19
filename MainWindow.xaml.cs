using System.Windows;
using System.Text.RegularExpressions;


namespace WebApp
{
    public partial class MainWindow : Window
    {
        private static string urlPattern = "^(http|https)://[-a-zA-Z0-9+&@#/%?=~_|!:,.;]*[-a-zA-Z0-9+&@#/%=~_|]";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(addressBar.Text, urlPattern))
            {
                webView.CoreWebView2.Navigate(addressBar.Text);
            } else {
                MessageBox.Show("Вы ввели некроектный url, попробуйте ещё раз!");
            }
        }
    }
}
