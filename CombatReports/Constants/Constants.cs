using System;
using System.Globalization;

namespace CombatReports.Constants
{
    public static class Constants
    {
        public static readonly string Date = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss-fff",
                                            CultureInfo.InvariantCulture);
        public static readonly string RootToSaveGenerated = @"C:\GeneratedCombatReports\";
        public static readonly string RootToSaveRetrievedFromDb = @"C:\RetrievedFromDbCombatReports\";
        public static readonly string WordOfficeExtension = ".docx";
        public static readonly string OrderSavedToDbMessage = "Наказ збережено до бази даних!";
        public static readonly string OrderSavedToPcMessage = "Наказ збережено!";
        public static readonly string OrderNotSavedMessage = "Сталася помилка! Наказ не збережено до бази даних!";
        public static readonly string OrderNotFoundMessage = "Наказ не знайдено.";
        public static readonly string ConfirmPrintMessage = "Підтвердити друк?";
        public static readonly string ChooseOnlyOneFileForSaveMessage = "Виберіть лише один файл для збереження!";
        public static readonly string EnterHashMessage = "Необхідно ввести хеш.";
        public static readonly string NeedToEnterKeyMessage = "Введіть ключ, будь ласка.";
        public static readonly string ConfirmedHashMessage = "Ключ підтверджено.";
        public static readonly string WrongHashMessage = "Невірний ключ. Повторіть, будь ласка, ще раз.";
        public static readonly string EnterAuthorizationInfo = "Введіть дані для автентифікації.";
        public static readonly string WrongAuthorizationInfo = "Некоректні дані.";

        public static readonly int Form310 = 1310;
        public static readonly int Form324 = 1324;
        public static readonly int Form46 = 146;
        public static readonly int Form81 = 181;
        public static readonly int Form82 = 182;
        public static readonly int Form32 = 232;
        public static readonly int Form33 = 233;
        public static readonly int Form34 = 234;
        public static readonly int Form41 = 241;
        public static readonly int Form42 = 242;

        public static readonly int Admin = 1;
        public static readonly int User = 2;
    }
}