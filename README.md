# Doubly-Linked-List
 A c# console application implementing linked lists methods and unit testing those.

Employee Class
•	Contains data to be manipulated by the linked list
•	Must contain an Employee ID number (an employee cannot be created without one).
•	First and Last Name: Either both names will be provided or neither will be provided.
•	Once created, employee fields cannot be changed.
•	Must implement the Comparable interface. The comparison of employees is based on the EmployeeID.
•	When printed, an employee will appear as ‘id fname lname’ (e.g. ‘6782342 John Doe’ or ‘77853224 null null’).
	
Public Method Name	    Description
Employee(employeeId)	  Constructor, initializes only the employeeID, but sets the other fields to null
Employee(employeeId,
firstName, lastName)	  Constructor, initializes private fields using parameter values
getEmployeeID()	        Returns the employeeID
getFirstName()	        Returns the firstName
getLastName()	          Returns the lastName
compareTo()	            Employees must be comparable with one another based on their EmployeeID value. Larger values are bigger than smaller values.
toString()	            Prints: employeeId firstName lastName


Node Class 
•	Accepts any generic type as data. It returns the object in the same format as stored.
•	Maintains two links per node (previous and next).
•	Use appropriate SMART properties in C# or getter/setters for these fields
	
Public Method Name	    Description
Node()	                Constructor, initializes private fields to default values
Node(element)	          Constructor, initializes only the passed parameter
Node(element, 
previousNode,nextNode)	Constructor, initializes private fields using parameter values
getElement()	          Returns the element (data)
getPrevious()	          Returns the reference to previous node 
getNext()	              Returns the reference to next node
setElement()	          sets the element (data)
setPrevious()	          sets the reference to previous node 
setNext()	              sets the reference to next node


LinkedList Class
•	Capable of accepting any object type. Returns the object in the same format as stored.
•	Must be able to use the objects ‘compareTo’ method to compare objects. (Hint: How can you enforce that your generic type specified is a comparable object?)
•	Maintains two links
o	Head – Points to the first node in the list (or null if there are no nodes).
o	Tail – Points to the last node in the list (or null if there are no nodes).
•	Maintains Size – Count of the number of nodes in the list, zero when the list is empty.
•	When initially created, the linked list object is empty.

		
Public Method Name	    Description	Milestone
LinkedList()	          Constructor, initializes private fields	
addFirst(element)	      Creates a new Node with the new element and adds it to the head of the list.	
clear()	                Empty all elements from the list	
isEmpty()	              Return true if the list is empty, else return false	
getHead()             	Return the head node	
getTail()	              Return the tail node	
getFirst()	            Return the element in the head node	
getLast()             	Return the element in the tail node	
getSize()	              Return the count of the number of nodes in the list	
setFirst(element)	      Set head node element to parameter value	
setLast(element)	      Set tail node element to parameter value	
addLast(element)	      Adds new element to the tail of the list	
removeFirst()	          Remove the head node	
removeLast()	          Remove the tail node	
remove(position)	      Remove the node at the numeric position specified	
set(element, position)	Change specified node to element in parameter 	
addAfter(element,
position)	              Add new element after the node at the provided position.	
addBefore(element,
position)	              Add new element before the node at the provided position.	
addAfter(element, 
oldElement)	            Add new element after the node containing the ‘oldelement’ specified	
addBefore(element,
oldElement)	            Add new element after the node containing the ‘oldelement’ specified	
get(element)	          Return the element in the node containing the element specified	
remove(element)	        Remove the node containing the element specified	
set(element,oldElement) Change the element on the node containing the oldelement with the element passed and return the old element	
insert(element)	        Add the element into the linked list in natural ascending order.
sortAscending()	        Sort the elements into ascending order.	


