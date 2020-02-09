using CombatReports.BLL.Services.Interfaces;
using CombatReports.DocumentExamplesForms.TableExamples.TypeB3;
using CombatReports.ManagingWindows;
using System;
using System.IO;
using System.Windows;
using Constant = CombatReports.Constants.Constants;
using Word = Microsoft.Office.Interop.Word;

namespace CombatReports.TableForms.TypeB3
{
    /// <summary>
    /// Interaction logic for Form3_3.xaml
    /// </summary>
    public partial class Form3_3 : Window
    {
        private readonly IOrderService orderService;
        private readonly IHashService hashService;
        public Form3_3(IOrderService orderService, IHashService hashService)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.hashService = hashService;
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form3_3_Example form3_3_Example = new Form3_3_Example();
            form3_3_Example.Show();
        }

        private void GenerateDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            object objMissing = System.Reflection.Missing.Value;
            object objEndOfDocFlag = "\\endofdoc";
            Word.Application objWord = new Word.Application
            {
                Visible = true
            };
            Word.Document objDoc = objWord.Documents.Add(ref objMissing, ref objMissing, ref objMissing, ref objMissing);

            // Перший параграф, форматування
            Word.Range par1 = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            par1.Font.Size = 14;
            par1.Font.Name = "Times New Roman";
            par1.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            par1.ParagraphFormat.LineSpacing = 18;
            par1.ParagraphFormat.FirstLineIndent = objWord.InchesToPoints((float)0.0);
            par1.ParagraphFormat.SpaceAfter = 0;
            par1.ParagraphFormat.SpaceBefore = 0;
            // Генерація вмісту
            par1.Text = "В.3.3. Розрахунок часу роботи командира механізованого батальйону (наступ)";
            par1.InsertParagraphAfter();
            par1.InsertParagraphAfter();

            // Другий параграф, форматування
            Word.Range par2 = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            par2.Font.Size = 14;
            par2.Font.Name = "Times New Roman";
            par2.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            par2.ParagraphFormat.LineSpacing = 18;
            par2.ParagraphFormat.FirstLineIndent = objWord.InchesToPoints((float)0.0);
            par2.ParagraphFormat.SpaceAfter = 0;
            par2.ParagraphFormat.SpaceBefore = 0;
            // Генерація вмісту
            par2.Text = "Час отримання завдання: " + textBox1.Text + ".";
            par2.InsertParagraphAfter();

            // Третій параграф, форматування
            Word.Range par3 = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            par3.Font.Size = 14;
            par3.Font.Name = "Times New Roman";
            par3.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            par3.ParagraphFormat.LineSpacing = 18;
            par3.ParagraphFormat.FirstLineIndent = objWord.InchesToPoints((float)0.0);
            par3.ParagraphFormat.SpaceAfter = 0;
            par3.ParagraphFormat.SpaceBefore = 0;
            // Генерація вмісту
            par3.Text = "Час готовності: " + textBox2.Text + ".";
            par3.InsertParagraphAfter();

            // Четвертий параграф, форматування
            Word.Range par4 = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            par4.Font.Size = 14;
            par4.Font.Name = "Times New Roman";
            par4.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            par4.ParagraphFormat.LineSpacing = 18;
            par4.ParagraphFormat.FirstLineIndent = objWord.InchesToPoints((float)0.0);
            par4.ParagraphFormat.SpaceAfter = 0;
            par4.ParagraphFormat.SpaceBefore = 0;
            // Генерація вмісту
            par4.Text = "Загальний час для підготовки підрозділів: " + textBox3.Text + ".";
            par4.InsertParagraphAfter();

            // П'ятий параграф, форматування
            Word.Range par5 = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            par5.Font.Size = 14;
            par5.Font.Name = "Times New Roman";
            par5.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            par5.ParagraphFormat.LineSpacing = 18;
            par5.ParagraphFormat.FirstLineIndent = objWord.InchesToPoints((float)0.0);
            par5.ParagraphFormat.SpaceAfter = 0;
            par5.ParagraphFormat.SpaceBefore = 0;
            // Генерація вмісту
            par5.Text = "Кількість світлого часу доби: " + textBox4.Text + ".";
            par5.InsertParagraphAfter();

