using System;
using System.Windows;

namespace CombatReports.ManagingWindows
{
    /// <summary>
    /// Interaction logic for DialogHashInput.xaml
    /// </summary>
    public partial class DialogHashInput : Window
    {
        public DialogHashInput()
        {
            InitializeComponent();
        }

        public DialogHashInput(string title, string input)
        {
            InitializeComponent();
            TitleText = title;
            InputText = input;
        }

        public string TitleText
        {
            get { return TitleTextBox.Text; }
            set { TitleTextBox.Text = value; }
        }

        public string InputText
        {
            get { return InputTextBox.Text; }
            set { InputTextBox.Text = value; }
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(InputText))
            {
                this.Close();
            }
            else
            {
                CustomMessageBox messageBox = new CustomMessageBox("Необхідно ввести хеш.");
                messageBox.ShowDialog();
            }
        }
    }
}
