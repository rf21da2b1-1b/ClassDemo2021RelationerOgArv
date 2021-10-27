using System;
using System.ComponentModel;

namespace ClassDemo2021RelationerOgArv
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWorker worker = new MyWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
