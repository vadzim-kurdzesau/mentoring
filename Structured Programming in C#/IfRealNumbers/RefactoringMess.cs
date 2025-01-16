namespace IfRealNumbers
{
    public class RefactoringMess
    {
        public static int CalculateNumberOfWeekends(bool isLeapYear)
        {
            int daysInYear = 365;
            int daysInWeek = 7;
            int weekendPerWeek = 2;
            if (isLeapYear)
            {
                return (daysInYear + 1) / daysInWeek * weekendPerWeek;
            }

            return daysInYear / daysInWeek * weekendPerWeek;
        }

        public static bool IsAbleToTakeVacation(int daysWorked, int vacationLeft)
        {
            if (vacationLeft > 0)
            {
                if (daysWorked > 30)
                {
                    
                }
            }

            return false;
        }

        private static bool IsHoliday()
        {
            return true;
        }
    }
}