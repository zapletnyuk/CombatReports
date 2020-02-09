﻿using System.Windows;

namespace CombatReports.ManagingWindows
{
    /// <summary>
    /// Interaction logic for CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        public CustomMessageBox(string title)
        {
            InitializeComponent();
            TitleText = title;
        }

        public string TitleText
        {
            get { return TitleTextBox.Text; }
            set { TitleTextBox.Text = value; }
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
