using System;

namespace InterfaceLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Transaction("001","8/10/2012",789000.00);
            var t2 = new Transaction("002","9/10/2012", 45100.00);
            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();
        }
    }
}