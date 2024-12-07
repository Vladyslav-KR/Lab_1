using System;
using System.Text;

namespace Task_3
{
    public static class BaseConsole
    {
        public static void Initialize()
        {
            // Встановлюємо кодування UTF-8 для коректного відображення тексту кирилицею
            Console.OutputEncoding = Encoding.UTF8;
        }
    }
}