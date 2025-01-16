namespace SolidPrinciples
{
    // "Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it."
    // Not following the Liskov Substitution Principle
    public interface IFileDataAccessBase
    {
        public string FilePath { get; set; }

        public void ReadFile();

        public void WriteFile();
    }

    public class NormalFileDataAccess : IFileDataAccessBase
    {
        public string FilePath { get; set; }

        public void ReadFile()
        {
            // Read File logic
            Console.WriteLine($"File {FilePath} has been read");
        }

        public void WriteFile()
        {
            // Write File Logic
            Console.WriteLine($"File {FilePath} has been written");
        }
    }

    public class ReadonlyFileDataAccess : IFileDataAccessBase
    {
        public string FilePath { get; set; }

        public void ReadFile()
        {
            // Read File logic
            Console.WriteLine($"File {FilePath} has been read");
        }

        public void WriteFile()
        {
            // Write File Logic
            throw new NotImplementedException();
        }
    }

    public class LiskovSubstitutionDemo
    {
        public void Demonstrate()
        {
            // Calling class not following Liskov Substitution Principle
            IFileDataAccessBase accessDataFile = new NormalFileDataAccess();
            accessDataFile.FilePath = @"c:\temp\a.txt";
            accessDataFile.ReadFile();
            accessDataFile.WriteFile();

            IFileDataAccessBase regularAccessDataFile = new ReadonlyFileDataAccess();
            regularAccessDataFile.FilePath = @"c:\temp\a.txt";
            regularAccessDataFile.ReadFile();
            //accessDataFileR.WriteFile();  // Throws exception
        }

        public void Work(IFileDataAccessBase dataAccess)
        {
            dataAccess.FilePath = @"c:\temp\a.txt";
            dataAccess.ReadFile();

            dataAccess.WriteFile();
        }
    }

    #region Fix

    public interface IFileReader
    {
        void ReadFile(string filePath);
    }

    public interface IFileWriter
    {
        void WriteFile(string filePath);
    }

    public class FixedAdminFileDataAccess : IFileReader, IFileWriter
    {
        public void ReadFile(string filePath)
        {
            // Read File logic
            Console.WriteLine($"File {filePath} has been read");
        }

        public void WriteFile(string filePath)
        {
            // Write File Logic
            Console.WriteLine($"File {filePath} has been written");
        }
    }

    public class FixedRegularUserFileDataAccess : IFileReader
    {
        public void ReadFile(string filePath)
        {
            // Read File logic
            Console.WriteLine($"File {filePath} has been read");
        }
    }

    #endregion
}
