We have a number of items we want to place in order.
Each item can fall into one of four categories:
- unnamed without dependencies
- unnamed with dependencies
- named without dependencies
- named with dependencies

If an item is named other items that have dependencies can depend on it by name

Write a framework for defining items and a function that takes items on a given type
and return them in an order such that items with dependencies come later in the order
than the item or items they depend on.


1) complie the program
2) create a CSV file first where first column is an item and others are dependencies
example:
it1,A,B,C    
it2
B,A
,
,C,D,A

Pass the full path as command line argument to the exe file
