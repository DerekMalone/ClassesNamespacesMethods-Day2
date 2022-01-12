using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNamespacesMethods_Day2.Pets
    // 4 Pillars of Object Oriented Programming
      // Abstraction Polymorphism, Inheritance, **Encapsulation**
          // ** Classes are an example of 

{
    internal class Dog // internal is similar to private but it limits to only this project seeing it. 
                       // other access modifiers are: public (allows access from anywhere), sealed (limited inheratance allowed),
                                                     // abstract (only another class can inherite from this) private(rarely used)
    {
        // *properties - TitleCase
        // auto property - has a plain getter/setter
             // Properties are private by default but can also be: public, readonly
        // class is a custom type thus "Dog" is now a type.
        // any custom property or type we add must be defined by us.

        //access modifier -> public and private. Public can be accessed outside of class. Private can be accessed only inside of class
        // type
        // name
        // getter & setter 
        public string FurType { get; set; } // <-- this is a c# property on a class
        //string FurType { get; set; } // <-- this is inharently private

        public string Name { get; set; } // when defining properties you must use explicit types
        public double Weight { get; set; }
        public string Breed { get; set; }

        public DateTime DateOfBirth { get; private set; } // can have a private setter that can only be done from within the class.
        // calculated property
        public int Age { 
            get
            {
                return (DateTime.Now - DateOfBirth).Days / 365;
            }
        }

        // Fields - for private values needed by the class, but not needed outside the class
           // does not require a git or set
           // access modifier of private, a type, and a name
           // name starts with an "_" then is camel case
        private bool _isFertile;

        // methods - TitleCase
        //access modifier
             // type
                     // name
                            // code
       public void Bark() // "void" is what we use when a method does not return anything but it does something
                                // can also use any type or another Class if needed. (i.e. Dog, int, double, string, decimal...)
        {
            Console.WriteLine($"{Name} says \"Woof Woof\"");  // this is doing something but does not return anything.
        }

        public void SetDateOfBirth(DateTime dob)
        {
            DateOfBirth = dob;
        }

        public int GiveBirth() // if this does not use any properties or fields in the class, we can make this method "static" prior to the int
                                    // static method is used across ALL instances and as such, you do not need to create an instance.
        {
            int numOfPuppies = new Random().Next();
            if (_isFertile)
            {
                return numOfPuppies;
            }
            else
            {
                return 0;
            }
        }

    }
}
