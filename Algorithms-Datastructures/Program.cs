using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Structures 

            LearnStack();
            MyFuncOne();
            MyLinkedList();

            // Algorithm 
            var numbers = new List<int>() 
            {
                3,5,2,8,3,9,0,7
            };


            BubbleSort(numbers);


            // HackerRank

        } 


        // O(n) noation, your input will == your "n" variable 

        // n * n == n^2
        static void BubbleSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < numbers.Count - i - 1; j++)
                {
                    var rightNumber = numbers[j + 1];
                    var leftNumber = numbers[j];

                    if (leftNumber > rightNumber)
                    {
                        numbers[j] = rightNumber;
                        numbers[j + 1] = leftNumber;
                    }
                }
            }
        } 

        static void AddTwoNumbersThenDisplay(int x, int y)
        {
            var sum = x + y;
            Console.WriteLine(sum);
        }


        static void LearnStack()
        {
            var nameStack = new Stack<string>();


            nameStack.Push("Sam");
            nameStack.Push("Mike");
            nameStack.Push("Albert");

            nameStack.Pop();
            var name = nameStack.Pop();

            Console.WriteLine(name);
        } 

        static void LearnQueue()
        {

            var linkedList = new LinkedList<string>();
            
            var nameQueue = new Queue<string>();

            nameQueue.Enqueue("Dylan");
            nameQueue.Enqueue("Danny");
            nameQueue.Enqueue("Adryenne");

            var removedName = nameQueue.Dequeue();

            Console.WriteLine(removedName);
        }

        static void MyLinkedList()
        {
            var linkedList = new LinkedList<string>();
            linkedList.InsertFront("Candace");
            linkedList.InsertFront("Darshan");

            linkedList.InsertLast("Sam"); 
            linkedList.InsertLast("Verkeia");

            var element = linkedList.GetElement("Candace");

        }

        static void MyFuncOne()
        {
            MyFuncTwo();
        }  

        static void MyFuncTwo()
        {
            MyFuncThree();
        }

        static void MyFuncThree()
        {
            Console.WriteLine("hello I live in Func three");
           // Console.ReadLine();
        }

        public static int CountingValleys(int steps, string path)
        {

            
            return 0;
        }
    }
}
