namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве:");
            int n = int.Parse(Console.ReadLine());//Создание массива
            int[] m = new int[n];//Переменная с рандомом
            var rand = new Random();
            for (var i = 0; i < n; i++) //Вводим рандом чисел от 0 до 100
                m[i] = rand.Next(0, 100);
            Console.WriteLine("Массив:");//Выводим изначальный массив 
            for (var i = 0; i < m.Length; i++)
            {
                Console.Write($"[{i}]=");
                Console.WriteLine(m[i]);
            }
             // Сортировка
            Console.WriteLine("Сортировка по возрастанию: ");
            Array.Sort(m);
            for (var i = 0; i < m.Length; i++)
            {
                Console.Write($"[{i}]=");
                Console.WriteLine("{0} ", m[i]);
            }
            /* Сортируем для вывода 3 первых мест */
            int a = m[0];
            int b = m[1];
            int c = m[2];
            for (int i = 3; i < n; i++)
            {
             if (m[i] >= a || m[i] >= b || m[i] >= c)
               {
               if (a <= b && a <= c)
                 {
                  a = m[i];
                   }
                   else
                    {
                     if (b <= c)
                      {
                       b = m[i];
                      }
                    else
                     {
                       c = m[i];
                     }
                    }
                }
            }
            //Вывод трёх первых мест
            Console.Write($"3 первых места: Первое место-{a} Второе место-{c} Третье место -{b} ");
            Console.ReadLine();
        }
    }
}
