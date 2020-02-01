using CombatReports.DocumentExamplesForms.TableExamples.TypeB3;
using System.Windows;

namespace CombatReports.TableForms.TypeB3
{
    /// <summary>
    /// Interaction logic for Form3_4.xaml
    /// </summary>
    public partial class Form3_4 : Window
    {
        public Form3_4()
        {
            InitializeComponent();
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form3_4_Example form3_4_Example = new Form3_4_Example();
            form3_4_Example.Show();
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
