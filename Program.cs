using System;
using System.Linq;
/*Создайте локальную функцию в main и вызовите ее. Формальные
параметры функции – массив целых и строка. Функция должна вернуть
кортеж, содержащий: максимальный и минимальный элементы массива,
сумму элементов массива и первую букву строки .*/
namespace _2._5lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива: ");
            int[] array = new int[5];
            for (int i = 0; i< array.Length; i++)
            {
                array[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            fun(array, str);
            void fun(int[] ar,string st)
            {
                (int maxElem, int minElem, int sum, string first) cortege;
               
                int s=0;
                for (int j = 0; j < ar.Length; j++)
                {
                    s += ar[j];
                }
                cortege.maxElem = ar.Max<int>();
                cortege.minElem = ar.Min<int>();
                cortege.sum = s;
                cortege.first = st.Substring(0, 1);
                Console.WriteLine(cortege);
            }
        }
    }
}
