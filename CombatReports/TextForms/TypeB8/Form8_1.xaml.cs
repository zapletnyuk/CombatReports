using CombatReports.DocumentExamplesForms.TextExamples.TypeB8;
using CombatReports.DAL.Models;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;
using CombatReports.BLL.Services.Interfaces;

namespace CombatReports.TextForms.TypeB8
{
    /// <summary>
    /// Interaction logic for Form8_1.xaml
    /// </summary>
    public partial class Form8_1 : Window
    {
        private readonly IOrderService orderService;
        public Form8_1(IOrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            Form8_1_Example form8_1_Example = new Form8_1_Example();
            form8_1_Example.Show();
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
            wordRan.ParagraphFormat.FirstLineIndent = objWord.InchesToPoints((float)0.5);
            wordRan.ParagraphFormat.SpaceAfter = 0;
            wordRan.ParagraphFormat.SpaceBefore = 0;

            // Генерація вмісту
            objWord.Selection.TypeText("В.8.1. Бойовий наказ командира розвідувального взводу на проведення засідки\n\n" +
                "1. Орієнтири: перший ");
            objWord.Selection.TypeText(textBox1.Text);
            objWord.Selection.TypeText(", другий ");
            objWord.Selection.TypeText(textBox2.Text);
            objWord.Selection.TypeText(", третій ");
            objWord.Selection.TypeText(textBox3.Text);
            objWord.Selection.TypeText(", четвертий ");
            objWord.Selection.TypeText(textBox4.Text);
            objWord.Selection.TypeText(".\n2. Противник веде оборону рубежів ");
            objWord.Selection.TypeText(textBox5.Text);
            objWord.Selection.TypeText(", ");
            objWord.Selection.TypeText(textBox6.Text);
            objWord.Selection.TypeText(".\nВзводні опорні пункти виявлені в районі ");
            objWord.Selection.TypeText(textBox7.Text);
            objWord.Selection.TypeText(";\nВогневі засоби виявлені ");
            objWord.Selection.TypeText(textBox8.Text);
            objWord.Selection.TypeText(";\nПеред переднім краєм і в проміжках між опорними пунктами – мінно-вибухові " +
                "загородження.\nДо ");
            objWord.Selection.TypeText(textBox9.Text);
            objWord.Selection.TypeText(" зосереджено в районі ");
            objWord.Selection.TypeText(textBox10.Text);
            objWord.Selection.TypeText(".\nПо дорозі ");
            objWord.Selection.TypeText(textBox11.Text);
            objWord.Selection.TypeText(" і назад встановлено рух поодиноких автомобілів і квадрациклів. Об ");
            objWord.Selection.TypeText(textBox12.Text);
            objWord.Selection.TypeText(" рух посилюється.\n3. ");
            objWord.Selection.TypeText(textBox13.Text);
            objWord.Selection.TypeText(" з двома саперами отримав завдання в ніч з ");
            objWord.Selection.TypeText(textBox14.Text);
            objWord.Selection.TypeText(" на ");
            objWord.Selection.TypeText(textBox15.Text);
            objWord.Selection.TypeText(" у ");
            objWord.Selection.TypeText(textBox16.Text);
            objWord.Selection.TypeText(" і влаштувати засідку на маршруті ");
            objWord.Selection.TypeText(textBox17.Text);
            objWord.Selection.TypeText(", захопити полоненого, документи і носії інформації.\nМаршрут висування в район засідки: ");
            objWord.Selection.TypeText(textBox18.Text);
            objWord.Selection.TypeText(". Маршрут повернення в розташування своїх військ ");
            objWord.Selection.TypeText(textBox19.Text);
            objWord.Selection.TypeText(".\n");
            objWord.Selection.TypeText(textBox20.Text);
            objWord.Selection.TypeText(" з ");
            objWord.Selection.TypeText(textBox21.Text);
            objWord.Selection.TypeText(" – група забезпечення № 1 з вихідного пункту ");
            objWord.Selection.TypeText(textBox22.Text);
            objWord.Selection.TypeText(" висуватися в напрямку ");
            objWord.Selection.TypeText(textBox23.Text);
            objWord.Selection.TypeText(", з виходом в район засідки зайняти позицію ");
            objWord.Selection.TypeText(textBox24.Text);
            objWord.Selection.TypeText(". Бути в готовності вогнем з близької відстані нанести ураження противнику і " +
                "забезпечити захоплення полоненого. Не допустити підходу противника з напрямку ");
            objWord.Selection.TypeText(textBox25.Text);
            objWord.Selection.TypeText(", дорогу перед мостом замінувати ");
            objWord.Selection.TypeText(textBox26.Text);
            objWord.Selection.TypeText(".\n");
            objWord.Selection.TypeText(textBox27.Text);
            objWord.Selection.TypeText(" - група нападу, висуватися за ");
            objWord.Selection.TypeText(textBox28.Text);
            objWord.Selection.TypeText(". З виходом в район засідки зайняти позицію ");
            objWord.Selection.TypeText(textBox29.Text);
            objWord.Selection.TypeText(". Бути в готовності і за моїм сигналом раптово здійснити напад на противника " +
                "і захопити полоненого, документи і носії інформації.\n");
            objWord.Selection.TypeText(textBox30.Text);
            objWord.Selection.TypeText(" - група забезпечення №2 висуватися за ");
            objWord.Selection.TypeText(textBox31.Text);
            objWord.Selection.TypeText(". Зайняти позицію ");
            objWord.Selection.TypeText(textBox32.Text);
            objWord.Selection.TypeText(". Бути в готовності вогнем із близької відстані нанести ураження противнику і " +
                "забезпечити захоплення полоненого, не допустити підходу резервів з напрямку ");
            objWord.Selection.TypeText(textBox33.Text);
            objWord.Selection.TypeText(".\nСпостерігачам-розвідникам ");
            objWord.Selection.TypeText(textBox34.Text);
            objWord.Selection.TypeText(", старший ");
            objWord.Selection.TypeText(textBox35.Text);
            objWord.Selection.TypeText(" зайняти спостережний пост ");
            objWord.Selection.TypeText(textBox36.Text);
            objWord.Selection.TypeText(". Вести спостереження в секторі ");
            objWord.Selection.TypeText(textBox37.Text);
            objWord.Selection.TypeText(". Про підхід противника в район засідки доповідати негайно сигналами: БТР, " +
                "танк – ");
            objWord.Selection.TypeText(textBox38.Text);
            objWord.Selection.TypeText(", автомобіль, квадрацикл – ");
            objWord.Selection.TypeText(textBox39.Text);
            objWord.Selection.TypeText(". Бути в готовності і не допустити відходу противника в напрямку ");
            objWord.Selection.TypeText(textBox40.Text);
            objWord.Selection.TypeText(". Відходити на позиції ");
            objWord.Selection.TypeText(textBox41.Text);
            objWord.Selection.TypeText(".\nПорядок повернення: першим відходить ");
            objWord.Selection.TypeText(textBox42.Text);
            objWord.Selection.TypeText(", за ним ");
            objWord.Selection.TypeText(textBox43.Text);
            objWord.Selection.TypeText(", прикриває відхід ");
            objWord.Selection.TypeText(textBox44.Text);
            objWord.Selection.TypeText(".\n4. Артилерія готує загороджувальний вогонь по ділянках: № 1 ");
            objWord.Selection.TypeText(textBox45.Text);
            objWord.Selection.TypeText(", № 2 ");
            objWord.Selection.TypeText(textBox46.Text);
            objWord.Selection.TypeText(", № 3 ");
            objWord.Selection.TypeText(textBox47.Text);
            objWord.Selection.TypeText(", № 4 ");
            objWord.Selection.TypeText(textBox48.Text);
            objWord.Selection.TypeText(". Вихідний пункт ");
            objWord.Selection.TypeText(textBox49.Text);
            objWord.Selection.TypeText(", взвод проходить о ");
            objWord.Selection.TypeText(textBox50.Text);
            objWord.Selection.TypeText(", готовність до руху ");
            objWord.Selection.TypeText(textBox51.Text);
            objWord.Selection.TypeText(".\nСигнали: на відкриття вогню ");
            objWord.Selection.TypeText(textBox52.Text);
            objWord.Selection.TypeText(";\nВиклик зосередженого вогню по ділянці № 1 - ");
            objWord.Selection.TypeText(textBox53.Text);
            objWord.Selection.TypeText(";\nпо ділянці № 2 - ");
            objWord.Selection.TypeText(textBox54.Text);
            objWord.Selection.TypeText(";\nпо ділянці № 3 - ");
            objWord.Selection.TypeText(textBox55.Text);
            objWord.Selection.TypeText(";\nпо ділянці № 4 - ");
            objWord.Selection.TypeText(textBox56.Text);
            objWord.Selection.TypeText(".\nПрипинення вогню артилерії - ");
            objWord.Selection.TypeText(textBox57.Text);
            objWord.Selection.TypeText(".\nЯ – з ");
            objWord.Selection.TypeText(textBox58.Text);
            objWord.Selection.TypeText(".\nМій заступник – командир ");
            objWord.Selection.TypeText(textBox59.Text);
            objWord.Selection.TypeText(".\nПропуск - ");
            objWord.Selection.TypeText(textBox60.Text);
            objWord.Selection.TypeText(".");
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow(orderService);
            mainWindow.Show();
        }
    }
}
