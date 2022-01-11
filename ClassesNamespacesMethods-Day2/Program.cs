// See https://aka.ms/new-console-template for more information
using ClassesNamespacesMethods_Day2.Pets;


// namespaces 

var dog1 = new Dog(); // must import using "using" since it is in a seperate namespace.

dog1.FurType = "short"; // this is the setter to the type

Console.WriteLine(dog1.FurType); //this is a case of getting the type

dog1.Name = "Fido";
dog1.Breed = "Pitbull";
dog1.Weight = 74.5;
//dog1.DateOfBirth = DateTime.Now.AddDays(-1000);
dog1.SetDateOfBirth(DateTime.Now.AddDays(-1000)); // way of setting private sett

Console.WriteLine($"{dog1.Name} is a {dog1.Breed} with {dog1.FurType} fur and weighs {dog1.Weight} pounds.");

Dog dog2 = new Dog();
dog2.FurType = "long";
dog2.Name = "Astro";
dog2.Breed = "Husky";
dog2.Weight = 1.2;

Console.WriteLine($"{dog2.Name} is a {dog2.Breed} with {dog2.FurType} fur and weighs {dog2.Weight} pounds.");

dog2.Bark(); // activating the method that was created. It also has access to the properties in the Bark() Method so the name can be printed.

Console.WriteLine($"{dog1.Name} is {dog1.Age} years old.");
