using CombatReports.DocumentExamplesForms.TableExamples.TypeB4;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CombatReports.TableForms.TypeB4
{
    /// <summary>
    /// Interaction logic for Form4_2.xaml
    /// </summary>
    public partial class Form4_2 : Window
    {
        public Form4_2()
        {
            InitializeComponent();
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form4_2_Example form4_2_Example = new Form4_2_Example();
            form4_2_Example.Show();
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
