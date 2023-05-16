using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var testClass = new TestClass
            {
                Message = "Hello world!"
            };

            Console.WriteLine(testClass.Message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
