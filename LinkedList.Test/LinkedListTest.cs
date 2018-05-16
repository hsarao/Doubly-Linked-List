using NUnit.Framework;
using Assignment1;
using System;

namespace LinkedList.Test
{
    /// <summary>
    /// IMPORTANT NOTE: Uncomment all lines of code inside the function and ensure it works by building
    ///                 out the appropriate class and methods. You may also delete the failing assert line.
    ///                 DO NOT CHANGE THE TEST CODE!! EVER. :)
    /// LinkedListTest - A class for testing the LinkedList class
    /// LinkedList - A class for creating and manipulating a doubly linked list of nodes containing generic data of type T.
    /// 
    /// Assignment:     #1
    /// Course:         ADEV-3001
    /// Date Created:   Sept. 18, 2017
    /// 
    /// Revision Log
    /// Who         When        Reason
    /// ----------- ----------- ---------------
    /// 
    /// @author: Scott Wachal
    /// @version 1.0
    /// </summary>
    [TestFixture]
    public class LinkedListTest
    {

        /* MILESTONE 1*/

        #region Constructor Tests, requires GetHead(), GetTail(), GetSize(), IsEmpty()
        /// <summary>
        /// Test the constructor to ensure the default values are set properly.
        /// </summary>
        [Test]
        public void new_constructor_has_size_of_zero_Test()
        {
            LinkedList<Employee> list = new LinkedList<Employee>();

            Assert.That(list.GetSize(), Is.EqualTo(0));
           // Assert.Fail(); // you may delete this line after uncommenting the above code
        }
        
