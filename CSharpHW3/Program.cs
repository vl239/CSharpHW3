// Virginia Lu, C# Assignment 3

// OBJECT-ORIENTED PROGRAMMING

// TEST YOUR KNOWLEDGE

// 1. What are the six combinations of access modifier keywords and what do they do?
//      - Access modifiers are keywords that define the accessibility of a member, class or datatype in a program. These are mainly used to restrict unwanted data manipulation by external programs or classes.
//      - Public: accessible everywhere
//      - Protected: accessible in the same class or derived class
//      - Internal: accessible  in the same assembly
//      - Private: accessible only in current class
//      - Protected internal: accessible only in the current assembly or types derived from the containing class
//      - Private protected: accessible by types derived from the containing class, but only within its containing assembly

// 2. What is the difference between the static, const, and readonly keywords when applied to a type member?
//      - const:
//          - defines a constant variable / compile-time constant
//          - must assign a value at the time of declaration
//          - immutable; value assigned to it cannot be changed later
//          - cannot be used to create an object; can only be applied to primitive data types and strings
//      - readonly:
//          - defines a variable or object as readable only
//          - can only be assigned a value at class level or in a constructor
//          - can only change the value in the constructor method
//      - static:
//          - can define a variable, method, or object
//          - member belongs to the type of the object, not the instance itself; they are accessed by the class name and not the instance's name (i.e. ClassName.StaticMember, not InstanceName.StaticMember)
//      * Use the readonly keyword when you are not sure whether the value of a variable of an object needs to change but you want to prevent other classes from changing the value
//      * Use the readonly keyword when you are not sure whether the value of a variable of an object needs to change but you want to prevent other classes from changing the value
//      * Use the static keyword when you want the member of a class to belong to the type rather than to the instance of the type

// 3. What does a constructor do?
//      - creates an object of the class and initialize class members

// 4. Why is the partial keyword useful?
//      - It provides a special ability to implement the functionality of a single class into multiple files
//      - A use case for example, when working with automatically generated source, the code can be added to the class without having to recreate the source file

// 5. What is a tuple?
//      - A tuple is a data structure that contains a sequence of elements of different data types. It can be used where you want to have a data structure to hold an object with properties, but you don't want to create a separate type for it.

// 6. What does the C# record keyword do?
//      - defines a reference type that provides built-in functionality for encapsulating data

// 7. What does overloading and overriding mean?
//      - Overloading is a compile time form of polymorphism where there are multiple methods in the same class, with same method name and access modifiers, but different input or output parameters
//      - Overriding is a runtime form of polymorphism and occurs between a base class and its derived class, with same method name and access modifiers and input parameters, but different implementations for the same methods

// 8. What is the difference between a field and a property?
//      - A field is a variable of any type that is declared directly in the class while property is a member that provides a flexible mechanism to read, write or compute the value of a private field.

// 9. How do you make a method parameter optional?
//      - Set a default value for the optional parameter
//      - Use method overloading
//      - Use OptionalAttribute

// 10. What is an interface and how is it different from abstract class?
//      - An interface defines a contract which is implemented by the derived class
//      - An interface supports multiple inheritance, abstract class does not
//      - An interface cannot have an instanced constructor, abstract class can
//      - An interface has by default all members abstract and public,  abstract class can have abstract and concrete members
//      - An interface cannot have fields, abstract class can

// 11. What accessibility level are members of an interface?
//      - public and abstract

// 12. Polymorphism allows derived classes to provide different implementations of the same method.
//      - True

// 13. The override keywork is used to indicate that a method in a derived class is providing its own implementation of a method.
//      - True

// 14. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
//      - Falso

// 15. Abstract methods can be used in a normal (non-abstract) class.
//      - False

// 16. Normal (non-abstract) methods can be used in an abstract class.
//      - True

// 17. Derived classes can override methods that were virtual in the base class.
//      - True

// 18. Derived classes can override methods that were abstract in the base class.
//      - True

// 19. In a derived class, you can override a method that was neither virtual nor abstract in the base class.
//      - False

// 20. A class that implements an interface does not have to provide an implementation for all the members of the interface.
//      - False

// 21. A class that implements an interface is allowed to have other members that arent defined in the interface.
//      - True

// 22. A class can have more than one base class.
//      - False

// 23. A class can implement more than one interface.
//      - True


// -------------------------------------------------------------------


using WorkingWithMethods;
using ColorAndBall;

// WORKING WITH METHODS

Console.WriteLine("Working With Methods:");

// Problem 1
Console.WriteLine();
Console.WriteLine("Problem One:");
Console.WriteLine("Input length of randomly generated array of integers:");
int n = Convert.ToInt32(Console.ReadLine());

int[] numbers = ProblemOne.GenerateNumbers(n);

Console.WriteLine("Before reversal:");
ProblemOne.PrintNumbers(numbers);

ProblemOne.Reverse(numbers);

Console.WriteLine("After reversal:");
ProblemOne.PrintNumbers(numbers);


// Problem 2
Console.WriteLine();
Console.WriteLine("Problem Two:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(ProblemTwo.Fibonacci(i));
}


// -------------------------------------------------------------------


// DESIGNING & BUILDING CLASSES USING OOP

// Problems 1-6
Console.WriteLine();
Console.WriteLine("Designing & Building Classes using OOP: See files for classes created");

// Problem 7
Console.WriteLine();

Color red = new Color(255, 0, 0);
Color green = new Color(0, 255, 0);
Color blue = new Color(0, 0, 255);

Ball a = new Ball(2, red);
Ball b = new Ball(3, green);
Ball c = new Ball(8, blue);

a.Throw();
b.Throw();
c.Throw();

a.Throw();
b.Throw();
c.Throw();

a.Throw();
b.Throw();
c.Throw();

a.Throw();
b.Throw();
c.Throw();

a.Pop();

a.Throw();
b.Throw();
c.Throw();

a.Throw();
b.Throw();
c.Throw();

c.Pop();

a.Throw();
b.Throw();
c.Throw();

a.Throw();
b.Throw();
c.Throw();

Console.WriteLine($"Ball a was thrown {a.ThrowCount} time(s).");
Console.WriteLine($"Ball b was thrown {b.ThrowCount} time(s).");
Console.WriteLine($"Ball c was thrown {c.ThrowCount} time(s).");


