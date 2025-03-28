using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public static class AccessSpecifier
    {
        public static void specify()
        {
            AbsChild absChild = new AbsChild();
            absChild.Add(10, 5);
            absChild.Sub(10, 5);
            absChild.Mul(10, 5);
            absChild.Div(10, 2);
            Console.WriteLine(AbsChild.word);

            //can create this 
            AbsParent absParent = absChild;
            //but not this 
            //AbsParent absParent = new AbsParent();

            //Accessing methods using reference
            absParent.Add(10, 5);
            absParent.Sub(10, 5);
            absParent.Mul(10, 5);
            absParent.Div(10, 2);
            //You cannot call the Mod method using Parent reference as it is a pure child class method
            //absParent.Mod(100, 35);
            //need 
            //working with different child classes through a common interface
            //want to restrict object creation but still define common functionality.


            //MultipleInheritanceTest obj = new MultipleInheritanceTest();
            //obj.Test();
            //You cannot call the Show method using obj
            //obj.Show();
            //Using Interface Reference call the Show method
            //Interface1 i1 = obj;
            //i1.Show();
            //Typecase the object to interface type and call the show method
            //((Interface2)obj).Show();

        }
    }
    public abstract class AbsParent
    {
        public static int word = 2;
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }

    public class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is : {x / y}");
        }
        public void Mod(int x, int y)
        {
            Console.WriteLine($"Modulos of {x} and {y} is : {x % y}");
        }
    }
}

//in general classes, structs, enums, interfaces, and delegates are called types,
//and variables, properties, constructors, methods, etc.
//that normally reside within a type are called type members.
//so by default types are internal and type members are private 
//and in types only internal and public are allowed while in type members all 6 are allowed

//private can only be used within the same class and in its own public methods
//private members can't be used in derived classes
//internal class can't be inherited
//Encapsulation Hides the internal state and functionality of an object and
//only allows access through a public set of functions.
//If we provide direct access to the balance variable,
//it is impossible to validate the given amount value before storing it in the balance variable.

//in interfaces all the methods defined must be elaborated and can't define method body in interface
//If the constructor is protected, you can only instantiate the class inside a derived class.
//if no access specifier written then by default it is private

//if child constructor is parameterless and parent is parametrized then responsibility of developer
//to explicitely call the parent constructor using child constructor : base();
//this is dynamic passing of parameter in parent constructor public child(int num):base(num)

//specialization is something is already existing and then we are deriving something
//from that existing one by adding some extra features. 
//example of generalization is shapes as it is virtual and square,rectangle and circle are real and derived from it.

//non-abstract class only non-abstract methods, abstract class both abstract as well as non-abstract methods
//every single abstract method to be overriden
//An abstract class cannot be instantiated
//constructors in abstract class are going to be called when child object is created so constructors can be created
//by default interface methods are abstract and public

//class Parent
//{
//    public void Show() // No 'virtual' keyword
//    {
//        Console.WriteLine("Parent Show");
//    }
//}
//class Child : Parent
//{
//    public void Show() // No 'override', just a new method with the same name
//    {
//        Console.WriteLine("Child Show");
//    }
//}
//Parent obj1 = new Parent();
//obj1.Show(); // Output: Parent Show
//Child obj2 = new Child();
//obj2.Show(); // Output: Child Show
//Parent obj3 = new Child();
//obj3.Show(); // Output: Parent Show ❌ (No overriding happened)
//if we use virtual in parent and override in child then it will give child show in 3rd

//virtual is used for overriding,sealed is used in class to prevent inheritance and in method 
//to prevent further overriding
//public sealed override void Display() // Overriding & Sealing
//{
//    Console.WriteLine("Derived Display");
//}
//in virtual it is re-implemented and in abstract it is mandatory implemented

