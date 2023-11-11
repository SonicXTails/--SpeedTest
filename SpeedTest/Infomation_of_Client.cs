using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTest
{
    internal class Infomation_of_Client
    {
        public string Name_of_client;              // Переменная для считывания имени.
        public double Number_of_min;               // Переменная для считывания времени в минуту  (символы)
        public double Number_of_sec;               // Переменная для считывания времени в секунду (символы)
        public double Number_of_words;             // Переменная для считывания времени в минуту (слова)
        public string ENG_or_RUS_texts;            // Переменная для считывания язка, на котором был пройден тест

        public Infomation_of_Client(string name_of_client, double number_of_minutes, double number_of_sec, double number_of_words, string eng_or_rus_text)
        {
            Name_of_client = name_of_client;    // Конструктор для записи значений новых пользовтелей 
            Number_of_min = number_of_minutes;      
            Number_of_sec = number_of_sec;
            Number_of_words = number_of_words;
            ENG_or_RUS_texts = eng_or_rus_text;
        }
    }
}
