using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpeedTest
{
    class SpeedTest
    {
        public static void SpeedTest_for_RUSTEXT(string Name, string Language) 
        {
            bool timeExpired = false;


            string text;
            text = TEXTS.Random_RUTEXT();
            Console.Clear();
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine(text);
            Console.WriteLine("--------------------------------------------------------------------------------");



            Console.WriteLine("Нажмите Enter, чтобы начать");
            ConsoleKeyInfo Enter;
            do
            {
                Enter = Console.ReadKey(true);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(20, 20);
                Console.WriteLine("Вы нажали не на Enter. Попробуйте снова.");
                Console.ForegroundColor = ConsoleColor.White;
            } while (Enter.Key != ConsoleKey.Enter);


            Thread thread = new Thread(new ThreadStart(Timer));
            void Timer()
            {
                TimeSpan remainingTime;
                Stopwatch stopwatch = new Stopwatch();
                TimeSpan timeLimit = TimeSpan.FromMinutes(1);                                 // Устанавливаем интервал времени на минуту (измерение в минутах)
                stopwatch.Start();
                while (stopwatch.Elapsed < timeLimit)
                {
                    remainingTime = timeLimit - stopwatch.Elapsed;                              // Вычисляем оставшееся время
                    Console.SetCursorPosition(0, 10);
                    Console.Write(remainingTime.ToString(@"mm\:ss"));
                    Thread.Sleep(1000);                                                         // каждую секунду (измерение в миллисекундах)
                }
                timeExpired = true;
            }
            thread.Start();




            Console.Clear();
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine(text);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.SetCursorPosition(0, 1);

            char[] chars = text.ToCharArray();
            var TypeUser = 0;
            var SumOfTypeUser = 0;
            var NumberForSetCursorPosition = 1;

            for (int i = 0; i < chars.Length; i++)
            {
                if (TypeUser == 80)
                {
                    Console.SetCursorPosition(0, NumberForSetCursorPosition);
                    SumOfTypeUser += TypeUser;
                    TypeUser = 0;
                    NumberForSetCursorPosition++;
                    continue;
                }

                if (timeExpired == true)
                {
                    Save_in_JSON.SaveJSON(Name, SumOfTypeUser, Language);
                }
                var UserChar = Console.ReadKey(true).KeyChar;

                if (UserChar == chars[i])
                {
                    Console.SetCursorPosition(TypeUser, NumberForSetCursorPosition);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(UserChar);
                    Console.ForegroundColor = ConsoleColor.White;
                    TypeUser++;
                }
                else
                {
                    i--;
                }
            }
        }
           

        public static void SpeedTest_for_ENGTEXT(string Name, string Language)
        {

            bool timeExpired = false;


            string text;
            text = TEXTS.Random_ENGTEXT();
            Console.Clear();
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine(text);
            Console.WriteLine("--------------------------------------------------------------------------------");



            Console.WriteLine("Нажмите Enter, чтобы начать");
            ConsoleKeyInfo Enter;
            do
            {
                Enter = Console.ReadKey(true);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(20, 20);
                Console.WriteLine("Вы нажали не на Enter. Попробуйте снова.");
                Console.ForegroundColor = ConsoleColor.White;
            } while (Enter.Key != ConsoleKey.Enter);


            Thread thread = new Thread(new ThreadStart(Timer));
            void Timer()
            {
                TimeSpan remainingTime;
                Stopwatch stopwatch = new Stopwatch();
                TimeSpan timeLimit = TimeSpan.FromMinutes(1);                                 // Устанавливаем интервал времени на минуту (измерение в минутах => 1)
                stopwatch.Start();
                while (stopwatch.Elapsed < timeLimit)
                {
                    remainingTime = timeLimit - stopwatch.Elapsed;                              // Вычисляем оставшееся время
                    Console.SetCursorPosition(0, 10);
                    Console.Write(remainingTime.ToString(@"mm\:ss"));
                    Thread.Sleep(1000);                                                         // каждую секунду (измерение в миллисекундах)
                }
            }
            thread.Start();




            Console.Clear();
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine(text);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.SetCursorPosition(0, 1);

            char[] chars = text.ToCharArray();
            var TypeUser = 0;
            var SumOfTypeUser = 0;
            var NumberForSetCursorPosition = 1;

            for (int i = 0; i < chars.Length; i++)
            {
                if (TypeUser == 80)
                {
                    Console.SetCursorPosition(0, NumberForSetCursorPosition);
                    SumOfTypeUser += TypeUser;
                    TypeUser = 0;
                    NumberForSetCursorPosition++;
                    continue;
                }

                if (timeExpired == true)
                {
                    Save_in_JSON.SaveJSON(Name, SumOfTypeUser, Language);
                }
                var UserChar = Console.ReadKey(true).KeyChar;


                if (UserChar == chars[i])
                {
                    Console.SetCursorPosition(TypeUser, NumberForSetCursorPosition);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(UserChar);
                    Console.ForegroundColor = ConsoleColor.White;
                    TypeUser++;
                }
                else
                {
                    i--;
                }

                if (thread.IsAlive == false)
                    Save_in_JSON.SaveJSON(Name, SumOfTypeUser, Language);

            }
        }
    }
}

