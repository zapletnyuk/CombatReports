using CombatReports.Business.Services.Interfaces;
using CombatReports.OrdersExamples.TextExamples.TypeB8;
using CombatReports.DialogWindows;
using System;
using System.IO;
using System.Windows;
using Constant = CombatReports.Constants.Constants;
using Word = Microsoft.Office.Interop.Word;
using CombatReports.Helpers;

namespace CombatReports.TextOrders.TypeB8
{
    public partial class Order8_2 : Window
    {
        private readonly IOrderService orderService;
        private readonly UserProfile userProfile;

        public Order8_2(IOrderService orderService, UserProfile userProfile)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.userProfile = userProfile;
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Order8_2_Example form8_2_Example = new Order8_2_Example();
            form8_2_Example.Show();
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
            wordRan.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            wordRan.ParagraphFormat.LineSpacing = 18;
            wordRan.Font.Name = "Times New Roman";
            wordRan.ParagraphFormat.FirstLineIndent = objWord.InchesToPoints((float)0.0);
            wordRan.ParagraphFormat.SpaceAfter = 0;
            wordRan.ParagraphFormat.SpaceBefore = 0;

            // Генерація вмісту
            objWord.Selection.TypeText("В.8.2. Бойовий наказ командира розвідувального взводу на проведення пошуку\n\n1. Орієнтири:\nперший ");
            objWord.Selection.TypeText(textBox1.Text);
            objWord.Selection.TypeText(",\nдругий ");
            objWord.Selection.TypeText(textBox2.Text);
            objWord.Selection.TypeText(",\nтретій ");
            objWord.Selection.TypeText(textBox3.Text);
            objWord.Selection.TypeText(".\n2. Противник веде оборону по рубежу ");
            objWord.Selection.TypeText(textBox4.Text);
            objWord.Selection.TypeText(", його вогневі засоби виявлені: ");
            objWord.Selection.TypeText(textBox5.Text);
            objWord.Selection.TypeText(".\nПеред переднім краєм оборони противника виявлені дротяні загородження і мінне " +
                "поле.\n3. ");
            objWord.Selection.TypeText(textBox6.Text);
            objWord.Selection.TypeText(" з ");
            objWord.Selection.TypeText(textBox7.Text);
            objWord.Selection.TypeText(" в ніч з ");
            objWord.Selection.TypeText(textBox8.Text);
            objWord.Selection.TypeText(" на ");
            objWord.Selection.TypeText(textBox9.Text);
            objWord.Selection.TypeText(" здійснює пошук в районі: ");
            objWord.Selection.TypeText(textBox10.Text);
            objWord.Selection.TypeText(" з метою захоплення ");
            objWord.Selection.TypeText(textBox11.Text);
            objWord.Selection.TypeText(" зі складу ");
            objWord.Selection.TypeText(textBox12.Text);
            objWord.Selection.TypeText(", що зосереджений в районі: ");
            objWord.Selection.TypeText(textBox13.Text);
            objWord.Selection.TypeText(".\nДії взводу підтримують ");
            objWord.Selection.TypeText(textBox14.Text);
            objWord.Selection.TypeText(". Вогонь підготований по ");
            objWord.Selection.TypeText(textBox15.Text);
            objWord.Selection.TypeText(".\n");
            objWord.Selection.TypeText(textBox16.Text);
            objWord.Selection.TypeText(" - група захоплення. Приховано висунутись до ");
            objWord.Selection.TypeText(textBox17.Text);
            objWord.Selection.TypeText(". За моєю командою здійснити напад на об’єкт, захопити полоненого, документи і " +
                "доставити в розташування своїх військ.\nГрупа розгородження – старший ");
            objWord.Selection.TypeText(textBox18.Text);
            objWord.Selection.TypeText(", з двома розвідниками ");
            objWord.Selection.TypeText(textBox19.Text);
            objWord.Selection.TypeText(" і ");
            objWord.Selection.TypeText(textBox20.Text);
            objWord.Selection.TypeText(" висунутись до дротових загороджень противника, проробити і позначити прохід в " +
                "них і мінному полі і охороняти їх до виконання завдання взводом. Розвідники ");
            objWord.Selection.TypeText(textBox21.Text);
            objWord.Selection.TypeText(", з підходом ");
            objWord.Selection.TypeText(textBox22.Text);
            objWord.Selection.TypeText(" до проходу діють в складі відділення ");
            objWord.Selection.TypeText(textBox23.Text);
            objWord.Selection.TypeText(" - група забезпечення №1 приховано висувається в напрямку ");
            objWord.Selection.TypeText(textBox24.Text);
            objWord.Selection.TypeText(" і займає позицію в районі ");
            objWord.Selection.TypeText(textBox25.Text);
            objWord.Selection.TypeText(". Бути в готовності прикрити вогнем дії ");
            objWord.Selection.TypeText(textBox26.Text);
            objWord.Selection.TypeText(" і його відхід в розташування своїх військ.\n");
            objWord.Selection.TypeText(textBox27.Text);
            objWord.Selection.TypeText(" - група забезпечення №2, висунутись на позицію в районі ");
            objWord.Selection.TypeText(textBox28.Text);
            objWord.Selection.TypeText(". Бути в готовності не допустити ведення вогню і підходу противника з напрямку ");
            objWord.Selection.TypeText(textBox29.Text);
            objWord.Selection.TypeText(", в подальшому прикрити вогнем відхід ");
            objWord.Selection.TypeText(textBox30.Text);
            objWord.Selection.TypeText(" і ");
            objWord.Selection.TypeText(textBox31.Text);
            objWord.Selection.TypeText(" після виконання завдання.\nНапрямок руху ");
            objWord.Selection.TypeText(textBox32.Text);
            objWord.Selection.TypeText(".\nПершими до загородження противника висуваються сапери і розвідники ");
            objWord.Selection.TypeText(textBox33.Text);
            objWord.Selection.TypeText(", проробляють прохід і позначають його. По готовності проходу починає рух ");
            objWord.Selection.TypeText(textBox34.Text);
            objWord.Selection.TypeText(", за ним ");
            objWord.Selection.TypeText(textBox35.Text);
            objWord.Selection.TypeText(" і ");
            objWord.Selection.TypeText(textBox36.Text);
            objWord.Selection.TypeText(", я пересуваюсь з ");
            objWord.Selection.TypeText(textBox37.Text);
            objWord.Selection.TypeText(". Після заняття відділеннями вказаних позицій за моєю командою ");
            objWord.Selection.TypeText(textBox38.Text);
            objWord.Selection.TypeText(" здійснює напад на ");
            objWord.Selection.TypeText(textBox39.Text);
            objWord.Selection.TypeText(", захоплює полоненого, документи і відходить з ним в розташування своїх військ.\n" +
                "Після відходу ");
            objWord.Selection.TypeText(textBox40.Text);
            objWord.Selection.TypeText(" за моєю командою починає відхід ");
            objWord.Selection.TypeText(textBox41.Text);
            objWord.Selection.TypeText(", а потім ");
            objWord.Selection.TypeText(textBox42.Text);
            objWord.Selection.TypeText(". Після подолання загороджень противника (просування через загородження) займає " +
                "позицію з боку нашого фронту і забезпечує відхід всього ");
            objWord.Selection.TypeText(textBox43.Text);
            objWord.Selection.TypeText(", в вихідне положення.\nМаршрут відходу ");
            objWord.Selection.TypeText(textBox44.Text);
            objWord.Selection.TypeText(". У випадку виявлення противником взводу відхід здійснювати в тій же " +
                "послідовності під прикриттям вогню артилерії і мінометів.\nСигнали про готовність проходу в загородженнях - ");
            objWord.Selection.TypeText(textBox45.Text);
            objWord.Selection.TypeText("; виклика вогню - ");
            objWord.Selection.TypeText(textBox46.Text);
            objWord.Selection.TypeText("; припинення вогню - ");
            objWord.Selection.TypeText(textBox47.Text);
            objWord.Selection.TypeText(".\nЯ знаходжусь в ");
            objWord.Selection.TypeText(textBox48.Text);
            objWord.Selection.TypeText(", при виході до проходу в загородженні, в подальшому – з ");
            objWord.Selection.TypeText(textBox49.Text);
            objWord.Selection.TypeText(".\nМій заступник ");
            objWord.Selection.TypeText(textBox50.Text);
            objWord.Selection.TypeText(".\nПропуск ");
            objWord.Selection.TypeText(textBox51.Text);
            objWord.Selection.TypeText(";");

            try
            {
                Directory.CreateDirectory(Constant.RootToSaveGenerated);
                objDoc.SaveAs($"{Constant.RootToSaveGenerated}Order 8_2 {Constant.Date}");
                string path = objDoc.FullName;

                var dialog = new DialogPrintDocument(Constant.ConfirmPrintMessage);
                dialog.ShowDialog();
                if (dialog.Cancelled != true)
                {
                    objDoc.PrintOut();
                }

                objDoc.Close();
                objWord.Quit();

                var order = orderService.AddOrder(path, userProfile.UserId, Constant.Form82);
                if (order != null)
                {
                    CustomMessageBox messageBox = new CustomMessageBox(Constant.OrderSavedToDbMessage);
                    messageBox.ShowDialog();
                }
                else
                {
                    CustomMessageBox messageBox = new CustomMessageBox(Constant.OrderNotSavedMessage);
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
            Close();
        }
    }
}