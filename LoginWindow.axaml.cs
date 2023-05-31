using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaProject
{
    public partial class LoginWindow : Window
    {
        private TextBox _txtUsername;
        private TextBox _txtPassword;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            _txtUsername = this.FindControl<TextBox>("txtUsername");
            _txtPassword = this.FindControl<TextBox>("txtPassword");
        }

        private void OnLoginButtonClicked(object sender, RoutedEventArgs e)
        {
            string username = _txtUsername.Text;
            string password = _txtPassword.Text;

            bool isLoginValid = ValidateLogin(username, password);

            if (isLoginValid)
            {
                Hide();
                MainPage mainWindow = new MainPage();
                mainWindow.Show();
            }
            else
            {
                // Login failed - show error message
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            return (username == "admin" && password == "password");
        }
    }
}