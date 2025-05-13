using System.Runtime.CompilerServices;

namespace testpush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, test!");

            var szam = 5;

            var test = testMethod();

            Console.WriteLine(szam == test);

           
        }

        private static int testMethod()
        {
            return 5;
        }
    }
}
