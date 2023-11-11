using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace SpeedTest
{
    static class Save_in_JSON
    {
        public static void SaveJSON(string Name, double UserSymbols, string Language)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Вы успешно прошли тест! Вы можете найти своё имя в таблице рекордов и увидеть ваши результаты!\nНажмите Enter, чтобы начать тест сначала.\nНажмите Escape, чтобы заверщить программу");

            var Words_in_minute = UserSymbols   / 6;
                Words_in_minute                 /=5;
            var Symbols_in_minute = UserSymbols    ;
            var Symbols_in_second = UserSymbols /60;

            Words_in_minute = Math.Round(Words_in_minute, 2);
            Symbols_in_second = Math.Round(Symbols_in_second, 2);

            Infomation_of_Client NewUser = new Infomation_of_Client(Name, Symbols_in_minute, Symbols_in_second, Words_in_minute, Language);

            string pathforser = "E:\\Lessons\\П\\C#\\Практические\\SpeedTest\\SpeedTest\\Table.json"; // Путь к моей флешке, но можно создать на рабочем столе файл JSON файил и тогда всё тоже будет работать 
            string existingJson = File.ReadAllText(pathforser);
            if (existingJson == "")
            {
                existingJson = "[]";
            }
            List<Infomation_of_Client> userList = JsonConvert.DeserializeObject<List<Infomation_of_Client>>(existingJson);
            userList.Add(NewUser);
            string updatedJson = JsonConvert.SerializeObject(userList, Formatting.Indented);
            File.WriteAllText(pathforser, updatedJson);


            Console.WriteLine("----------------------------<Таблица рекордов>----------------------------");
            string json = File.ReadAllText("E:\\Lessons\\П\\C#\\Практические\\SpeedTest\\SpeedTest\\Table.json");       // Путь к моей флешке, но можно создать на рабочем столе файл JSON файил и тогда всё тоже будет работать 
            var data = JsonConvert.DeserializeObject<UserData[]>(json);
            var sortedData = data.OrderByDescending(d => d.Number_of_words);                
            foreach (var item in sortedData)                                                
            {
                Console.WriteLine($"Имя: {item.Name_of_client}, Слова в минуту: {item.Number_of_words}, Символы в минуту {item.Number_of_min}, Символы в секунду: {item.Number_of_sec}, Раскладка: {item.ENG_or_RUS_texts}");
            }

            while (true)
            {
                ConsoleKeyInfo EnterOrEscape = Console.ReadKey(true);
                if (EnterOrEscape.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    UserName.WriteName();
                }
                else if (EnterOrEscape.Key == ConsoleKey.Escape)
                    Environment.Exit(0);
            }
        }
    }
}
