using System;
using System.Net;

namespace CollectionsSwitchEnums.Enums
{
    public static class MonthNames
    {
        public const string January = "January";
        public const string Febriary = "Febriary";
        public const string March = "March";
        public const string April = "April";
        public const string May = "May";
        public const string June = "June";
        public const string July = "July";
        public const string August = "August";
        public const string September = "September";
        public const string October = "October";
        public const string November = "November";
        public const string December = "December";
    }

    // Lets save some memory
    public static class Months
    {
        public const int January = 1;
        public const int Febriary = 2;
        public const int March = 3;
        public const int April = 4;
        public const int May = 5;
        public const int June = 6;
        public const int July = 7;
        public const int August = 8;
        public const int September = 9;
        public const int October = 10;
        public const int November = 11;
        public const int December = 12;
    }

    // Note the naming convention: enums are named as singular, so it will be Month.January
    public enum Month
        //: byte
    {
        January,
        Febriary,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    internal class EnumBasics
    {
        public static void DemonstrateEnumConversions()
        {
            // Explicit cast is required
            int selectedMonth = Months.January;
            Month firstMonth = (Month)selectedMonth;
            Console.WriteLine(firstMonth);

            Month secondMonth = (Month)int.MaxValue;
            Console.WriteLine(secondMonth);
        }
    }
}
