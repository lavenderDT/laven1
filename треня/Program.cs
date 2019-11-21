using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace треня
{
    class Car : ICloneable
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public int Number { get; set; }
        public object Clone()
        {
            return new Car { Color = this.Color, Model = this.Model, Number = this.Number };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Продемонстрировать упаковку и распаковку любого типа
            int a = 8767;
            Object obj = a;

            int a1 = (int)obj;

            //Пользователь вводит строку. Разбить строку на две подстроки равной длины.
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            int l = (str.Length) / 2;
            for (int i=0; i<l; i++)
            {

            }

            //Задан двумерный массив int. Посчитайте в массиве количество нулевых элементов
            int[,] array = new int[3, 3] { { 1, 2, 3 }, { 0, 0, 4 }, { 5, 6, 0 } };
            int k = 0;
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    if (array[i, j] == 0)
                        k++;
                }
            }
            Console.Write ("Количество нулевых элементов: ");
            Console.WriteLine(k);

            // Создать класс Car c тремя свойствами (Color, Model, Number).
            //Car должен реализовывать интерфейс ICloneable. Дважды клонируйте объект и докажите что у вас три разных объекта
            Car c1 = new Car { Color = "red", Model = "BMW", Number = 9587};
            Car c2 = (Car)c1.Clone();
            Car c3 = (Car)c1.Clone();
            c2.Number = 1234;
            c3.Color = "blue"; c3.Number = 5678;
            Console.WriteLine(c1.Number);
            Console.WriteLine(c2.Number);
            Console.WriteLine(c3.Number);
            Console.Read();
        }
    }
}
