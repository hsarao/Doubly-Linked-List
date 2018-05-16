using NUnit.Framework;

namespace Employee.Test
{
    /// <summary>
    /// IMPORTANT NOTE: Uncomment all lines of code inside the function and ensure it works by building
    ///                 out the appropriate class and methods. You may also delete the failing assert line.
    ///                 DO NOT CHANGE THE TEST CODE!! EVER. :)
    /// EmployeeTest - A class for testing the Employee class
    /// Employee - A class for representing an employee with a first name, last name and EmployeeID.
    ///            Must be comparable with itself based on the EmployeeID
    /// 
    /// Assignment:     #1
    /// Course:         ADEV-3001
    /// Date Created:   Sept. 18, 2017
    /// 
    /// @author: Scott Wachal
    /// @version 1.0
    /// </summary>
    [TestFixture]
    public class EmployeeTest
    {
        #region Constructor Test
        /// <summary>
        /// Test the constructor that takes an EmployeeID number to make sure EmployeeID is set, and the other values are default.
        /// </summary>
        [Test]
        public void EmployeeId_Constructor_Test()
        {
            int employeeId = 32;
            Assignment1.Employee employee = new Assignment1.Employee(employeeId);

            Assert.That(employee, Is.Not.Null);
            Assert.That(employee.EmployeeID, Is.EqualTo(employeeId));
            Assert.That(employee.FirstName, Is.EqualTo(null));
            Assert.That(employee.LastName, Is.EqualTo(null));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test the constructor that takes all parameters to ensure the values are being set correctly.
        /// Because the properties are read-only, this test is implictly testing our getter methods as well.
        /// </summary>
        [Test]
        public void FullEmployee_Constructor_Test()
        {
            int employeeid = 32;
            string firstname = "john";
            string lastname = "smith";

            Assignment1.Employee employee = new Assignment1.Employee(employeeid, firstname, lastname);

            Assert.That(employee, Is.Not.Null);
            Assert.That(employee.EmployeeID, Is.EqualTo(employeeid));
            Assert.That(employee.FirstName, Is.EqualTo(firstname));
            Assert.That(employee.LastName, Is.EqualTo(lastname));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }
        #endregion
        
        #region Public Methods
        /// <summary>
        /// Test the CompareTo with an object that should preceed the second object.
        /// </summary>
        [Test]
        public void CompareTo_First_is_Lower_Test()
        {
            Assignment1.Employee employee1 = new Assignment1.Employee(1, "First", "Employee");
            Assignment1.Employee employee2 = new Assignment1.Employee(2, "Second", "Employee");

            Assert.That(employee1.CompareTo(employee2), Is.LessThan(0));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test the CompareTo with an object that should follow the second object.
        /// </summary>
        [Test]
        public void CompareTo_First_is_Higher_Test()
        {
            Assignment1.Employee employee1 = new Assignment1.Employee(2, "First", "Employee");
            Assignment1.Employee employee2 = new Assignment1.Employee(1, "Second", "Employee");

            Assert.That(employee1.CompareTo(employee2) > 0);
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test the CompareTo with two objects that are equal.
        /// </summary>
        [Test]
        public void CompareTo_Equal_Test()
        {
            Assignment1.Employee employee1 = new Assignment1.Employee(1, "First", "Employee");
            Assignment1.Employee employee2 = new Assignment1.Employee(1, "Second", "Employee");

            Assert.That(employee1.CompareTo(employee2) == 0);
           // Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test the ToString method with a FirstName and LastName set to ensure the returned string is as expected.
        /// </summary>
        [Test]
        public void ToString_Test()
        {
            int employeeId = 1;
            string firstName = "First";
            string lastName = "Employee";
            Assignment1.Employee employee = new Assignment1.Employee(employeeId, firstName, lastName);

            string expectedToString = $"{employeeId} {firstName} {lastName}";
            Assert.That(employee.ToString(), Is.EqualTo(expectedToString));
            // Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test the ToString method without a FirstName or LastName set, should display with the word null for the missing values
        /// </summary>
        [Test]
        public void ToString_with_no_names_shows_Nulls_Test()
        {
            int employeeId = 1;
            Assignment1.Employee employee = new Assignment1.Employee(employeeId);

            string expectedToString = $"{employeeId} null null";
            Assert.That(employee.ToString(), Is.EqualTo(expectedToString));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }
        #endregion
    }
}