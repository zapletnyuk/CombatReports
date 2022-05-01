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
        public static readonly string OrderSavedMessage = "Наказ збережено до бази даних!";
        public static readonly string OrderNotSavedMessage = "Сталася помилка! Наказ не збережено до бази даних!";
        public static readonly string OrderNotFoundMessage = "Наказ не знайдено.";
        public static readonly string ConfirmPrintMessage = "Підтвердити друк?";
        public static readonly string ChooseOnlyOneFileForSaveMessage = "Виберіть лише один файл для збереження!";
        public static readonly string EnterHashMessage = "Необхідно ввести хеш.";
        public static readonly string NeedToEnterEnterHashMessage = "Введіть хеш, будь ласка.";
        public static readonly string ConfirmedHashMessage = "Хеш підтверджено.";
        public static readonly string WrongHashMessage = "Невірний хеш. Повторіть, будь ласка, ще раз.";
    }
}