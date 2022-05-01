using System;
using System.Windows;
using Constant = CombatReports.Constants.Constants;

namespace CombatReports.DialogWindows
{
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
            get { return InputTextBox.Password; }
            set { InputTextBox.Password = value; }
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(InputText))
            {
                Close();
            }
            else
            {
                CustomMessageBox messageBox = new CustomMessageBox(Constant.EnterHashMessage);
                messageBox.ShowDialog();
            }
        }
    }
}