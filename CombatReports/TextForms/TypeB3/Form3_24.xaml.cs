using CombatReports.BLL.Services.Interfaces;
using CombatReports.DocumentExamplesForms.TextExamples.TypeB3;
using CombatReports.ManagingWindows;
using System;
using System.IO;
using System.Windows;
using Constant = CombatReports.Constants.Constants;
using Word = Microsoft.Office.Interop.Word;

namespace CombatReports.TextForms.TypeB3
{
    /// <summary>
    /// Interaction logic for Form3_24.xaml
    /// </summary>
    public partial class Form3_24 : Window
    {
        private readonly IOrderService orderService;
        private readonly IHashService hashService;
        public Form3_24(IOrderService orderService, IHashService hashService)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.hashService = hashService;
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form3_24_Example form3_24_Example = new Form3_24_Example();
            form3_24_Example.Show();
        }

        private void GenerateDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            Word.Application objWord = new Word.Application
            {
                Visible = true
            };
            Word.Document objDoc;
            object objMissing = System.Reflection.Missing.Value;
            objDoc = objWord.Documents.Add(ref objMissing, ref objMissing, ref objMissing, ref objMissing);
            Word.Range wordRan;
            wordRan = objDoc.Range(ref objMissing, ref objMissing);

            // Форматування
            wordRan.Font.Size = 14;
            wordRan.Font.Name = "Times New Roman";
            wordRan.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            wordRan.ParagraphFormat.LineSpacing = 18;
            wordRan.ParagraphFormat.FirstLineIndent = objWord.InchesToPoints((float)0.5);
            wordRan.ParagraphFormat.SpaceAfter = 0;
            wordRan.ParagraphFormat.SpaceBefore = 0;

            // Генерація вмісту
            objWord.Selection.TypeText("В.3.24. Бойове донесення командира механізованого батальйону\n\nБОЙОВЕ ДОНЕСЕННЯ командира ");
            objWord.Selection.TypeText(textBox1.Text);
            objWord.Selection.TypeText(" мб. КСП ");
            objWord.Selection.TypeText(textBox2.Text);
            objWord.Selection.TypeText(" ");
            objWord.Selection.TypeText(textBox3.Text);
            objWord.Selection.TypeText(". Карта (масштаб) ");
            objWord.Selection.TypeText(textBox4.Text);
            objWord.Selection.TypeText(", видання ");
            objWord.Selection.TypeText(textBox5.Text);
            objWord.Selection.TypeText(" року.\nБатальйон, наступаючи в напрямку ");
            objWord.Selection.TypeText(textBox6.Text);
            objWord.Selection.TypeText(", виконав найближчу задачу і веде бій з підрозділами ");
            objWord.Selection.TypeText(textBox7.Text);
            objWord.Selection.TypeText(" мпб.\n");
            objWord.Selection.TypeText(textBox8.Text);
            objWord.Selection.TypeText(" мр веде бій на рубежі ");
            objWord.Selection.TypeText(textBox9.Text);
            objWord.Selection.TypeText(" ");
            objWord.Selection.TypeText(textBox10.Text);
            objWord.Selection.TypeText(" мр веде бій з підрозділами, що відходять, на рубежі ");
            objWord.Selection.TypeText(textBox11.Text);
            objWord.Selection.TypeText(" ");
            objWord.Selection.TypeText(textBox12.Text);
            objWord.Selection.TypeText(" мр – другий ешелон, головою колони досягла ");
            objWord.Selection.TypeText(textBox13.Text);
            objWord.Selection.TypeText(".\nВтрати в підрозділах: ");
            objWord.Selection.TypeText(textBox14.Text);
            objWord.Selection.TypeText(".\nПраворуч на рубежі ");
            objWord.Selection.TypeText(textBox15.Text);
            objWord.Selection.TypeText(" веде бій ");
            objWord.Selection.TypeText(textBox16.Text);
            objWord.Selection.TypeText(" мр ");
            objWord.Selection.TypeText(textBox17.Text);
            objWord.Selection.TypeText(" батальйону.\nЛіворуч на рубежі ");
            objWord.Selection.TypeText(textBox18.Text);
            objWord.Selection.TypeText(" мр ");
            objWord.Selection.TypeText(textBox19.Text);
            objWord.Selection.TypeText(" успішно просувається в зазначеному напрямку.\nПротивник підрозділами ");
            objWord.Selection.TypeText(textBox20.Text);
            objWord.Selection.TypeText(" чинить опір на рубежі, перед фронтом ");
            objWord.Selection.TypeText(textBox21.Text);
            objWord.Selection.TypeText(" мр, відходить, одночасно висуває резерви силою до ");
            objWord.Selection.TypeText(textBox22.Text);
            objWord.Selection.TypeText(" для проведення контратаки в напрямку ");
            objWord.Selection.TypeText(textBox23.Text);
            objWord.Selection.TypeText(".\nВирішив: ввести в бій другий ешелон з рубежу ");
            objWord.Selection.TypeText(textBox24.Text);
            objWord.Selection.TypeText(" у напрямку ");
            objWord.Selection.TypeText(textBox25.Text);
            objWord.Selection.TypeText(" із завданням знищити противника, що висувається, у зустрічному бою і продовжувати наступ в зазначеному напрямку. Час виходу на рубіж введення в бій ");
            objWord.Selection.TypeText(textBox26.Text);
            objWord.Selection.TypeText(".\nПрошу вогнем артилерії придушити артилерійську батарею в районі ");
            objWord.Selection.TypeText(textBox27.Text);
            objWord.Selection.TypeText(" і противника, що висувається.");

            try
            {
                Directory.CreateDirectory(Constant.RootToSaveGenerated);
                objDoc.SaveAs($"{Constant.RootToSaveGenerated}Form 3_24 {Constant.Date}");
                string path = objDoc.FullName;

                var dialog = new DialogPrintDocument("Підтвердити друк?");
                dialog.ShowDialog();
                if (dialog.Cancelled != true)
                {
                    objDoc.PrintOut();
                }

                objDoc.Close();
                objWord.Quit();

                var order = orderService.AddOrder(path, hashService.GetHash());
                if (order != null)
                {
                    CustomMessageBox messageBox = new CustomMessageBox("Донесення занесено до бази даних!");
                    messageBox.ShowDialog();
                }
                else
                {
                    CustomMessageBox messageBox = new CustomMessageBox("Сталася помилка! Донесення не занесено до бази даних!");
                    messageBox.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox messageBox = new CustomMessageBox(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow(orderService, hashService);
            mainWindow.Show();
        }
    }
}
