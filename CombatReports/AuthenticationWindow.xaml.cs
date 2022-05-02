using CombatReports.Business.Services.Interfaces;
using CombatReports.DialogWindows;
using System.Windows;
using Constant = CombatReports.Constants.Constants;

namespace CombatReports
{
    public partial class AuthenticationWindow : Window
    {
        private readonly IOrderService orderService;
        private readonly IHashService hashService;
        private readonly IUserService userService;

        public AuthenticationWindow(IOrderService orderService, IHashService hashService, IUserService userService)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.hashService = hashService;
            this.userService = userService;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserNameField.Text != null && UserNameField.Text != "" && PasswordField.Password != null && PasswordField.Password != "")
            {
                var userProfile = userService.GetUserByCredentials(UserNameField.Text, PasswordField.Password);

                if (userProfile != null)
                {
                    MainWindow mainWindow = new MainWindow(orderService, hashService, userService, userProfile);
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    CustomMessageBox messageBox = new CustomMessageBox(Constant.WrongAuthorizationInfo);
                    messageBox.ShowDialog();
                }
            }
            else
            {
                CustomMessageBox messageBox = new CustomMessageBox(Constant.EnterAuthorizationInfo);
                messageBox.ShowDialog();
            }
        }
    }
}