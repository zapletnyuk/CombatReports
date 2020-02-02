using CombatReports.BLL.Services.Interfaces;
using CombatReports.TableForms.TypeB3;
using CombatReports.TableForms.TypeB4;
using CombatReports.TextForms.TypeB3;
using CombatReports.TextForms.TypeB4;
using CombatReports.TextForms.TypeB8;
using System.Windows;
using System.Windows.Controls;

namespace CombatReports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IOrderService orderService;
        public MainWindow(IOrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
        }

        private void TextDocumentsTypeB3ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (TextDocumentsTypeB3ComboBox.SelectedIndex)
            {
                case 0:
                    this.Hide();
                    Form3_10 form3_10 = new Form3_10(orderService);
                    form3_10.Show();
                    return;
                case 1:
                    this.Hide();
                    Form3_24 form3_24 = new Form3_24(orderService);
                    form3_24.Show();
                    return;
            }
        }

        private void TextDocumentsTypeB4ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (TextDocumentsTypeB4ComboBox.SelectedIndex)
            {
                case 0:
                    this.Hide();
                    Form4_6 form4_6 = new Form4_6(orderService);
                    form4_6.Show();
                    break;
            }
        }

        private void TextDocumentsTypeB8ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (TextDocumentsTypeB8ComboBox.SelectedIndex)
            {
                case 0:
                    this.Hide();
                    Form8_1 form8_1 = new Form8_1(orderService);
                    form8_1.Show();
                    break;
                case 1:
                    this.Hide();
                    Form8_2 form8_2 = new Form8_2(orderService);
                    form8_2.Show();
                    break;
            }
        }

        private void TableDocumentsTypeB3ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (TableDocumentsTypeB3ComboBox.SelectedIndex)
            {
                case 0:
                    this.Hide();
                    Form3_2 form3_2 = new Form3_2(orderService);
                    form3_2.Show();
                    break;
                case 1:
                    this.Hide();
                    Form3_3 form3_3 = new Form3_3(orderService);
                    form3_3.Show();
                    break;
                case 2:
                    this.Hide();
                    Form3_4 form3_4 = new Form3_4(orderService);
                    form3_4.Show();
                    break;
            }
        }

        private void TableDocumentsTypeB4ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (TableDocumentsTypeB4ComboBox.SelectedIndex)
            {
                case 0:
                    this.Hide();
                    Form4_1 form4_1 = new Form4_1(orderService);
                    form4_1.Show();
                    break;
                case 1:
                    this.Hide();
                    Form4_2 form4_2 = new Form4_2(orderService);
                    form4_2.Show();
                    break;
            }
        }
    }
}
