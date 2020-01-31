using CombatReports.TextForms.TypeB3;
using CombatReports.TextForms.TypeB4;
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
                Form3_10 form3_10 = new Form3_10();
                form3_10.Show();
            }
            if (TextDocumentsTypeB3ComboBox.SelectedIndex == 1)
            {
                this.Hide();
                Form3_24 form3_24 = new Form3_24();
                form3_24.Show();
            }
        }

        private void TextDocumentsTypeB4ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TextDocumentsTypeB4ComboBox.SelectedIndex == 0)
            {
                this.Hide();
                Form4_6 form4_6 = new Form4_6();
                form4_6.Show();
            }
        }
    }
}
