namespace New_program
{
    class Program
    {
        static void Main(string[] args)
        {
          //  int[] mas = new int[8];
            Random  chislo = new Random(); //Задаём рандом
            int[] mas = new int[1000]; // Объявляем массив
            for (int i = 0; i < 1000; i++) // Заполняем цикл от 0 до 10000 рандомными числами
            {
                mas[i] = chislo.Next(0, 10000);
                Console.WriteLine(mas[i]);
            }
            int R = mas[0];
            Console.WriteLine("Минимальное число: ");
            for (int i = 0; i < mas.Length; i++) //Минимальное значение массива
            {
                if (mas[i] < R) { R = mas[i]; }

            }
            Console.WriteLine(R);

            /* Проверка условия R кратно 21 и является произведением двух случайных чисел массива*/
            if ((R % 21 == 0) && (R == ((mas[new Random().Next(0, mas.Length)]) * (mas[new Random().Next(0, mas.Length)]))))
            {
                Console.WriteLine(R);
            }
            int s = mas[new Random().Next(0, mas.Length)];
            int r = mas[new Random().Next(0, mas.Length)];
            int p = s * r;


            if ((R % 21 == 0) && (R == p && (s - r <= 8 || r - s <= 8))) 
            {
                Console.WriteLine("Число R =" + R); // вывод R
            }

            else { Console.WriteLine("-1"); } //Если условие не подходит, то выводится -1
            Console.Read();
         }
    }
}
