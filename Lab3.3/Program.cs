using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab3._3
{
    class Program
    {
        static string GetWords(string sentence)
        {
            string[] wordList = sentence.Split(' ');
            string revSentence = "";
             
            for (int i = 0; i < wordList.Length; i++)
            {
                wordList[i] = ReverseIt(wordList[i]);
                revSentence += wordList[i] + " ";
            }

            return revSentence;
            
        }


        static string ReverseIt(string input)
        {
            

            Stack reverseInput = new Stack();

            for (int i = 0; i < input.Length; i++)
            {
                reverseInput.Push(input[i]);
            }
            string reversed = "";
            while (reverseInput.Count > 0)
            {
                reversed = reversed + reverseInput.Pop();
            }
            return reversed;
            
            

        }

        static bool Continue()
        {

            bool valid = false;
            while (!valid)
            {
                Console.Write("\nWould you like to reverse another? (y/n)  ");
                string ans = Console.ReadLine();
                ans = ans.ToLower();
                if (ans == "n" || ans == "y")
                {
                    valid = true;
                    if (ans == "n")
                    {
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("\nSorry, that is not a valid input. Please try again.");
                }
            }
            Console.Clear();
            return false;

        }



        static void Main(string[] args)
        {
            // Take in a user input and display input in reverse

            bool done = false;
            while (!done)
            {
                string input = "";   
                bool validInput = false;
                while (!validInput)
                {
                    Console.Write("Please enter something you'd like to reverse: ");
                    input = Console.ReadLine();
                    Regex rx = new Regex(@"^[a-zA-Z\s]+$");
                    if (rx.IsMatch(input))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("\nSorry, that was not a valid input. Please try again. (Hint: Only use A-Z and Spaces)\n");
                    }

                }
                if (input.Contains(' '))
                {
                    Console.WriteLine($"\nYour sentence in reverse is: { GetWords(input)}");
                }
                else
                {
                    Console.WriteLine($"\nYour word in reverse is: {ReverseIt(input)}");
                }
                
                done = Continue();
            }


        }
    }
}
