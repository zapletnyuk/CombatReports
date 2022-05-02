using CombatReports.Business.Services.Interfaces;
using CombatReports.OrdersExamples.TableExamples.TypeB4;
using CombatReports.DialogWindows;
using System;
using System.IO;
using System.Windows;
using Constant = CombatReports.Constants.Constants;
using Word = Microsoft.Office.Interop.Word;

namespace CombatReports.TableOrders.TypeB4
{
    public partial class Order4_1 : Window
    {
        private readonly IOrderService orderService;

        public Order4_1(IOrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Order4_1_Example form4_1_Example = new Order4_1_Example();
            form4_1_Example.Show();
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
            par1.Text = "В.4.1. Розрахунок часу командира механізованої роти.";
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

            // Таблиця, форматування
            Word.Range par7 = objDoc.Bookmarks.get_Item(ref objEndOfDocFlag).Range;
            Word.Table tableObj;
            tableObj = objDoc.Tables.Add(par7, 18, 4, ref objMissing, ref objMissing);
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
            for (int i = 3; i <= 18; i++)
            {
                tableObj.Cell(i, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tableObj.Cell(i, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalTop;
            }

            for (int i = 3; i <= 18; i++)
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
            tableObj.Cell(4, 1).Range.Text = "Визначення заходів, які необхідно провести негайно для підготовки роти до бою";
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
            tableObj.Cell(8, 1).Range.Text = "Доповідь рішення старшому командиру";
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
            tableObj.Cell(11, 1).Range.Text = "Організація взаємодії і системи вогню та віддання вказівок, щодо всебічного забезпечення";
            tableObj.Cell(11, 2).Range.Text = textBox30.Text;
            tableObj.Cell(11, 3).Range.Text = textBox31.Text;
            tableObj.Cell(11, 4).Range.Text = textBox32.Text;
            tableObj.Cell(12, 1).Range.Text = "Зайняття ротного опорного пункту";
            tableObj.Cell(12, 2).Range.Text = textBox33.Text;
            tableObj.Cell(12, 3).Range.Text = textBox34.Text;
            tableObj.Cell(12, 4).Range.Text = textBox35.Text;
            tableObj.Cell(13, 1).Range.Text = "Доповідь командиру батальйону про готовність системи вогню";
            tableObj.Cell(13, 2).Range.Text = textBox36.Text;
            tableObj.Cell(13, 3).Range.Text = textBox37.Text;
            tableObj.Cell(13, 4).Range.Text = textBox38.Text;
            tableObj.Cell(14, 1).Range.Text = "Виконання робіт інженерного обладнання РОП 1 черги";
            tableObj.Cell(14, 2).Range.Text = textBox39.Text;
            tableObj.Cell(14, 3).Range.Text = textBox40.Text;
            tableObj.Cell(14, 4).Range.Text = textBox41.Text;
            tableObj.Cell(15, 1).Range.Text = "Виконання робіт інженерного обладнання РОП 2 черги";
            tableObj.Cell(15, 2).Range.Text = textBox42.Text;
            tableObj.Cell(15, 3).Range.Text = textBox43.Text;
            tableObj.Cell(15, 4).Range.Text = textBox44.Text;
            tableObj.Cell(16, 1).Range.Text = "Контроль та допомога командирам підрозділів в організації оборони.";
            tableObj.Cell(16, 2).Range.Text = textBox45.Text;
            tableObj.Cell(16, 3).Range.Text = textBox46.Text;
            tableObj.Cell(16, 4).Range.Text = textBox47.Text;
            tableObj.Cell(17, 1).Range.Text = "Прийняття доповіді командирів підрозділів про готовність оборони";
            tableObj.Cell(17, 2).Range.Text = textBox48.Text;
            tableObj.Cell(17, 3).Range.Text = textBox49.Text;
            tableObj.Cell(17, 4).Range.Text = textBox50.Text;
            tableObj.Cell(18, 1).Range.Text = "Доповідь командиру батальйону про готовність оборони";
            tableObj.Cell(18, 2).Range.Text = textBox51.Text;
            tableObj.Cell(18, 3).Range.Text = textBox52.Text;
            tableObj.Cell(18, 4).Range.Text = textBox53.Text;
            par7.InsertParagraphAfter();

            try
            {
                Directory.CreateDirectory(Constant.RootToSaveGenerated);
                objDoc.SaveAs($"{Constant.RootToSaveGenerated}Form 4_1 {Constant.Date}");
                string path = objDoc.FullName;

                var dialog = new DialogPrintDocument(Constant.ConfirmPrintMessage);
                dialog.ShowDialog();
                if (dialog.Cancelled != true)
                {
                    objDoc.PrintOut();
                }

                objDoc.Close();
                objWord.Quit();

                var order = orderService.AddOrder(path);
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