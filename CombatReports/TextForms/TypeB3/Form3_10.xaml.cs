using System.Windows;
using CombatReports.DocumentExamplesForms.TextExamples.TypeB3;

namespace CombatReports.TextForms.TypeB3
{
    /// <summary>
    /// Interaction logic for Form3_10.xaml
    /// </summary>
    public partial class Form3_10 : Window
    {
        public Form3_10()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form3_10_Example form3_10_Example = new Form3_10_Example();
            form3_10_Example.Show();
        }
    }
}