//interfaces cannot have constructors
//default scope for an interface’s members is public, whereas it is private in the case of a class.
//Interfaces cannot contain fields 
//An interface can contain--Abstract methods, Properties, Indexes, Events
//An interface cannot contain-- Non-abstract functions, Data fields, Constructors, Destructors.
//Interface can inherit another interface
//We cannot create an instance of an interface, but we can create a reference of an interface.
//ITestInterface1 obj = new ImplementationClass();
//now this reference can only invoke interfaces methods
//this is explicit declaration of interface in child class without public access specifier
//void interface.method(args){};
//interface cannot implement or say inherit an abstract class. An interface may only extend a super interface.
//However, an abstract class can implement an interface because an abstract class
//can contain both abstract methods and concrete methods.
//not permitted to declare an interface as sealed;
//not necessary for a class that implements an interface to implement all its methods, only in the case
//that class is declared is abstract and the non - implemented methods are declared as abstract
//The interface is a fully un - implemented class while abstract class is a partially implemented class.

//Implement Each Interfaces Method Separately
//public interface Interface1
//{
//    void Test();
//    void Show();
//}
//public interface Interface2
//{
//    void Test();
//    void Show();
//}
//public class MultipleInheritanceTest : Interface1, Interface2
//{
//    //Normal Implementation
//    public void Test()
//    {
//        Console.WriteLine("Test Method is Implemented in Child Class");
//    }
//    //Explicit Interface Implementation
//    void Interface1.Show()
//    {
//        Console.WriteLine("Interface1 Show Method is Implemented in Child Class");
//    }
//    //Explicit Interface Implementation
//    void Interface2.Show()
//    {
//        Console.WriteLine("Interface2 Show Method is Implemented in Child Class");
//    }
//}

//Return Type is not considered as part of Method Overloading
//assignment operators can not be overloaded
//conditional logical operators cannot be overloaded directly
//Overriding the Virtual Method is Optional in C#

//we can execute the superclass method if it is overridden in the sub-class
//1. By creating the parent class object under the child class, 
//we can call the parent class methods from the child class
//2. or by using the base keyword, we can call parent class methods from the child class,
//but this and the base keyword cannot be used under the static block.
//class Parent
//{
//    public virtual void show()
//    {
//        Console.WriteLine("Parent claled");
//    }
//}
//class Child : Parent
//{
//    public override void show()
//    {
//        base.show();
//        Console.WriteLine("Child Constructor Called");
//    }
//}

//In Method Hiding/Shadowing, the child classes can re-implement any method of its parent class methods
//even if they are not declared as virtual.
//That means here the child class re-implements the parent class methods without taking any permission
//from its parent.
//We can hide both virtual and non-virtual methods under the child class using new keyword
//hiding methods are pure child class memebers and therefore no child invoked, with parent reference and child instance
//if a Parent class reference variable is created using the Child class object reference,
//then using that Parent reference we can call the Child class overriding methods but
//we cannot call the child class hiding methods.

//public partial class PartialEmployee
//we can use like this same in every file and can divide the class
//all classes contain same access specifier and all contain partial
//If any of the parts are declared as abstract, sealed or inherits
//then the entire type is considered as abstract, sealed or inherited
//multiple parts must not inherit different base classes but can inherit different interfaces

//A partial class may contain a partial method.
//One part of the class contains the signature of the method.
//An implementation of the Partial Method can be defined in the same part
//or other parts of the Partial Class. If the implementation is not supplied,
//then the method and all calls to the partial method are removed by the compiler
//at the time of compilation.
//implementation of a partial method is optional.
//partial void PartialMethod();
//Partial methods in C# are private by default and give error other than this
//Partial method declaration and implementation should not be at the same time. 
//A partial method return type must be void
//A partial method must and should be declared within a partial class or partial struct.
//A non-partial class or struct cannot include partial methods.
//signature of the partial method declaration must match the signature of the implementation 
//A partial method can be implemented only once either in the same part or in other parts of the partial class.
//public sealed override void Show() { }
//this is method overriding prevented by using sealed
//The private method is not inherited whereas the sealed method is inherited but cannot be overridden




//interface last para