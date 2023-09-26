using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another
{
    internal class Program
    {
        static void letterCallBack()
        {
            Console.WriteLine("LETTER CALL BACK");
            //Console.Read gives a number which can be converted back into char
            //it only takes the first character
            Console.WriteLine("type something");
            char character = Convert.ToChar(Console.Read());
            Console.WriteLine(character);
            //end
            Console.WriteLine("-----\n");
        }
        static void stringIndex()
        {
            Console.WriteLine("STRING INDEX");
            //starting phrase, \n creates a line break
            string phrase = "There once was an old and wise man, \nHe didn't like being old, \nBut he liked being wise";
            Console.WriteLine(phrase);
            //input
            Console.Write("Start: ");
            int indexStart = Convert.ToInt32(Console.ReadLine());
            Console.Write("End: ");
            int indexEnd = Convert.ToInt32(Console.ReadLine());
            //output
            Console.WriteLine(phrase.Substring(indexStart, indexEnd));
            //end
            Console.WriteLine("-----\n");
        }
        static void largerNumber()
        {
            Console.WriteLine("LARGER NUMBER");
            //introduction
            Console.WriteLine("Give some numbers!");
            //input
            Console.Write("Input 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            //output
            Console.WriteLine("\nOutput:" + Math.Max(number1, number2));
            //end
            Console.WriteLine("-----\n");
        }
        static int powerFunc(ref int Exponent, int Base)
        {
            if (Exponent == 1)
            {
                return Base;
            }
            Exponent--;
            return Base * powerFunc(ref Exponent, Base);
        }
        static void waitTime()
        {
            Console.WriteLine("hi");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("hi");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("hi");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("hi");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("hi");
        }
        static void randLetter()
        {
            //have to instantiate an object or var from the random class in order to use .Next 
            Random rnd = new Random();
            int randIndex = rnd.Next(0, 25);
            char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
                'w', 'x', 'y', 'z'}; 
            Console.WriteLine(arr[randIndex]);
        }
        static void randLetter2()
        {
            //have to instantiate an object or var from the random class in order to use .Next            
            Random rnd = new Random();
            int randIndex = rnd.Next(0, 25);
            string aph = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(aph[randIndex]);
            /*
            randLetter2 uses a string to hold character data,
            accessing the letters by using the string as an array
            */
        }
        static void questionMark()
        {
            Console.Write("select y/n :");
            string msg = Console.ReadLine();
            string answer = (msg == "y") ? "yes" : "no";
            Console.WriteLine(answer);
        }
        static void experimentInput()
        {
            //ReadLine in WriteLine???
            Console.WriteLine("EXPERIMENT INPUT");
            Console.WriteLine("Your input was " + Console.ReadLine() + " and " + Console.ReadLine());
            //end
            Console.WriteLine("-----\n");
        }
        static void experimentArr()
        {
            Console.WriteLine("EXPERIMENT ARR");
            Console.WriteLine("pick a number from 0 to 7");
            int k = Convert.ToInt32(Console.ReadLine());
            bool[] tralse = { true, false, true, false, true, false, true, false };
            if (tralse[k])
                Console.WriteLine("this is true");
            else
                Console.WriteLine("this is false");
        }
        static void experimentArr2()
        {
            Console.WriteLine("EXPERIMENT ARR2");
            int[,] arr = new int[3, 3];
            arr[2, 2] = 1;
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(arr[x, y]);
            int[,] otharr = { { 1, 2, 3, }, { 4, 5, 6, }, { 6, 7, 8, } };
            Console.WriteLine(otharr[x, y]);
        }
        static void experimentStringPlaceholders()
        {
            //"{index}" placeholderValue
            string name = "John";
            int age = 27;
            Console.WriteLine("Hi, my name is {0}, and I am {1}", name, age);
        }
        static void experimentStringInterpolation()
        {
            //use $ to initalize string interpolation
            string name = "Sam";
            int age = 24;
            Console.WriteLine($"Hi, my name is {name}, and I am {age}");
        }
        static void experimentStrings()
        {
            string name = "John";
            int age = 27;
            Console.WriteLine("Hi, my name is {0}, but people call me {0}," +
                " I am {1}, which means I am {1} years old", name, age);
            Console.WriteLine("Hi, my name is {0}, I am {1}," +
                " which means I am {0} and I'm {1} years old ", name, age);
        }
        static void Main(string[] args)
        {
            List<int> hey = new List<int> { 1, 2, 3, };

            //Functions List 
            /*
            letterCallBack();            
            Console.ReadLine();

            stringIndex();

            largerNumber();

            Console.WriteLine("Exponents!");
            Console.Write("Base: ");
            int powerBase = Convert.ToInt32(Console.ReadLine());
            Console.Write("Exponent: ");
            int powerExponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(powerFunc(ref powerExponent, powerBase));
            Console.WriteLine("-----\n");

            waitTime();

            randLetter();

            randLetter2();

            questionMark();

            experimentInput();

            experimentArr();

            experimentArr2();

            experimentStringPlaceholders();

            experimentStringInterpolation()

            experimentStrings

            */

        }
    }
}
