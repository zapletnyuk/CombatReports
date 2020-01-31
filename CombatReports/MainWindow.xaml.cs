using CombatReports.TextForms.TypeB3;
using System.Windows;
using System.Windows.Controls;

namespace CombatReports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextDocumentsTypeB3ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TextDocumentsTypeB3ComboBox.SelectedIndex == 0)
            {
                this.Hide();
                Form3_10 form_310 = new Form3_10();
                form_310.Show();
            }
        }
    }
}
