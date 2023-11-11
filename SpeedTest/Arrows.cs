using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    static class Arrows
    {
        public static short Arrow(short max, short min)
        {
            short pos = max;                                                // Позиция стрелки.

            short Max_pos = max;                                            // Максимальное ограничение.
            short Min_pos = min;                                            // Минимальное ограничение.

            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(0, pos);                          // Ставим курсор на 0,pos, где pos = положению стрелки
                Console.WriteLine("->");                                    // Стрелка

                key = Console.ReadKey(true);                                // Считываем кнопку и не выводим ее на консоль

                Console.SetCursorPosition(0, pos);                          // Ставим курсор на 0,pos, где pos = положению стрелки, для удаления
                Console.WriteLine("  ");                                    // Убираем стрелку

                if (key.Key == ConsoleKey.DownArrow && pos != Min_pos)      // Если кнопка - вниз + позиция не равна минимальной то...
                    pos++;                                                  // ... 
                else if (key.Key == ConsoleKey.UpArrow && pos != Max_pos)
                    pos--;
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}
