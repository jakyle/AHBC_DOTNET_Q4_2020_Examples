using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringsAndRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "James";


            // Strings are read-only, which means the chars inside of a string CANNOT be changed!
            char i = 'i';

            char otherI = i;
            // name[1] = i;

            // String concatenation

            string surname = "Jackson";


            string fullName = name + " " + surname;

            string otherName = surname;


            // Referency Types
            char[] letters = new char[5] { 'a', 'b', 'c', 'd', 'e'};

            char[] otherLetters = letters;

            otherLetters[4] = 'z';

            Console.WriteLine(letters[4]);
 
            Console.WriteLine(name);

            // Strings for real this time.

            // string creation
            string firstFewLetters = new string(letters);

            string repeated = new string('a', 5);

            string newString = string.Empty;

            // combining strings
            string combinedString = $"{fullName} {firstFewLetters}"; // My preferred way!

            int age = 21;

            string message = age >= 21 ? "come on in" : string.Empty;

            string otherCombinedString = string.Concat("{1}, {2}", message, firstFewLetters);

            // string Actual Literal
            string nonLiteral = "\n";

            // if you do not want to consider your backslashes AND if you want the string to connsider
            // spaces and returns, ie. new lines, you want to use a string literal.
            string literal = @"\n    ";

            string interopLiteral = $@"sup dude {message}";

            // string equality

            bool isEqualStringOne = "hello" == "HeLlO".ToLower();

            // preferred way
            bool isEqualStringTwo = "hello".Equals("HeLlO", StringComparison.OrdinalIgnoreCase);

            // general Methods


            // IndexOf
                             //012345678
            string campbell = "Campbellbell";
            int indexOfBell = campbell.IndexOf("bell");

            int lastIndexOfBell = campbell.LastIndexOf("bell");

            bool endsWithJack = campbell.EndsWith("jack");
            bool endsWithBell = campbell.EndsWith("bell");
            bool startsWithCamp = campbell.StartsWith("Camp");
            bool startsWithBell = campbell.StartsWith("bell");

            string otherFullName = fullName;

            string changedFirstName = fullName.Replace("James", "Cheese");


            string lotsOfWhiteSpaces = "James       Jackson     ";
            string[] allLettersOfName = changedFirstName.Split();
            string[] firstNameLastNameSplit = changedFirstName.Split(" ");
            string[] superSplit = lotsOfWhiteSpaces.Split();

            string trimmedWhiteSpace = lotsOfWhiteSpaces.Replace("       ", " ");


            const string CHEESE = "Cheese";
            // SubString
            if (changedFirstName.ToLower().Contains(CHEESE)) 
            {
                int indexOfCheese = changedFirstName.IndexOf(CHEESE);
                string cheeseForRealThisTimeDude = changedFirstName.Substring(indexOfCheese, 6);
            }

            // StringBuilder
            StringBuilder stringBuilder = new StringBuilder(); 

            
            for (int j = 0; j < 100; j++)
            {
                stringBuilder.Append($"First Number: {j}, ");
            }

            string finalString = stringBuilder.ToString();


            // RegEx

            Regex phoneNumberPattern = new Regex(@"^((\d{3}-)|(\(\d{3}\)(-| )))?\d{3}-\d{4}$");

            Console.WriteLine("please insert a valid phone number");
            string phoneNumber = Console.ReadLine();

            string badPhoneNumber = "lol, I'm not a number ;)";

            if (phoneNumberPattern.IsMatch(phoneNumber))
            {
                Console.WriteLine("This is a valid number");
            }

            if (!phoneNumberPattern.IsMatch(badPhoneNumber)) 
            {
                Console.WriteLine("this is a bad phone number :(");
            }


            Console.ReadLine();
        }
    }
}
