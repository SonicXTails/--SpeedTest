using Cafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTest
{
    internal class Choise_of_Language
    {
        public static string Write_Language(string Name)
        {
            string Language;

            Console.Clear();
            Console.Write("Выберете язык, накотором будете проходить тестирование на скоропечать: \n  ENG\n  RUS");

            short pos = Arrows.Arrow(1,2);
            Language = (pos == 2) ? "RUS" : "ENG";

            if (Language == "RUS")
                SpeedTest.SpeedTest_for_RUSTEXT(Name, Language);
            else
                SpeedTest.SpeedTest_for_ENGTEXT(Name, Language);
            return Language;
        }
    }
}
