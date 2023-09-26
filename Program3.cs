using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


using System.IO;
using System.Xml.Linq;

namespace Another3
{
    class Program
    {
        static void Save1()
        {
            Console.WriteLine("yo");

            string hi = File.ReadAllText("TextFile1.txt");
            if (int.TryParse(hi, out int yn))
            {
                Console.WriteLine(hi);
            }
            else
            {
                Console.WriteLine("u suck");
            }
            File.WriteAllText("TextFile1.txt", "1");
        }
        static void Save2()
        {
            Console.WriteLine();

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyGame.txt");
            string text_to_be_saved = "Some text to be saved...";
            File.WriteAllText(path, text_to_be_saved);

            // to load:

            string loaded_text = File.ReadAllText(path);
            Console.WriteLine(loaded_text);
        }
        static void Save3()
        {
            //check current data

            Console.WriteLine("enter \"1\" to check current data");
            if (Console.ReadLine() == "1")
            {
                goto Load;
            }

            //gather input
            Console.Write("   Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("    Enter Age: ");
            short age = Convert.ToInt16(Console.ReadLine());

            Console.Write(" Enter Gender: ");
            char gender = Convert.ToChar(Console.ReadLine());

            //save data to file
            string save_data = string.Join("\u001F", name, age, gender);
            File.WriteAllText("TextFile1.txt", save_data);

            //exit point
            Console.WriteLine("enter \"1\" to escape");
            if (Console.ReadLine() == "1")
            {
                Environment.Exit(0);
            }

        //to load:

        Load:

            string loaded_file = File.ReadAllText("TextFile1.txt");

            string[] array = loaded_file.Split('\u001F');

            name = array[0];
            age = Convert.ToInt16(array[1]);
            gender = Convert.ToChar(array[2]);

            Console.WriteLine($"   Name: {name}\n    Age: {age}\n Gender: {gender}");
        }
        static void Save4()
        {
            Console.WriteLine("Hello World");
            FileStream fs = new FileStream("Test.txt", FileMode.Create);
            // First, save the standard output.
            TextWriter tmp = Console.Out;
            StreamWriter sw = new StreamWriter(fs);
            Console.SetOut(sw);
            Console.WriteLine("Hello file");
            Console.SetOut(tmp);
            Console.WriteLine("Hello World");
            sw.Close();
        }

        static void hello1()
        {
            Console.CursorVisible = false;
            string msg = "-- Hello World ";

            //creates queue in order to cycle through a message
            Queue<char> queue = new Queue<char>();

            foreach (char c in msg)
            {
                queue.Enqueue(c);
            }

            Console.WriteLine("*****************\n" +
                        "*               *\n" +
                        "*****************");

            while (true)
            {
                Console.SetCursorPosition(1, 1);

                foreach (char c in queue)
                {
                    Console.Write(c);
                }
                //cycle through message (clockwise)
                queue.Enqueue(queue.Peek());
                queue.Dequeue();

                Thread.Sleep(500);
            }
        }
        static void hello2()
        {
            Console.CursorVisible = false;
            string msg = "-- Hello World ";

            //creates list in order to cycle through a message
            List<char> list = new List<char>();

            foreach (char c in msg)
            {
                list.Add(c);
            }

            Console.WriteLine("*****************\n" +
                "*               *\n" +
                "*****************");

            while (true)
            {
                Console.SetCursorPosition(1, 1);

                foreach (char c in list)
                {
                    Console.Write(c);
                }
                //cycle through message (counter clockwise)
                list.Insert(0, list[list.Count - 1]);
                list.RemoveAt(list.Count - 1);

                Thread.Sleep(500);
            }
        }
        static void MultiThreading()
        {
            DateTime startTime = DateTime.Now;

            Thread t1 = new Thread(() =>
            {
                int numberOfSeconds = 0;
                while (numberOfSeconds < 5)
                {

                    Console.Write(numberOfSeconds);
                    Thread.Sleep(1000);

                    numberOfSeconds++;
                }

                Console.WriteLine("I ran for 5 seconds");
            });

            Thread t2 = new Thread(() =>
            {
                int numberOfSeconds = 0;
                while (numberOfSeconds < 8)
                {
                    if (!(numberOfSeconds == 5))
                    {
                        Console.Write(numberOfSeconds);
                    }
                    Thread.Sleep(1000);

                    numberOfSeconds++;
                }

                Console.WriteLine("I ran for 8 seconds");
            });


            //parameterized thread
            Thread t3 = new Thread(p =>
            {
                int numberOfSeconds = 0;
                while (numberOfSeconds < Convert.ToInt32(p))
                {
                    Thread.Sleep(1);
                    if (!(numberOfSeconds == 5 || numberOfSeconds == 8))
                    {
                        Console.WriteLine(numberOfSeconds);
                    }
                    Thread.Sleep(999);

                    numberOfSeconds++;
                }

                Console.WriteLine("I ran for {0} seconds", numberOfSeconds);
            });

            t1.Start();
            t2.Start();
            //passing parameter to parameterized thread
            t3.Start(20);

            //wait for t1 to fimish
            t1.Join();

            //wait for t2 to finish
            t2.Join();

            //wait for t3 to finish
            t3.Join();


            Console.WriteLine("All Threads Exited in {0} seconds", (DateTime.Now - startTime).TotalSeconds);

        }
        static void CursorSize()
        {
            Console.CursorSize = 10;

            string m0 = "This example increments the cursor size from 1% to 100%:\n";
            string m1 = "Cursor size = {0}%. (Press any key to continue...)";
            int[] sizes = { 1, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int saveCursorSize;
            //
            saveCursorSize = Console.CursorSize;
            Console.WriteLine(m0);
            foreach (int size in sizes)
            {
                Console.CursorSize = size;
                Console.WriteLine(m1, size);
                Console.ReadKey();
            }
            Console.CursorSize = saveCursorSize;
        }
        class Thing
        {
            public int val;

            public Thing(int o)
            {
                val = o;
            }
        }
        public static bool cont = true;
        public static Thread inputThread = new Thread(o =>
        {
            while (true && cont)
            {

                if (Console.KeyAvailable)
                {
                    Console.WriteLine(Console.ReadKey(true).Key);
                }
            }
        });
        static void Main(string[] args)
        {

            ConsoleKeyInfo key;

            char cap = 'a';



            while (true)
            {
                
                if (Console.KeyAvailable)
                {


                    key = Console.ReadKey(true);


                    if (key.KeyChar == cap) { continue; }

                    Console.WriteLine(key.KeyChar);
                    cap = key.KeyChar;


                    Thread.Sleep(100);
                    

                }


            }




            /*
            Save1();
            Save2();
            Save3();
            Save4();
            hello1();
            hello2();
            MultiThreading();
            */



        }
    }
}
