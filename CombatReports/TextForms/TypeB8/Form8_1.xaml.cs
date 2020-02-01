using CombatReports.DocumentExamplesForms.TextExamples.TypeB8;
using System.Windows;

namespace CombatReports.TextForms.TypeB8
{
    /// <summary>
    /// Interaction logic for Form8_1.xaml
    /// </summary>
    public partial class Form8_1 : Window
    {
        public Form8_1()
        {
            InitializeComponent();
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form8_1_Example form8_1_Example = new Form8_1_Example();
            form8_1_Example.Show();
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
