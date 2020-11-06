using System;
using System.Collections.Generic;

namespace Static_keyword_class_example
{
    class Program
    {
        static void Main(string[] args)
        {


            string staticMessage = Example.StaticMessage();


            Console.WriteLine(staticMessage);


            var example = new Example();
            example.Number = 4;

            var example1 = new Example();
            example1.Number = 22;

            var example2 = new Example();
            example2.Number = 99;

            var example3 = new Example();
            example3.Number = 129;

            var example4 = new Example();
            example4.Number = 2222;

            var examples = new List<Example>();
            examples.Add(example);
            examples.Add(example1);
            examples.Add(example2);
            examples.Add(example3);
            examples.Add(example4);

            foreach (var ex in examples)
            {
                ex.LogNumberTimesTwo();
            }

            var exampleDupe = example;

            string nonStaticMessage = example.NonStaticMessage();


            Console.ReadLine();


            // Grocery Store!!!!
            var groceryStoreItems = new List<GroceryItemBase>();
            groceryStoreItems.Add(new Milk());
            groceryStoreItems.Add(new Bread());
            groceryStoreItems.Add(new Steak());


            foreach (var groceryStoreItem in groceryStoreItems)
            {

            }

        }
    }


    public class Example 
    {
        // ANY NON STATIC MEMBERS ARE INSTANCE MEMBERS!!!!! (any member that does NOT contain the static keyword)

        // INSTANCE property
        public int Number { get; set; } = 2;


        // static methods can be accessed WITHOUT creating an Example Object into memory, HOWEVER, this method will NOT 
        // have access to ANY INSTANCE MEMBERS!!!!
        public static string StaticMessage()
        {

            return $"I am a static method";
        }

        public void LogNumberTimesTwo() 
        {
            var numTimesTwo = MultiplyByTwo(this.Number);
            Console.WriteLine(numTimesTwo);
        }

        // INSTANCE method (you need to create an example object in memory to access this...)
        public string NonStaticMessage()
        {
            var staticMethod = StaticMessage();
            return "I am not a static method";
        }

        // STATIC methods, are NOT INSTANCE MEMBERS, they exist into MEMORY the MOMENT you START YOUR PROGRAM!
        private static int MultiplyByTwo(int x)
        {
            return x * 2;
        }

    }


    public abstract class GroceryItemBase
    {
        public double Price { get; set; }
        public string Name { get; set; }
    }

    public class Bread : GroceryItemBase
    {
        public bool IsWholeGrain { get; set; }
    }

    public class Milk : GroceryItemBase
    {
        public bool IsTwoPercent { get; set; }
    }

    public class Steak : GroceryItemBase
    {
        public bool IsRibEye { get; set; }
    }

    public class Egg : GroceryItemBase
    {
        public bool IsJumbo { get; set; }
    }

}