            // Шостий параграф, форматування
            Word.Range par6 = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            par6.Font.Size = 14;
            par6.Font.Name = "Times New Roman";
            par6.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            par6.ParagraphFormat.LineSpacing = 18;
            par6.ParagraphFormat.FirstLineIndent = objWord.InchesToPoints((float)0.0);
            par6.ParagraphFormat.SpaceAfter = 0;
            par6.ParagraphFormat.SpaceBefore = 0;
            // Генерація вмісту
            par6.Text = "Кількість темного часу доби: " + textBox5.Text + ".";
            par6.InsertParagraphAfter();

            // Сьомий параграф, форматування
            Word.Range par7 = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            par7.Font.Size = 14;
            par7.Font.Name = "Times New Roman";
            par7.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            par7.ParagraphFormat.LineSpacing = 12;
            par7.ParagraphFormat.FirstLineIndent = objWord.InchesToPoints((float)0.0);
            par7.ParagraphFormat.SpaceAfter = 1;
            // Генерація вмісту
            par7.Text = "Наявний час розподілити";
            par7.InsertParagraphAfter();

            // Таблиця, форматування
            Word.Range par8 = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            Word.Table tableObj;
            tableObj = objDoc.Tables.Add(par8, 15, 4, ref objMissing, ref objMissing);
            tableObj.Range.Font.Name = "Times New Roman";
            tableObj.Range.Font.Size = 12;
            tableObj.Range.ParagraphFormat.LineSpacing = 12;
            tableObj.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableObj.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            tableObj.Cell(1, 1).Merge(tableObj.Cell(2, 1));
            tableObj.Cell(1, 2).Merge(tableObj.Cell(2, 2));
            tableObj.Cell(1, 3).Merge(tableObj.Cell(1, 4));
            tableObj.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            tableObj.Cell(1, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalTop;
            tableObj.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            tableObj.Cell(1, 2).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalTop;
            tableObj.Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            tableObj.Cell(1, 3).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalTop;
            tableObj.Cell(2, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            tableObj.Cell(2, 3).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalTop;
            tableObj.Cell(2, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            tableObj.Cell(2, 4).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalTop;

            for (int i = 3; i <= 15; i++)
            {
                tableObj.Cell(i, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tableObj.Cell(i, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalTop;
            }

            for (int i = 3; i <= 15; i++)
            {
                for (int j = 2; j <= 4; j++)
                {
                    tableObj.Cell(i, j).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    tableObj.Cell(i, j).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalTop;
                }
            }

            tableObj.Cell(1, 3).Range.ParagraphFormat.SpaceAfter = 8;

            // Таблиця, генерація вмісту
            tableObj.Cell(1, 1).Range.Text = "Заходи, що проводяться";
            tableObj.Cell(1, 2).Range.Text = "Загальна кількість часу (хв)";
            tableObj.Cell(1, 3).Range.Text = "Час роботи";
            tableObj.Cell(2, 3).Range.Text = "Початок\n(час, дата)";
            tableObj.Cell(2, 4).Range.Text = "Кінець\n(час, дата)";
            tableObj.Cell(3, 1).Range.Text = "З’ясування завдання";
            tableObj.Cell(3, 2).Range.Text = textBox6.Text;
            tableObj.Cell(3, 3).Range.Text = textBox7.Text;
            tableObj.Cell(3, 4).Range.Text = textBox8.Text;
            tableObj.Cell(4, 1).Range.Text = "Визначення заходів, які необхідно провести негайно для підготовки батальйону до бою";
            tableObj.Cell(4, 2).Range.Text = textBox9.Text;
            tableObj.Cell(4, 3).Range.Text = textBox10.Text;
            tableObj.Cell(4, 4).Range.Text = textBox11.Text;
            tableObj.Cell(5, 1).Range.Text = "Відпрацювання розрахунку часу";
            tableObj.Cell(5, 2).Range.Text = textBox12.Text;
            tableObj.Cell(5, 3).Range.Text = textBox13.Text;
            tableObj.Cell(5, 4).Range.Text = textBox14.Text;
            tableObj.Cell(6, 1).Range.Text = "Оцінка обстановки";
            tableObj.Cell(6, 2).Range.Text = textBox15.Text;
            tableObj.Cell(6, 3).Range.Text = textBox16.Text;
            tableObj.Cell(6, 4).Range.Text = textBox17.Text;
            tableObj.Cell(7, 1).Range.Text = "Прийняття рішення";
            tableObj.Cell(7, 2).Range.Text = textBox18.Text;
            tableObj.Cell(7, 3).Range.Text = textBox19.Text;
            tableObj.Cell(7, 4).Range.Text = textBox20.Text;
            tableObj.Cell(8, 1).Range.Text = "Доповідь рішення командиру омбр";
            tableObj.Cell(8, 2).Range.Text = textBox21.Text;
            tableObj.Cell(8, 3).Range.Text = textBox22.Text;
            tableObj.Cell(8, 4).Range.Text = textBox23.Text;
            tableObj.Cell(9, 1).Range.Text = "Проведення рекогносцировки";
            tableObj.Cell(9, 2).Range.Text = textBox24.Text;
            tableObj.Cell(9, 3).Range.Text = textBox25.Text;
            tableObj.Cell(9, 4).Range.Text = textBox26.Text;
            tableObj.Cell(10, 1).Range.Text = "Віддання бойового наказу";
            tableObj.Cell(10, 2).Range.Text = textBox27.Text;
            tableObj.Cell(10, 3).Range.Text = textBox28.Text;
            tableObj.Cell(10, 4).Range.Text = textBox29.Text;
            tableObj.Cell(11, 1).Range.Text = "Організація взаємодії, управління та віддання вказівок, щодо всебічного забезпечення";
            tableObj.Cell(11, 2).Range.Text = textBox30.Text;
            tableObj.Cell(11, 3).Range.Text = textBox31.Text;
            tableObj.Cell(11, 4).Range.Text = textBox32.Text;
            tableObj.Cell(12, 1).Range.Text = "Доповідь командиру омбр про готовність до висування";
            tableObj.Cell(12, 2).Range.Text = textBox33.Text;
            tableObj.Cell(12, 3).Range.Text = textBox34.Text;
            tableObj.Cell(12, 4).Range.Text = textBox35.Text;
            tableObj.Cell(13, 1).Range.Text = "Контроль та допомога командирам підрозділів в організації наступу";
            tableObj.Cell(13, 2).Range.Text = textBox36.Text;
            tableObj.Cell(13, 3).Range.Text = textBox37.Text;
            tableObj.Cell(13, 4).Range.Text = textBox38.Text;
            tableObj.Cell(14, 1).Range.Text = "Прийняття доповіді командирів підрозділів про готовність до бойових дій";
            tableObj.Cell(14, 2).Range.Text = textBox39.Text;
            tableObj.Cell(14, 3).Range.Text = textBox40.Text;
            tableObj.Cell(14, 4).Range.Text = textBox41.Text;
            tableObj.Cell(15, 1).Range.Text = "Доповідь командиру омбр про готовність";
            tableObj.Cell(15, 2).Range.Text = textBox42.Text;
            tableObj.Cell(15, 3).Range.Text = textBox43.Text;
            tableObj.Cell(15, 4).Range.Text = textBox44.Text;
            par8.InsertParagraphAfter();

            // Дев'ятий параграф форматування
            Word.Range par9 = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            par9.Font.Size = 14;
            par9.Font.Name = "Times New Roman";
            par9.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            par9.ParagraphFormat.LineSpacing = 18;
            par9.ParagraphFormat.FirstLineIndent = objWord.InchesToPoints((float)0.0);
            par9.ParagraphFormat.SpaceBefore = 20;
            // Генерація вмісту
            par9.Text = "Начальник штабу " + textBox45.Text + " мб";
            par9.InsertParagraphAfter();

            try
            {
                Directory.CreateDirectory(Constant.Root);
                objDoc.SaveAs($"{Constant.Root}/Form 3_3 {Constant.Date}");
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
