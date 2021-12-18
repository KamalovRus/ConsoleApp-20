using System;

namespace Task20
{
    class Program
    {
        public delegate double Operation(double number);
        static void Main(string[] args)
        {
            Operation op = CircleLength;
            Console.WriteLine(op(5));

            op = CircleSquare;
            Console.WriteLine(op(12));

            op = CircleVolume;
            Console.WriteLine(op(10));
        }
        static double CircleLength(double R)
        {
            return 2 * Math.PI * R;
        }
        static double CircleSquare(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }
        static double CircleVolume(double R)
        {
            return (double)4 / 3 * Math.PI * Math.Pow(R, 3);
        }
    }
}

