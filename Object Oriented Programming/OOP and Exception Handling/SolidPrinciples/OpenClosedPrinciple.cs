namespace SolidPrinciples
{
    // "Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification"
    public class NotificationService
    {
        public void SendMessage(string typeMessage, string message)
        {
            if (typeMessage.Equals("email"))
            {
                // Write email
                // Send email
            }
            if (typeMessage.Equals("sms"))
            {
                // Write SMS
                // Send SMS
            }
        }
    }

    public interface IBaseClass
    {
        void SharedFunction();
    }

    public class ClassA
    {
        private readonly IBaseClass _baseClass;

        public ClassA(IBaseClass baseClass)
        {
            _baseClass = baseClass;
        }

        public void Method()
        {
            _baseClass.SharedFunction();
        }
    }

    public class ClassB
    {
        private readonly IBaseClass _baseClass;

        public ClassB(IBaseClass baseClass)
        {
            _baseClass = baseClass;
        } 

        public void Method()
        {
            _baseClass.SharedFunction();
        }
    }

    #region Extend

    public interface INotificationService
    {
        public void SendMessage(string message);
    }

    public class EmailNotification : INotificationService
    {
        public void SendMessage(string message)
        {
            // Write email
            // Send email
        }
    }

    public class MobileNotification : INotificationService
    {
        public void SendMessage(string message)
        {
            // Write SMS
            // Send SMS
        }
    }

    #endregion
}
