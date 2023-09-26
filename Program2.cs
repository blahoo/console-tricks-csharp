using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Input;
using System.Threading.Tasks;

using System.Drawing;

namespace Another2
{
    class Program
    {
        static void Time()
        {
            // print the system date and time
            DateTime d = DateTime.Now;            
            Console.WriteLine("System date: {0:d}\nSystem time: {0:t}", d);
        }
        static void Colours()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void Beep()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Beep(440, 200);
                Thread.Sleep(200);
                Console.Beep(440, 600);
            }
            Console.Beep();

            Console.Beep(800, 200);

            Console.Beep();
        }
        static void MultiDeclare()
        {
            string hi, bye;
            hi = Console.ReadLine();
            bye = Console.ReadLine();
            Console.WriteLine(hi + " " + bye);
        }
        static void Key()
        {
            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                cki = Console.ReadKey(true);
                Console.Write("You pressed ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                Console.WriteLine("{0} (character '{1}')", cki.Key, cki.KeyChar);
            } while (cki.Key != ConsoleKey.Escape);
        }
        static void Key2()
        {
            do
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    Console.WriteLine(key.KeyChar);
                }
                else
                {
                    Console.WriteLine("No key pressed");
                }
                System.Threading.Thread.Sleep(100);
            } while (true);
        }
        static void Key3(){
            Console.WriteLine("Press the escape key to exit");

            ConsoleKeyInfo keypress = new ConsoleKeyInfo();           

            while (true)
            {
                keypress = Console.ReadKey(true);
                if (keypress.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("bye bye");
                    Environment.Exit(5000);
                }
            }
        }
        static void TryToConvert()
        {
            int value;
            string input;
            //value is 0 if the input is not a number
            Console.WriteLine("type something");

            input = Console.ReadLine();

            if (int.TryParse(input, out value))
            {
                Console.WriteLine(value + " is a number");
            }
            else
            {
                Console.WriteLine(value + " is not a number");
            }
        }
        static void Main(string[] args)
        {


            //using System.Windows.Input;

            Console.Title = "hi";
            Console.CursorVisible = false;

            Key3();

            /*
            Time();
            Colours();
            Beep();
            MultiDeclare();
            Key();
            Key2();
            TryToConvert();
            */



        }
    }
}
