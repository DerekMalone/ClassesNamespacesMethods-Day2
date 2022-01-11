using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNamespacesMethods_Day2.Pets
{
    internal class Dog // internal is similar to private but it limits to only this project seeing it. 
        // writing in public will make it public.
    {
        // properties - TitleCase
        // auto property - has a plain getter/setter
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

        // methods - TitleCase
        //access modifier
             // type
                     // name
                            // code
       public void Bark() // "void" is what we use when a method does not return anything but it does something
        {
            Console.WriteLine($"{Name} says \"Woof Woof\"");  // this is doing something but does not return anything.
        }

        public void SetDateOfBirth(DateTime dob)
        {
            DateOfBirth = dob;
        }

    }
}
