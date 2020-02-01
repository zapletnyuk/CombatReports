using CombatReports.DocumentExamplesForms.TableExamples.TypeB4;
using System.Windows;

namespace CombatReports.TableForms.TypeB4
{
    /// <summary>
    /// Interaction logic for Form4_1.xaml
    /// </summary>
    public partial class Form4_1 : Window
    {
        public Form4_1()
        {
            InitializeComponent();
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form4_1_Example form4_1_Example = new Form4_1_Example();
            form4_1_Example.Show();
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
