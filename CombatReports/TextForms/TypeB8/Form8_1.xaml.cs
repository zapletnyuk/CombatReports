using CombatReports.DocumentExamplesForms.TextExamples.TypeB8;
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

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
