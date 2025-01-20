using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadDemo
{
    internal class doSomethingToConsole
    {
        public static void DoSomePrint(object _lock, int number = 0)
        {
            lock (_lock) // lock не запускает поток, пока выполняется условие, в коде ниже работает как блокировка
            {
                                   
                    //if (number % 2 == 0)
                    //{
                    //    Console.WriteLine(number / 0);
                    //}
                    string name = DateTime.Now.ToString("mm_ss_fff");
                    Console.WriteLine("Current thread name are {0} and say: ", name);
                    Console.WriteLine("{0}", number);

                    Thread.Sleep(1600); // Задержка для запуска потоков (через 1600 каждый поток выходит из обл.видимости и запускается новый поток)
                            
            }
            // Методы Enter() Exit() как обёртки механизма исключения

        }
    }
}
