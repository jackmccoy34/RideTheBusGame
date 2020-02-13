using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("What do you want to do?\n" +
                    "1. Hop on the bus => \n" +
                    "2. This is my stop =>");

                string userInput = Console.ReadLine();
                userInput = userInput.Replace(" ", "");
                switch (userInput)
                {
                    case "1":
                        //Easy
                        Easy();
                        break;
                    case "2":
                        //Exit
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
            void Easy()
            {
                bool hasNotFailed = true;
                Card easy = new Card();
                if (hasNotFailed)
                {
                    Console.Clear();
                    Console.WriteLine("What color do you think your first card is? (Type '1' for Red or '2' for Black)");
                    string userInput = Console.ReadLine();
                    userInput = userInput.Replace(" ", "");
                    int userInt = Convert.ToInt32(userInput);
                    if (userInt == easy.ColorPicker)
                    {
                        Console.WriteLine("Congratulations! You guessed correct!");
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        hasNotFailed = false;
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                PrevCard1 firstCard = new PrevCard1(easy.Number1, easy.ColorPicker);
                Card secondCard = new Card();
                if (hasNotFailed)
                {
                    Console.Clear();
                    Console.WriteLine("Do you think your next card will be higher or lower than your previous card?\n" +
                        $"Previous Card: {firstCard.Color2} {firstCard.Number2}\n" +
                        $"Type '1' for Lower or '2' for Higher");

                    string userInput = Console.ReadLine();
                    userInput = userInput.Replace(" ", "");
                    bool lower = firstCard.Number2 > secondCard.Number1;

                    if (lower && userInput == "1")
                    {
                        Console.WriteLine("Congratulations! You guessed correct!");
                    }
                    else if (!lower && userInput == "2")
                    {
                        Console.WriteLine("Congratulations! You guessed correct!");
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        hasNotFailed = false;
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                Card lastCard = new Card();
                if (hasNotFailed)
                {
                    Console.Clear();
                    Console.WriteLine("Do you think your next card will be inside or outside your two previous cards?\n" +
                        $"Previous cards: {firstCard.Color2} {firstCard.Number2}" +$" and {secondCard.Color1} {secondCard.Number1}" +
                        "\n(Type '1' for Inside or '2' for Outside)");
                    string userInput = Console.ReadLine();
                    userInput = userInput.Replace(" ", "");
                    int userInt = Convert.ToInt32(userInput);
                    if (firstCard.Number2 >= secondCard.Number1)
                    {
                        if(secondCard.Number1 <lastCard.Number1 && lastCard.Number1< firstCard.Number2)
                        {
                            if(userInt == 1)
                            {
                                Console.WriteLine("Congrats! You made it to School!");
                            }
                            else
                            {
                                Console.WriteLine("You made it SO far but the bus broke :( Game Over");
                            }
                        }
                        else
                        {
                            if (userInt == 2)
                            {
                                Console.WriteLine("Congrats! You made it to School!");
                            }
                            else
                            {
                                Console.WriteLine("You made it SO far but the bus broke :( Game Over");
                            }
                        }
                    }
                    else if (firstCard.Number2 <= secondCard.Number1)
                    {
                        if (secondCard.Number1 > lastCard.Number1 && lastCard.Number1 > firstCard.Number2)
                        {
                            if (userInt == 1)
                            {
                                Console.WriteLine("Congrats! You made it to School!");
                            }
                            else
                            {
                                Console.WriteLine("You made it SO far but the bus broke :( Game Over");
                            }
                        }
                        else 
                        {
                            if (userInt == 2)
                            {
                                Console.WriteLine("Congrats! You made it to School!");
                            }
                            else
                            {
                                Console.WriteLine("You made it SO far but the bus broke :( Game Over");
                            }
                        }
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }

            //void Medium()
            //{
            //    HigherLower medium= new HigherLower();
            //    Console.Clear();
            //    Console.WriteLine("Do you think your next card will be higher or lower than your previous card?" );
            //    string userInput = Console.ReadLine();
            //    userInput = userInput.Replace(" ", "");
            //    int userInt = Convert.ToInt32(userInput);
            //    if (userInt == medium.A)
            //    {
            //        Console.WriteLine("Congratulations! You guessed correct!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Better luck next time!");
            //    }
            //    Console.WriteLine("Press any key to continue");
            //    Console.ReadKey();
            //}

            //void Hard()
            //{
            //    InsideOutside hard = new InsideOutside();
            //    Console.Clear();
            //    Console.WriteLine("Please guess a number between 1 and 10");
            //    string userInput = Console.ReadLine();
            //    userInput = userInput.Replace(" ", "");
            //    int userInt = Convert.ToInt32(userInput);
            //    if (userInt == hard.nextCard)
            //    {
            //        Console.WriteLine("Congratulations! You guessed correct!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Better luck next time!");
            //    }
            //    Console.WriteLine("Press any key to continue");
            //    Console.ReadKey();
            //}
        }

    }
}
