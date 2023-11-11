using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SpeedTest
{
    internal class UserName
    {
        public static string WriteName()
        {
            string Name;
            Console.Write("Введите ваше имя для таблицы рекордов: ");
            do
            {
                Name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(20, 10);
                Console.Write("Вы должны написать ваше имя (боже, хватит всегда нажимать Enter)");
                Console.SetCursorPosition(39, 0);
                Console.ForegroundColor = ConsoleColor.White;
            } while (Name == "");

            Choise_of_Language.Write_Language(Name);
            return Name;
        }
    }
}
