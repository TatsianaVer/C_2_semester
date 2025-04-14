using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant11
{
    public class Program
    {
        public static void Main1()
        {
            try
            {
                var a = new Array(5);
                var b = new Array(5);

                Console.WriteLine("Array A:");
                new FillArray().Fill(a);

                Console.WriteLine("Array B:");
                new FillArray().Fill(b);

                var c = new CreateArrayC().Create(a, b, 3);

                Console.WriteLine("\nResults:");
                Show(a, "A");
                Show(b, "B");
                Show(c, "C");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void Show(Array arr, string name)
        {
            new Print().Execute(arr);
            Console.WriteLine($"{name}: Product = {new NegativeProd().Execute(arr)}\n");
        }
    }
}
