using System;
using System.Collections.Generic;

namespace ListAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        { 
            var age = 20;
            var people = new string[2] { "James", "Wendy" };

            // Generics
            // Generics are PLACHOLDERS for the TYPE you want the class or 
            // METHOD/FUNCTION to use
            string message = GetMessage<bool>(true);
            string numberedMessage = GetMessage<double>(32);

            ListsExample();
            DictionaryExample();

            CreateAListOfNamesConsoleApp();
        }

        public static void ListsExample()
        {
            // Lists
            // collection of dynamic size, you the developer NEVER has to think about 
            // any size constraints!, this can have as little as ZERO elements, or as
            // much as 1_000_000_000_000.... elements... any size.
            List<string> names = new List<string>()
            {
                "Danny",
                "Ciarra",
                "Verkeia"
            };

            // Adding and removing stuff from a list
            names.Add("James");
            names.Add("Sam");
            names.Add("Jason");

            // This is an Array, arrays have a STATIC (fixed) length, which means
            // on creation, this specific array can ONLY contain THREE elements
            string[] otherNames = new string[] 
            {
                "Danny",
                "Ciarra",
                "Verkeia"
            };

            // otherNames[3] = "James";  <-- THIS WILL NOT WORK, because this array
            // can ONLY contain 3 elements, BUT elements in an array are ZERO indexed
            // which means, we only have access to index 0, 1, and 2.


            // Looping over our list with a FOR EACH Loop
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // looping over our array of other names!
            foreach (var otherName in otherNames)
            {
                Console.WriteLine(otherName);
            }


            // Passing our list of names as an ARGUMENT in this function!
            int numberOfEvenNames = GetNamesWithEvenLength(names);
        }

        private static void DictionaryExample()
        {
            // A dictionary is a collection of KEY VALUE pairs, both the KEY and the VALUE can
            // be of any type.  
            Dictionary<string, int> studentsAges = new Dictionary<string, int>();


            // Assigning the dictionary a key and value at the same time!
            // so in this instance, I'm assigning the KEY the VALUE 32
            studentsAges["Jerry"] = 32;
            studentsAges["Marc"] = 18;


            // Here I am GETTING the data out of the dictionary!
            Console.WriteLine(studentsAges["Jerry"]);

            studentsAges["Jerry"] = 33;
            Console.WriteLine(studentsAges["Jerry"]);

            // this is how you get a collection of ALL keys only
            var keys = studentsAges.Keys;

            // this is us looping over each key
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            // this is how you can get a collection of all Values!
            var values = studentsAges.Values;


            // this is the PREFERRED way to get a value out of a dictionary, always
            // TRY to get the value in case the key+value does NOT exist inside of
            // the dictionary!!!
            if (studentsAges.TryGetValue("Jerry", out int jerrysAge))
            {
                Console.WriteLine($"Jerry's age: {jerrysAge}");
            }
        }

        public static int GetNamesWithEvenLength(List<string> names)
        {
            int acc = 0;
            foreach (var name in names)
            {
                if (name.Length % 2 == 0)
                {
                    acc++;
                }
            }

            return acc;
        }

        public static string GetMessage<T>(T param)
        {
            return $"{param}";
        }


        private static void CreateAListOfNamesConsoleApp()
        {
            // we want to show a list of people, it will start with out empty...
            // and we want the user of our app to be able to add a person to our list.
            // we then want to give the user the option to change the name of a person
            // that they entered in said list.
            // and thats it, easy right?

            // Good job class, yall nailed it!

            // TODO, add a menu so the user CHOOSES whether they want to enter or modify a name
            Console.Clear();
            var people = new List<string>();
            var shouldContinueApp = true;
            while (shouldContinueApp)
            {
                PrintMenuAndNames(people);
                var userMenuSelection = Console.ReadLine();
                if (
                    uint.TryParse(userMenuSelection, out uint userSelection)
                    && userSelection < 4
                    ) 
                {
                    switch (userSelection)
                    {
                        case 1:
                            {
                                AddPersonToList(people);
                                break;
                            }
                        case 2:
                            {
                                ModifyNameInList(people);
                                break;
                            }
                        case 3:
                        default:
                            {
                                shouldContinueApp = false;
                                break;
                            } 
                    }

                }
                else
                {
                    Console.WriteLine("invalid option, try again buster!");
                }

                people.Sort();
            }
        }


        static void ListAllNames(List<string> people) 
        {
            if (people.Count > 0)
            {
                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("No names :(");
            }
        }

        private static void ModifyNameInList(List<string> people) 
        {
            Console.WriteLine("enter the name of the person you want to change");
            var personWeWantToModify = Console.ReadLine();

            if (people.Contains(personWeWantToModify))
            {
                people.Remove(personWeWantToModify);

                Console.WriteLine("what would you like the name to be instead?");
                var newName = Console.ReadLine();

                people.Add(newName);
            }
            else
            {
                Console.WriteLine("This Person does not exist in the list!");
            }
        }

        private static void PrintMenuAndNames(List<string> people)
        {
            Console.Clear();
            ListAllNames(people);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Choose one of the options");
            Console.WriteLine("[1] Add a name");
            Console.WriteLine("[2] Modify a name");
            Console.WriteLine("[3] Exit App");
        }

        private static void AddPersonToList(List<string> people)
        {
            while (true)
            {
                Console.WriteLine("Please enter a name");
                var person = Console.ReadLine();

                if (people.Contains(person))
                {
                    Console.WriteLine("This name already exists in this list, please enter a different name.");
                }
                else
                {
                    people.Add(person);
                    break;
                }
            }
        }
    }
}
