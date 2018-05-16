# Doubly-Linked-List
 A c# console application implementing linked lists methods and unit testing those.

Employee Class contains data to be manipulated by the linked list. It must contain an Employee ID number (an employee cannot be created without one), first and Last Name: Either both names will be provided or neither will be provided. Once created, employee fields cannot be changed and it implements the Comparable interface. The comparison of employees is based on the EmployeeID. When printed, an employee will appear as ‘id fname lname’ (e.g. ‘6782342 John Doe’ or ‘77853224 null null’).
	
Public Methods
Employee(employeeId) - Constructor, initializes only the employeeID, but sets the other fields to null, Employee(employeeId,firstName, lastName) - Constructor, initializes private fields using parameter values, getEmployeeID(), getFirstName(), getLastName(), compareTo()- Compares employes based on their EmployeeID value. Larger values are bigger than smaller values, toString() - Prints: employeeId firstName lastName


Node Class accepts any generic type as data. It returns the object in the same format as stored.It maintains two links per node (previous and next).
	
Public Methods: Node() - Constructor, initializes private fields to default values, Node(element) - Constructor, initializes only the passed parameter, Node(element, previousNode,nextNode) - Constructor, initializes private fields using parameter values, getElement() - returns the element (data), getPrevious() - Returns the reference to previous node, getNext() - Returns the reference to next node, setElement() - sets the element (data), setPrevious() - sets the reference to previous node, setNext() - sets the reference to next node


LinkedList Class is capable of accepting any object type. Returns the object in the same format as stored. It uses the objects ‘compareTo’ method to compare objects. It maintains two links that is Head – Points to the first node in the list (or null if there are no nodes) and Tail – Points to the last node in the list (or null if there are no nodes). It also Maintains Size – Count of the number of nodes in the list, zero when the list is empty. When initially created, the linked list object is empty.

		
Public Methods: LinkedList() - Constructor, initializes private fields, addFirst(element) - Creates a new Node with the new element and adds it to the head of the list, clear() - Empty all elements from the list, isEmpty() - Return true if the list is empty, else return false, getHead(), getTail(), getFirst() - Return the element in the head node. getLast() - Return the element in the tail node, getSize(),setFirst(element),setLast(element), addLast(element), removeFirst(), removeLast(), remove(position) - Remove the node at the numeric position specified, set(element, position) - Change specified node to element in parameter, addAfter(element,position), addBefore(element,position),addAfter(element, oldElement)	, addBefore(element,oldElement), get(element), remove(element), set(element,oldElement) - Change the element on the node containing the oldelement with the element passed and return the old element,
insert(element) - Add the element into the linked list in natural ascending order, sortAscending() - Sort the elements into ascending order.	


