using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SortNumber
{
    
    class SortNumb
    {
        int[] arr = new int[0];

        public SortNumb(int n)
        {
            Array.Resize(ref arr, n);
            InitArray();
        }

        void InitArray()
        {
            Random rnd = new Random();
            Console.Write("Начальная последовательность: ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 50);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            QuickSortArr();
        }

        void QuickSortArr()
        {
            Stopwatch StpWth = new Stopwatch();
            StpWth.Start();
            Array.Sort(arr);
            StpWth.Stop();
            Console.Write("Сортировка Quick: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Время выполнения: " + StpWth.ElapsedMilliseconds);
            Console.WriteLine();
            BubbleSortArr();
        }
        
        void BubbleSortArr()
        {
            Stopwatch StpWth = new Stopwatch();
            StpWth.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < i - arr.Length - 1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int tmp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            StpWth.Stop();
            Console.Write("Сортировка Bubble: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Время выполнения: " + StpWth.ElapsedMilliseconds);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество чисел: ");
            n = Convert.ToInt32(Console.ReadLine());
            SortNumb obj = new SortNumb(n);
        }
    }
}
