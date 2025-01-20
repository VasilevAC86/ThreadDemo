using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadDemo
{
    internal class doSomethingToConsole
    {
        public static void DoSomePrint(object _lock, string text)
        {
            lock (_lock) // lock не запускает поток, пока выполняется условие, в коде ниже работает как блокировка
                         // (исп. для предотвращении потери данных при работе с ДБ, пока передача не прошла, новая не начинается)
            {
                try
                {
                    Monitor.Enter(_lock);
                    if (Int32.Parse(text)%2 == 0)
                    {
                        int a = 0;
                        Console.WriteLine(2 / a);
                    }
                    string name = DateTime.Now.ToString("mm_ss_fff");
                    Console.WriteLine("Current thread name are {0} and say: ", name);
                    Console.WriteLine("{0}", text);
                    Thread.Sleep(800); // Задержка для запуска потоков (через 1600 каждый поток выходит из обл.видимости и запускается новый поток)
                }
                finally 
                { 
                    Monitor.Exit(_lock);  // Освобождаем _lock
                }                            
            }
            // Методы Enter() Exit() как обёртки механизма исключения

        }
    }
}
