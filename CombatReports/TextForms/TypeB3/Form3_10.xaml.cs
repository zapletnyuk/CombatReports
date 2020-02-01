using CombatReports.DocumentExamplesForms.TextExamples.TypeB3;
using System.Windows;

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

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form3_10_Example form3_10_Example = new Form3_10_Example();
            form3_10_Example.Show();
        }

        private void GenerateDocumentButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
