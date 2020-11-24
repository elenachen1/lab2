using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива (введенное число, должно быть не равно и не меньше нуля, и не больше 100):\t");
            int Count = int.Parse(Console.ReadLine());

            if (Count <= 0 || Count > 100)
            {
                Console.WriteLine("\nНеверно введено число");
                
            }
            else
            {
                int[] myArray = new int[Count];

                for ( int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"\nВведите элемент массива {i}:\t");
                    myArray[i] = int.Parse(Console.ReadLine());
                }

                int sort;
                for (int i = 0; i < myArray.Length - 1; i++)
                {
                    for (int j = i + 1; j < myArray.Length; j++)
                    {
                        if (myArray[i] > myArray[j])
                        {
                            sort = myArray[i];
                            myArray[i] = myArray[j];
                            myArray[j] = sort;
                        }
                    }
                }

                Console.WriteLine("\n Вывод массива:");

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);
                }
            }
            
        }
    }
}
