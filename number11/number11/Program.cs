using System;

namespace number11
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            foreach(string X in args)
            {
                sum += Convert.ToInt32(X);
            }
            Console.WriteLine(sum);
        }
    }
}
