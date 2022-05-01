using CombatReports.Business.Services.Interfaces;
using CombatReports.OrdersExamples.TextExamples.TypeB4;
using CombatReports.DialogWindows;
using System;
using System.IO;
using System.Windows;
using Constant = CombatReports.Constants.Constants;
using Word = Microsoft.Office.Interop.Word;

namespace CombatReports.TextOrders.TypeB4
{
    public partial class Order4_6 : Window
    {
        private readonly IOrderService orderService;

        public Order4_6(IOrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Order4_6_Example form4_6_Example = new Order4_6_Example();
            form4_6_Example.Show();
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
            objWord.Selection.TypeText("В.4.6. Схема опорного пункту роти\nНа схемі опорного пункту роти:\n- орієнтири ");
            objWord.Selection.TypeText(textBox1.Text);
            objWord.Selection.TypeText(";\n- положення противника:\n- передній край ");
            objWord.Selection.TypeText(textBox2.Text);
            objWord.Selection.TypeText(";\n- рубежі розгортання ");
            objWord.Selection.TypeText(textBox3.Text);
            objWord.Selection.TypeText(";\n- смуга вогню роти ");
            objWord.Selection.TypeText(textBox4.Text);
            objWord.Selection.TypeText(";\n- опорні пункти взводів ");
            objWord.Selection.TypeText(textBox5.Text);
            objWord.Selection.TypeText(", їхні смуги вогню ");
            objWord.Selection.TypeText(textBox6.Text);
            objWord.Selection.TypeText(" і додаткові сектори обстрілу ");
            objWord.Selection.TypeText(textBox7.Text);
            objWord.Selection.TypeText(";\n- основні і запасні вогневі позиції ");
            objWord.Selection.TypeText(textBox8.Text);
            objWord.Selection.TypeText(" бойових машин піхоти (бронетранспортерів), танків, протитанкових і зенітних засобів;\n" +
                "- вогневі позиції, сектори обстрілу ");
            objWord.Selection.TypeText(textBox9.Text);
            objWord.Selection.TypeText(" вогневих засобів, які забезпечують фланги роти і проміжки між взводними опорними пунктами, а на " +
                "схемі опорного пункту механізованої роти і приданих танків;\n- ділянки зосередженого вогню роти і кожного взводу ");
            objWord.Selection.TypeText(textBox10.Text);
            objWord.Selection.TypeText(";\n- рубежі ");
            objWord.Selection.TypeText(textBox11.Text);
            objWord.Selection.TypeText(" відкриття вогню з танків, бойових машин піхоти; протитанкових керованих ракетних комплексів та " +
                "інших вогневих засобів;\n- район ");
            objWord.Selection.TypeText(textBox12.Text);
            objWord.Selection.TypeText(" зосередження і вогневі рубежі ");
            objWord.Selection.TypeText(textBox13.Text);
            objWord.Selection.TypeText(" бронегрупи;\n- позиції ");
            objWord.Selection.TypeText(textBox14.Text);
            objWord.Selection.TypeText(" і шляхи ");
            objWord.Selection.TypeText(textBox15.Text);
            objWord.Selection.TypeText(" маневру кочуючих вогневих засобів;\n- місця влаштування вогневих засад ");
            objWord.Selection.TypeText(textBox16.Text);
            objWord.Selection.TypeText(";\n- інженерні загородження ");
            objWord.Selection.TypeText(textBox17.Text);
            objWord.Selection.TypeText(", і фортифікаційні споруди;\n- проходи ");
            objWord.Selection.TypeText(textBox18.Text);
            objWord.Selection.TypeText(" в загородженнях для кочуючих вогневих засобів і діючих у вогневих засадах;\n- місця ");
            objWord.Selection.TypeText(textBox19.Text);
            objWord.Selection.TypeText(" розгортання пунктів технічного спостереження ");
            objWord.Selection.TypeText(textBox20.Text);
            objWord.Selection.TypeText(" бойового постачання ");
            objWord.Selection.TypeText(textBox21.Text);
            objWord.Selection.TypeText(" і медичного поста роти ");
            objWord.Selection.TypeText(textBox22.Text);
            objWord.Selection.TypeText(";\n- місця командно-спостережних пунктів роти і взводів ");
            objWord.Selection.TypeText(textBox23.Text);
            objWord.Selection.TypeText(".");

            try
            {
                Directory.CreateDirectory(Constant.RootToSaveGenerated);
                objDoc.SaveAs($"{Constant.RootToSaveGenerated}Form 4_6 {Constant.Date}");
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
                    CustomMessageBox messageBox = new CustomMessageBox(Constant.OrderSavedMessage);
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