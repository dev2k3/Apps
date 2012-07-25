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
