using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF STATEMENT REVIEW


            Console.WriteLine("hey, can you please provide some sort of input???");

            string userNameOrWhatever = Console.ReadLine();

            bool isTrue = true;
            if (isTrue)
            {
                // code will run here if the statement in the if "params" == true
            }
            else
            {
                // if false, then we will run this scope (or block) of code 
            }

            // CASTING REVIEW

            // explicit casting, you have to tell the compiler that you are casting!
            double numOne = 22.34;
            int numTwo = (int)numOne;
            
            // implicit casting, where you can cast without the compiler freaking out
            numOne = numTwo;


            // not casting, we are parsing out the number 13 from this string, think of it like converting!
            string imANumberISwear = "13";
            int actuallyANumber = int.Parse(imANumberISwear);


            // SWITCH CASES
            int switchNum = 5;


            // the pattern: anytime you want to check if a value can == many values!
            if (switchNum == 2)
            {
                // do this
            }
            else if (switchNum == 5)
            {
                // do thing
            }
            else if (switchNum == 7)
            { 
                // do thing
            }
            else
            {
                // this will always happen
            }

            // the actual switch case, same as above!
            switch (switchNum)
            {
                case 2:
                {
                    Console.WriteLine("this is the number two!");
                    break;
                }
                case 5:
                {
                    Console.WriteLine("This is the number 5!");
                    break;
                }
                case 7:
                {
                    Console.WriteLine("This is the number SeVeN... WOAH!");
                    break;
                }
                default:
                {
                    Console.WriteLine("I was not looking for this number");
                    break;
                }
            }

            // TERENARY OPERATOR - anytime you want to assign a variable a value a specific value based
            // on a boolean expression!
            double pi = 3.14;

            // the pattern
            string pastry = string.Empty;
            if (pi <= 3.14)
            {
                pastry = "Pie";
            }
            else
            {
                pastry = "Cake";
            }

            // the actual terenary operator, three parts
            // 1. the boolean expression
            // 2. the '?' operator, so if the condition is true, assign the variable anything after the colon
            // 3. the ':' operator, if false, assign the variable anything after the colon instead.
            string tasteyPastry = pi <= 3.14
                ? "Pie"
                : "Cake";

            // #### LOOOPS ####
            //
            // WHILE LOOPS

            int count = 0;

            while (count <= 10)
            {
                Console.WriteLine($"Our Current Number is: {count}");
                count++;
            }

            // user ending loop for us!

            bool isLooping = true;

            while(isLooping)
            {
                Console.WriteLine("Hey, do you want to keep looping my dude?");

                string userLoopInput = Console.ReadLine();

                if (userLoopInput.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    isLooping = false;
                    Console.WriteLine("Thank you for being a friend ;)");
                }
            }

            do
            {
                Console.WriteLine("Hey, do you want to keep looping my dude?");

                string userLoopInput = Console.ReadLine();

                if (userLoopInput.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    isLooping = false;
                    Console.WriteLine("Thank you for being a friend ;)");
                }

            } while (isLooping);

            Console.ReadLine();
        }
    }
}
