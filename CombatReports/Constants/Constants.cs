using System;
using System.Globalization;

namespace CombatReports.Constants
{
    public static class Constants
    {
        public static readonly string Date = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss-fff",
                                            CultureInfo.InvariantCulture);
        public static readonly string Root = @"C:\CombatReports";
    }
}
