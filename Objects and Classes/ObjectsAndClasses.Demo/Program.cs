using ObjectsAndClasses.Demo.Classes;

namespace ObjectsAndClasses.Demo;

internal class Program
{
    public static void Main()
    {
        #region Object initialization, default constructor

        User user = new User();
        user.firstName = "Vadzim";
        user.lastName = "Kurdzesau";

        user.Introduce();

        #endregion

        #region Object creation without fields initialization

        //User anotherUser = new User();
        //anotherUser.Introduce();

        #endregion

        #region Use of costructors

        //Admin admin = new Admin("NotVadzim", "NotKurdzesau");
        //admin.Introduce();

        ////Admin anotherAdmin = new Admin();

        #endregion

        #region Public access to fields

        //admin.firstName = null;
        //admin.Introduce();

        #endregion

        #region Use of Properties

        //Employee employee = new Employee("NotVadzim", "EPAM");
        //employee.Introduce();

        //employee.SetFirstName("Vadzim");
        //employee.LastName = "Kurdzesau";
        //employee.Introduce();

        #endregion
    }
}