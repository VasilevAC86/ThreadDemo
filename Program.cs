using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; // Для многопоточности
//using System.Threading.Tasks; // После версии Framework 3.5

namespace ThreadDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            object _lock = new object(); // Создаём сущность типа _lock            
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(() => { doSomethingToConsole.DoSomePrint(_lock, i.ToString()); }); // Создаём поток
                thread.Name = "Print #" + i.ToString(); // Каждому потоку присваиваем имя
                thread.Start();
                Console.WriteLine("Создан поток {0}", thread.Name);
            }            
        }
    }
}
