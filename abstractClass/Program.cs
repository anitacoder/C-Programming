// See https://aka.ms/new-console-template for more information
//An abstract class is a class that cannot be instantiated, i.e you can not create an object of it, but you can only extend it, using the colon sign. Abstract classes also work with namespaces.
using System;

// namespace Abstraction {
//     public abstract class Customer {
//         public abstract void print();
//     }

//     public class Program : Customer {
//         public override void print() {
//             Console.WriteLine("print method");
//         }

//         public static void Main(string[] args) {
//             Customer obj = new Program();
//             obj.print();
//         }
//     }
// }

//Multiple Inheritance
// class A {
//     public virtual void print() {
//         Console.WriteLine("A implementation");
//     }
// }

// class B: A {
//     public override void print() {
//         Console.WriteLine("B implementation");
//     }
// }

// class C:A {
//     public override void print() {
//         Console.WriteLine("C implementation");
//     }
// }


// interface IB {
//     void printB();
// }

// interface IC {
//     void printC();
// }

// class D: A,IB,IC {
//     public override void print() {
//         Console.WriteLine("D implementation");
//     }

//     public void printB() {
//         Console.WriteLine("B implementation in D");
//     }

//     public void printC() {
//         Console.WriteLine("C implementation in D");
//     }
//     public void printA() {
//         Console.WriteLine("A implementation in D");
//     }
// }

// class Program {
//     static void Main(string[] args) {
//         A objA = new A();
//         A objB = new B();
//         A objC = new C();
//         A objD = new D();

//         objA.print(); 
//         objB.print(); 
//         objC.print(); 
//         objD.print(); 

//         D d = new D();
//         d.printB(); 
//         d.printC(); 
//         d.printA();
//     }
// }

using System;

class LivingThings {
    public virtual void stages() {
        Console.WriteLine("Stages of living things");
    }
}

class Animal : LivingThings {
    public virtual void print() {
        Console.WriteLine("Animal implementation");
    }
}

class Mammal : Animal {
    public override void print() {
        Console.WriteLine("Mammal implementation");
    }
}

class Human : Mammal {
    public override void print() {
        Console.WriteLine("Mammal implementation");
    }

    public override void stages() {
        Console.WriteLine("Human implementation");
    }
}

class Program {
    static void Main(string[] args) {
        Human h = new Human();
        h.print();  
        h.stages(); 
    }
}
