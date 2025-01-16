namespace SolidPrinciples
{
    // "Clients should not be forced to depend upon interfaces that they do not use."
    // I.e. no code should be forced to depend on methods it does not use.
    public interface IOffice
    {
        void Print();

        void Scan();

        void Fax();
    }

    public interface IPrintable
    {
        void Print();
    }

    public interface IScannable
    {
        void Scan();
    }

    public interface IFaxable
    {
        void Fax();
    }

    // Implementations for different types of machines
    public class MultiFunctionPrinter : IPrintable, IScannable, IFaxable
    {
        public void Print()
        {
            Console.WriteLine("Print document");
        }

        public void Scan()
        {
            Console.WriteLine("Scan document");
        }

        public void Fax()
        {
            Console.WriteLine("Fax document");
        }
    }

    public class SimplePrinter : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Print document");
        }
    }

    public class Scanner : IScannable
    {
        public void Scan()
        {
            Console.WriteLine("Scan document");
        }
    }
}
