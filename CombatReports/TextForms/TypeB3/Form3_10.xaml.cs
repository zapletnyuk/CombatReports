﻿using CombatReports.BLL.Services.Interfaces;
using CombatReports.DocumentExamplesForms.TextExamples.TypeB3;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;

namespace CombatReports.TextForms.TypeB3
{
    /// <summary>
    /// Interaction logic for Form3_10.xaml
    /// </summary>
    public partial class Form3_10 : Window
    {
        private readonly IOrderService orderService;
        private readonly IHashService hashService;
        public Form3_10(IOrderService orderService, IHashService hashService)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.hashService = hashService;
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form3_10_Example form3_10_Example = new Form3_10_Example();
            form3_10_Example.Show();
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
            objWord.Selection.TypeText("В.3.10. Попереднє бойове розпорядження командира механізованого батальйону (оборона)\n\nКОМАНДИРУ ");
            objWord.Selection.TypeText(textBox1.Text);
            objWord.Selection.TypeText(".\nПОПЕРЕДНЄ БОЙОВЕ РОЗПОРЯДЖЕННЯ. КСП ");
            objWord.Selection.TypeText(textBox2.Text);
            objWord.Selection.TypeText(", ");
            objWord.Selection.TypeText(textBox3.Text);
            objWord.Selection.TypeText(". Карта ");
            objWord.Selection.TypeText(textBox4.Text);
            objWord.Selection.TypeText(", видання ");
            objWord.Selection.TypeText(textBox5.Text);
            objWord.Selection.TypeText(".\n1. Підрозділи противника ");
            objWord.Selection.TypeText(textBox6.Text);
            objWord.Selection.TypeText(" (відійшли або вийшли) на рубіж ");
            objWord.Selection.TypeText(textBox7.Text);
            objWord.Selection.TypeText(", закріпилися і його утримують.\nЧастини, що висуваються з резерву, зосереджуються в районі ");
            objWord.Selection.TypeText(textBox8.Text);
            objWord.Selection.TypeText(", наступ їх можливий ");
            objWord.Selection.TypeText(textBox9.Text);
            objWord.Selection.TypeText(".\nПраворуч переходить до оборони ");
            objWord.Selection.TypeText(textBox10.Text);
            objWord.Selection.TypeText(" мр сусідньої омбр із завданням обороняти опорний пункт ");
            objWord.Selection.TypeText(textBox11.Text);
            objWord.Selection.TypeText(" і не допустити прориву противника в напрямку ");
            objWord.Selection.TypeText(textBox12.Text);
            objWord.Selection.TypeText(".\nРозмежувальна лінія із сусідом праворуч ");
            objWord.Selection.TypeText(textBox13.Text);
            objWord.Selection.TypeText(".\nЛіворуч ");
            objWord.Selection.TypeText(textBox14.Text);
            objWord.Selection.TypeText(" мр нашої омбр переходить до оборони опорного пункту ");
            objWord.Selection.TypeText(textBox15.Text);
            objWord.Selection.TypeText(" і з завданням не допустити прориву противника в напрямку ");
            objWord.Selection.TypeText(textBox16.Text);
            objWord.Selection.TypeText(".\nРозмежувальна лінія із сусідом ліворуч ");
            objWord.Selection.TypeText(textBox17.Text);
            objWord.Selection.TypeText(".\nРекогносцировку проводжу з ");
            objWord.Selection.TypeText(textBox18.Text);
            objWord.Selection.TypeText(", де віддам бойовий наказ.");
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow(orderService, hashService);
            mainWindow.Show();
        }
    }
}
