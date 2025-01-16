namespace SolidPrinciples
{
    // "A class should have only one reason to change"
    public class Student
    {
        public List<int> marks = new List<int>();

        public void CalculateStudentResults()
        {
            // Some logic
        }
    }

    public class GodClass
    {
        // Save data to DB

        // Work with UI

        // Sends EMAIL
    }

    public class Courier
    {
        // Deliver
    }

    class StudentsRecords
    {
        public void RegisterStudent()
        {
            // Some logic
        }
    }

    public class EmailService
    {
        public void SendEmail()
        {
            // Some logic
        }
    }
}
