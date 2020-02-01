using CombatReports.DocumentExamplesForms.TextExamples.TypeB4;
using System.Windows;

namespace CombatReports.TextForms.TypeB4
{
    /// <summary>
    /// Interaction logic for Form4_6.xaml
    /// </summary>
    public partial class Form4_6 : Window
    {
        public Form4_6()
        {
            InitializeComponent();
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form4_6_Example form4_6_Example = new Form4_6_Example();
            form4_6_Example.Show();
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
