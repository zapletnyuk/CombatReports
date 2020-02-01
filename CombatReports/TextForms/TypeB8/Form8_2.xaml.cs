using CombatReports.DocumentExamplesForms.TextExamples.TypeB8;
using System.Windows;

namespace CombatReports.TextForms.TypeB8
{
    /// <summary>
    /// Interaction logic for Form8_2.xaml
    /// </summary>
    public partial class Form8_2 : Window
    {
        public Form8_2()
        {
            InitializeComponent();
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form8_2_Example form8_2_Example = new Form8_2_Example();
            form8_2_Example.Show();
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
