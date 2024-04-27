using System;

namespace ArrayRecap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];

            
            for (int i = 0; i < arr1.Length; i++) //присваивание значения массиву
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-------------------------"); // разделитель ввода и вывода
            for (int i = 0; i < arr1.Length; i++) //вывод значения
            {
                Console.WriteLine(arr1[i]);
            }
        }
    }
}
