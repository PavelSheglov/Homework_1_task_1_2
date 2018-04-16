using System;


namespace lec_1_hw_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите целое число n:");
                int n = Convert.ToInt32(Console.ReadLine());
                int size = sizeof(int) * 8;
                Console.Write("Введите целое число i (номер бита числа n) - от 0 до {0}:", size - 1);
                byte i = Convert.ToByte(Console.ReadLine());
                if (i >= 0 && i < size)
                {
                    Console.WriteLine("Размерность числа n = {0} бит(а)", size);
                    Console.WriteLine("Его двоичное представление (справа-налево):");
                    int[] temp = new int[size];
                    for (int j = 0; j < size; j++)
                        temp[j] = (n >> j) & 1;
                    for (int j = size - 1; j >= 0; j--)
                        Console.Write(temp[j]);
                    Console.WriteLine();
                    Console.WriteLine("Значение {0}-го бита = {1}", i, (n >> i) & 1);
                }
                else
                    Console.WriteLine("Неверный номер бита");
            }
            catch(FormatException)
            {
                Console.WriteLine("Введены не целые числа!!!");
            }
        }
    }
}
