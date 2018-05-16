using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    /// <summary>
    /// Class to maintain count of nodes and two links per node
    /// </summary>
    /// <typeparam name="T">Any generic type of data</typeparam>
    public class LinkedList<T> where T : IComparable<T>
    {
        private Node<T> Head;
        private Node<T> Tail;
        private int count;

        /// <summary>
        /// Constructor to initialize the private fields to default values
        /// </summary>
        public LinkedList()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        /// <summary>
        /// Creates a new node with new elements and adds it to the head of the list
        /// </summary>
        /// <param name="element">The element to be placed in the node</param>
        public void AddFirst(T element)
        {
            Node<T> node = new Node<T>(element);

            if (Head == null)
            {
                Head = node;
                Tail = node;                
            }
            else
            {
                Head.Previous = node;
                node.Next = Head;
                Head = node;
            }
            count++;

        }

        /// <summary>
        /// Empties out all the elements from the list
        /// </summary>
        public void Clear()
        {
            count = 0;
            Head = null;
            Tail = null;
        }

        /// <summary>
        /// Returns the count of number of nodes int he list
        /// </summary>
        /// <returns>Count of number of nodes in the list</returns>
        public int GetSize()
        {
           return this.count;
            
        }

        /// <summary>
        /// Returns the head node, the first node, of the list
        /// </summary>
        /// <returns>The head of the node</returns>
        public Node<T> GetHead()
        {
            return this.Head;
        }

        /// <summary>
        /// Returns the tail, the last node of the list
        /// </summary>
        /// <returns>The tail node of the linked list</returns>
        public Node<T> GetTail()
        {
            return this.Tail;
        }

        /// <summary>
        /// Checks if the list is empty
        /// </summary>
        /// <returns>The list is empty or not</returns>
        public bool IsEmpty()
        {
            return count == 0;
            //if (this.count == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        /// <summary>
        /// Returns the element in the head node
        /// </summary>
        /// <returns>The element in head node</returns>
        public T GetFirst()
        {
            if (IsEmpty())
            {
                // No such element exception.
                throw new ApplicationException();
            }
            return Head.Element;
        }

        /// <summary>
        /// Returns the element in the tail node
        /// </summary>
        /// <returns>The element in tail node</returns>
        public T GetLast()
        {
            if (count == 0)
            {
                // No such element exception.
                throw new ApplicationException();
            }
            return Tail.Element;
        }
    }
}
