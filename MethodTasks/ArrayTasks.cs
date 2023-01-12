using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTasks
{
    internal class ArrayTasks
    {
        internal int[] EnterArray()
        {
            Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"arr[{i}]=");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        internal int[] FindSqrtElements()
        {
            int[] array = EnterArray();

            Console.Write("Kvadrat koku olan massivin elementleri: { ");

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Sqrt(array[i]) % 1 == 0)
                {
                    Console.Write(array[i]+ " ");
                }
            }
            Console.WriteLine("}");

            return array;
        }

        internal void Print(int[] array)
        {
            Console.Write("Original massivin elementleri: {");

            foreach (var item in array)
            {
                Console.Write($" {item} ");
            }
            Console.Write("}");
        }
    }
}
