This is the Readme.md for HW5 CTL406  - Dependency Injection

1. How Does Dependency Injection help to write 'Clean code'? 
Dependency Injection allows users to pass in abstract or undefined dependencies so classes can compile and be tested now even if their dependency isnt fully implemented yet. It also allows for the dependency to be generic so it can be replaced with any of its children later in development. 

2. For your final project, how can you use Inversion of Control in your application?
By having the classes use an interface, this allows other classes to be able to call different versions of the same method depending on parameters and variables. This allows for multiple classes to call the same method or call and the interface limitation sorts out which class that implements the interface it should be using. 

3. What is the Explicit Dependencies Principle? 
It is the idea that you pass objects as arguments instead of having each method or class initialize the objects within the methods themselves. This allows for more 'clean code' and a better time overall testing code for bugs. 