        [Test]
        /// <summary>
        /// Test GetHead returns null when a new constructor is called.
        /// </summary>
        public void GetHead_is_null_on_new_constructor_Test()
        {
            LinkedList<Employee> list = new LinkedList<Employee>();

            Assert.That(list.GetHead(), Is.EqualTo(null));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        [Test]
        /// <summary>
        /// Test GetTail returns null when a new constructor is called.
        /// </summary>
        public void GetTail_is_null_on_new_constructor_Test()
        {
            LinkedList<Employee> list = new LinkedList<Employee>();

            Assert.That(list.GetTail(), Is.EqualTo(null));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test IsEmpty() should return true on an empty list.
        /// </summary>
        [Test]
        public void IsEmpty_is_true_on_new_constructor_Test()
        {
            LinkedList<Employee> list = new LinkedList<Employee>();

            Assert.That(list.IsEmpty(), Is.True);
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }
        #endregion

        #region AddFirst(), requires: GetSize() / GetHead() / GetTail()
        /// <summary>
        /// Test AddFirst() to ensure node is added to list.
        /// </summary>
        [Test]
        public void AddFirst_on_emptylist_count_increases_from_0_to_1_Test()
        {
            Employee addedEmployee = new Employee(1);
            LinkedList<Employee> list = new LinkedList<Employee>();

            Assert.That(list.GetSize(), Is.EqualTo(0));

            list.AddFirst(addedEmployee);

            Assert.That(list.GetSize(), Is.EqualTo(1));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test AddFirst() method to ensure the head pointer is updated when first object is inserted.
        /// </summary>
        [Test]
        public void AddFirst_on_emptylist_Head_Updated_Test()
        {
            Employee employee1 = new Employee(1);

            LinkedList<Employee> list = new LinkedList<Employee>();

            Assert.That(list.GetHead(), Is.EqualTo(null));

            list.AddFirst(employee1);

            Assert.That(list.GetHead().Element, Is.EqualTo(employee1));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test AddFirst() method to ensure the head pointer is updated when many objects are inserted.
        /// </summary>
        [Test]
        public void AddFirst_on_larger_Existing_list_Head_Updated_Test()
        {
            Employee employee1 = new Employee(1);
            Employee employee2 = new Employee(2);
            Employee employee3 = new Employee(3);

            LinkedList<Employee> list = new LinkedList<Employee>();

            Assert.That(list.GetHead(), Is.EqualTo(null));

            list.AddFirst(employee1);
            list.AddFirst(employee2);
            list.AddFirst(employee3);

            Assert.That(list.GetHead().Element, Is.EqualTo(employee3));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test AddFirst() method to ensure the tail pointer is updated when first object is inserted.
        /// </summary>
        [Test]
        public void AddFirst_on_emptylist_Tail_Updated_Test()
        {
            Employee employee1 = new Employee(1);

            LinkedList<Employee> list = new LinkedList<Employee>();

            Assert.That(list.GetTail(), Is.EqualTo(null));

            list.AddFirst(employee1);

            Assert.That(list.GetTail().Element, Is.EqualTo(employee1));
           // Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test AddFirst() to ensure that the added node is added to the head position when more than one node is in the list.
        /// </summary>
        [Test]
        public void AddFirst_on_existinglist_count_increases_from_1_to_2_Test()
        {
            Employee employeeInList = new Employee(1);
            Employee addedEmployee = new Employee(2);

            LinkedList<Employee> list = new LinkedList<Employee>();
            Assert.That(list.GetSize(), Is.EqualTo(0));

            list.AddFirst(employeeInList);
            Assert.That(list.GetSize(), Is.EqualTo(1));

            list.AddFirst(addedEmployee);
            Assert.That(list.GetSize(), Is.EqualTo(2));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test AddFirst() method to ensure the head pointer is updated when many objects are inserted.
        /// </summary>
        [Test]
        public void AddFirst_on_larger_Existing_list_Tail_Updated_Test()
        {
            Employee employee1 = new Employee(1);
            Employee employee2 = new Employee(2);
            Employee employee3 = new Employee(3);

            LinkedList<Employee> list = new LinkedList<Employee>();

            Assert.That(list.GetHead(), Is.EqualTo(null));

            list.AddFirst(employee1);
            list.AddFirst(employee2);
            list.AddFirst(employee3);

            Assert.That(list.GetTail().Element, Is.EqualTo(employee1));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test AddFirst() to ensure it can handle null being added to list.
        /// </summary>
        [Test]
        public void AddFirst_null_element_is_allowed_Test()
        {
            LinkedList<Employee> list = new LinkedList<Employee>();

            list.AddFirst(null);

            Assert.That(list.GetSize(), Is.EqualTo(1));
            Assert.That(list.GetFirst(), Is.Null);
          //  Assert.Fail(); // you may delete this line after uncommenting the above code
        }
        #endregion

        #region GetFirst() and GetLast()

        /// <summary>
        /// Test that GetFirst throws an exception when called on an empty list, because Null.Element doesn't exist!
        /// </summary>
        [Test]
        public void GetFirst_on_emptylist_throws_exception_Test()
        {
            LinkedList<Employee> list = new LinkedList<Employee>();

            Assert.That(() => list.GetFirst(), Throws.Exception.TypeOf<ApplicationException>());
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test that GetFirst returns the head's element
        /// </summary>
        [Test]
        public void GetFirst_on_existinglist_returns_head_element_Test()
        {
            LinkedList<Employee> list = new LinkedList<Employee>();
            list.AddFirst(new Employee(1));

            Assert.That(list.GetHead().Element, Is.EqualTo(list.GetFirst()));
           // Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test that GetLast throws an exception when called on an empty list, because Null.Element doesn't exist!
        /// </summary>
        [Test]
        public void GetLast_on_emptylist_throws_exception_Test()
        {
            LinkedList<Employee> list = new LinkedList<Employee>();

            Assert.That(() => list.GetLast(), Throws.Exception.TypeOf<ApplicationException>());
          //  Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test that GetLast returns the tail's element
        /// </summary>
        [Test]
        public void GetLast_on_existinglist_returns_tail_element_Test()
        {
            LinkedList<Employee> list = new LinkedList<Employee>();
            list.AddFirst(new Employee(1));

            Assert.That(list.GetTail().Element, Is.EqualTo(list.GetLast()));
           // Assert.Fail(); // you may delete this line after uncommenting the above code
        }
        #endregion

        #region IsEmpty()
        /// <summary>
        /// Test IsEmpty() should return false on a list containing nodes.
        /// </summary>
        [Test]
        public void IsEmpty_returns_false_on_existinglist_Test()
        {
            Employee employee = new Employee(1);

            LinkedList<Employee> list = new LinkedList<Employee>();
            list.AddFirst(employee);

            Assert.That(list.IsEmpty(), Is.False);
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }
        #endregion

        #region Clear()
        /// <summary>
        /// Test that Clear() empties a list.
        /// </summary>
        [Test]
        public void ClearTest()
        {
            Employee employee1 = new Employee(1);
            Employee employee2 = new Employee(2);
            Employee employee3 = new Employee(3);

            LinkedList<Employee> list = new LinkedList<Employee>();

            list.AddFirst(employee3);
            list.AddFirst(employee2);
            list.AddFirst(employee1);

            Assert.That(list.GetSize(), Is.EqualTo(3));
            Assert.That(list.IsEmpty, Is.EqualTo(false));

            list.Clear();

            Assert.That(list.GetSize(), Is.EqualTo(0));
            Assert.That(list.IsEmpty, Is.EqualTo(true));
            //Assert.Fail(); // you may delete this line after uncommenting the above code
        }

        /// <summary>
        /// Test that calling Clear() on an empty list doesn't throw an exception.
        /// </summary>
        [Test]
        public void ClearEmptyListTest()
        {
            LinkedList<Employee> list = new LinkedList<Employee>();

            try
            {
                list.Clear();
            }
            catch (Exception)
            {
                Assert.Fail("Clear() should not have thrown exception.");
            }

            Assert.Pass("Clear() did not throw exception.");
            Assert.Fail(); // you may delete this line after uncommenting the above code
        }
        #endregion

        #region GetSize()
        /// <summary>
        /// Test GetSize() to make sure it returns the proper size; mostly for fun here. :)
        /// </summary>
        [Test]
        public void GetSize_returns_correct_value_after_random_adds_Test()
        {
            Random rnd = new Random();
            int numberOfElements = rnd.Next(1, 50);

            Employee employee = new Employee(1);
            LinkedList<Employee> list = new LinkedList<Employee>();

            for (int i = 0; i < numberOfElements; i++)
            {
                list.AddFirst(employee);
            }

            Assert.That(list.GetSize(), Is.EqualTo(numberOfElements));
           // Assert.Fail(); // you may delete this line after uncommenting the above code
        }
        #endregion

    }
}