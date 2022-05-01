using System.Windows;

namespace CombatReports.DialogWindows
{
    public partial class DialogPrintDocument : Window
    {
        public DialogPrintDocument()
        {
            InitializeComponent();
        }

        public DialogPrintDocument(string title)
        {
            InitializeComponent();
            TitleText = title;
        }

        public string TitleText
        {
            get { return TitleTextBox.Text; }
            set { TitleTextBox.Text = value; }
        }

        public bool Cancelled { get; set; } = true;

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            Cancelled = false;
            Close();
        }
    }
}