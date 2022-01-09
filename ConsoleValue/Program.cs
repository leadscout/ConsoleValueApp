using System;

namespace ConsoleValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the input value: ");
            float i = 0;
            string Value = Console.ReadLine();
            bool result = float.TryParse(Value, out i);
            Console.WriteLine(result);
        }
    }
}
