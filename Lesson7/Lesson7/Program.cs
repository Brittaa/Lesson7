using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1 Multiplication table
            /*Console.WriteLine("Please enter the number: ");
            int userNumber = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            { 
                Console.WriteLine($"{ userNumber} X {i} = {userNumber * i}");

            }

            
            Console.ReadLine();*/

            //TASK 2
            /*Console.WriteLine("Please, enter your name: ");
            string name = Console.ReadLine();

            int counter = 0;
            foreach(char letter in name)
            {
                counter++;
            }

            Console.WriteLine($"Your name is {counter} letters long.");
            Console.ReadLine();
            */


            /*string name;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine().ToLower();

            bool letterFound = false;

            foreach(char letter in name)
            {
                if (letter == 'a')
                {
                    letterFound = true;
                    break;
                }
            // if(letterFound = true;

            }
            string result = letterFound ? "Found an A!" : "There is no A in your name.";
            Console.WriteLine(result);*/

            /*Console.WriteLine("Enter your name: ");
            string name;
            name = Console.ReadLine().ToLower();
            int aTotal = 0;




            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a')
                {
                    aTotal++;
                }
            }

            Console.WriteLine($"There are {aTotal} \"A\" letters in your name.");
            Console.ReadLine();*/

            //TASK3

            /*Console.Write("Please, enter word: ");
            string word = Console.ReadLine();


            /*foreach (char letter in word)
            {
                Console.Write($"{letter} ");
            }*/

            /*for (int i = 0; i < word.Length; i++)
            {
                if (i==word.Length-1)
                {
                    Console.Write($"{word[i]}");
                    break;
                }
                Console.Write($"{word[i]}*");

            }

            Console.ReadLine();*/

            /*int i = 1;
            while (i <= 10)
            {
                Console.Write($"{i} "); //võib ka Console.WriteLine(i);
                i++;
            }*/

            string hello = "hello";
            int i = 0;

            while(i < hello.Length)
            {
                Console.WriteLine($"{hello[i]}");
                i++;
            }






        }
    }
}
