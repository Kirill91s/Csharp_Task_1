// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: "); // ввод значений
        int numberA = Convert.ToInt32(Console.ReadLine()); // ЧТение целого числа

        Console.Write("Введите число: "); // ввод значений
        int numberB = Convert.ToInt32(Console.ReadLine()); // ЧТение целого числа

        if (numberA > numberB)
        {
            Console.WriteLine($"min: {numberB}" );
            Console.WriteLine($"max: {numberA}" );
        }
        else if (numberA < numberB)
        {
             Console.WriteLine($"min: {numberA}" );
             Console.WriteLine($"max: {numberB}" );
        }
        else 
        
        { 
            Console.WriteLine("Проверь числа" );
        }

    }
}