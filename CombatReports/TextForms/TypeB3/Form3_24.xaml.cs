using CombatReports.DocumentExamplesForms.TextExamples.TypeB3;
using System.Windows;

namespace CombatReports.TextForms.TypeB3
{
    /// <summary>
    /// Interaction logic for Form3_24.xaml
    /// </summary>
    public partial class Form3_24 : Window
    {
        public Form3_24()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form3_24_Example form3_24_Example = new Form3_24_Example();
            form3_24_Example.Show();
        }
    }
}
