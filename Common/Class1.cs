using System;
using System.Text;

namespace Common
{
    public static class BaseConsole
    {
        public static void Initialize()
        {
            Console.OutputEncoding = Encoding.UTF8;
        }
    }
}