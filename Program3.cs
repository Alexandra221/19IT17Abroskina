using System;

namespace ConsoleApp56
{
    class QuickSorting
    {
        public static void sorting(double[] mass, long first, long past)
        {
            double c = mass[(past - first) / 2 + first];
            double temp;
            long r = first, j = past; // Ввод переменных
            while (r <= j)
            {
                while (mass[r] < c && r <= past) ++r;
                while (mass[j] > c && j >= first) --j;
                if (r <= j) // Перебор элементов массива
                {
                    temp = mass[r];
                    mass[r] = mass[j];
                    mass[j] = temp;
                    ++r; --j;
                }
            }
            if (j > first) sorting(mass, first, j);
            if (r < past) sorting(mass, r, past); //Процесс сортировки
        }
    }
    class test
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Сколько элементов в массиве:");
            int n = int.Parse(Console.ReadLine());
            double[] mass = new double[n];
            var rand = new Random();
            //Заполняем массив рандомными числами
            for (var r = 0; r < mass.Length; r++)
                mass[r] = rand.Next(100);
            double max = mass[0];

            for (int r = 0; r < mass.Length; r++)
            {
                if (max < mass[r])
                {
                    max = mass[r];
                }
            } //Максимальное значение в массиве

            Console.WriteLine("Сгенерированный массив:");
            foreach (double x in mass)
            {
                Console.Write(x + " ");
            } // Выводим массив на экран
            QuickSorting.sorting(mass, 0, mass.Length - 1); // Обращаемся к классу QuickSorting, который сортирует массив, затем выводим массив на экран
            Console.WriteLine("\nОтсортированный массив:");
            foreach (double x in mass)
            {
                Console.Write(x + " ");
            }

            Console.ReadLine();
        }
    }
}
