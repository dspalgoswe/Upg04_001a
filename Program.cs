using System;
using System.Collections.Generic;


namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. Check Parenthesis"
                    + "\n0. Exit the application");
                char input = ' ';
                try
                {
                    input = Console.ReadLine()![0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        static void ExamineList()
        {
            List<string> theList = new List<string>();
            while (true)
            {
                Console.WriteLine("Ange + för att lägga till eller - för att ta bort ett element. Skriv 'exit' för att gå tillbaka till menyn.");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break; // Avsluta metoden och gå tillbaka till menyn
                }

                if (input.Length < 2)
                {
                    Console.WriteLine("Ogiltig inmatning. Var god skriv + eller - följt av ett värde.");
                    continue; // Fortsätt till nästa iteration
                }

                char nav = input[0];
                string value = input.Substring(1).Trim(); // Ta bort första tecknet och eventuella mellanslag

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine($"Lagt till '{value}'. Antal element: {theList.Count}, Kapacitet: {theList.Capacity}");
                        break;
                    case '-':
                        if (theList.Remove(value))
                        {
                            Console.WriteLine($"Tagit bort '{value}'. Antal element: {theList.Count}, Kapacitet: {theList.Capacity}");
                        }
                        else
                        {
                            Console.WriteLine($"Elementet '{value}' finns inte i listan.");
                        }
                        break;
                    default:
                        Console.WriteLine("Använd endast + för att lägga till eller - för att ta bort ett element.");
                        break;
                }
            }
        }

        static void ExamineQueue()
        {
            Queue<string> theQueue = new Queue<string>();
            while (true)
            {
                Console.WriteLine("Ange + för att lägga till eller - för att ta bort ett element. Skriv 'exit' för att gå tillbaka till menyn.");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break; // Avsluta metoden och gå tillbaka till menyn
                }

                if (input.Length < 2)
                {
                    Console.WriteLine("Ogiltig inmatning. Var god skriv + eller - följt av ett värde.");
                    continue;
                }

                char nav = input[0];
                string value = input.Substring(1).Trim();

                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(value);
                        Console.WriteLine($"Lagt till '{value}'. Antal element i kön: {theQueue.Count}");
                        break;
                    case '-':
                        if (theQueue.Count > 0)
                        {
                            string removed = theQueue.Dequeue();
                            Console.WriteLine($"Tagit bort '{removed}'. Antal element i kön: {theQueue.Count}");
                        }
                        else
                        {
                            Console.WriteLine("Kön är tom.");
                        }
                        break;
                    default:
                        Console.WriteLine("Använd endast + för att lägga till eller - för att ta bort ett element.");
                        break;
                }
            }
        }

        static void ExamineStack()
        {
            Stack<string> theStack = new Stack<string>();
            while (true)
            {
                Console.WriteLine("Ange + för att lägga till eller - för att ta bort ett element. Skriv 'exit' för att gå tillbaka till menyn.");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break; // Avsluta metoden och gå tillbaka till menyn
                }

                if (input.Length < 2)
                {
                    Console.WriteLine("Ogiltig inmatning. Var god skriv + eller - följt av ett värde.");
                    continue;
                }

                char nav = input[0];
                string value = input.Substring(1).Trim();

                switch (nav)
                {
                    case '+':
                        theStack.Push(value);
                        Console.WriteLine($"Lagt till '{value}'. Antal element i stacken: {theStack.Count}");
                        break;
                    case '-':
                        if (theStack.Count > 0)
                        {
                            string removed = theStack.Pop();
                            Console.WriteLine($"Tagit bort '{removed}'. Antal element i stacken: {theStack.Count}");
                        }
                        else
                        {
                            Console.WriteLine("Stacken är tom.");
                        }
                        break;
                    default:
                        Console.WriteLine("Använd endast + för att lägga till eller - för att ta bort ett element.");
                        break;
                }
            }
        }

        static void CheckParanthesis()
        {
            // Placeholder logik för att kontrollera parenteser
            // Implementera din logik här
        }
    }
}
