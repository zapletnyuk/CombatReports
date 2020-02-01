using CombatReports.DocumentExamplesForms.TableExamples.TypeB3;
using System.Windows;

namespace CombatReports.TableForms.TypeB3
{
    /// <summary>
    /// Interaction logic for Form3_3.xaml
    /// </summary>
    public partial class Form3_3 : Window
    {
        public Form3_3()
        {
            InitializeComponent();
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form3_3_Example form3_3_Example = new Form3_3_Example();
            form3_3_Example.Show();
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
