internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        // 2, 3, 7 -> 7
        // 44 5 78 -> 78
        // 22 3 9 -> 22
        Console.Write("Введите число: "); // ввод значений
        int numberA = Convert.ToInt32(Console.ReadLine()); // ЧТение целого числа
        Console.Write("Введите число: "); // ввод значений
        int numberB = Convert.ToInt32(Console.ReadLine()); // ЧТение целого числа
        Console.Write("Введите число: "); // ввод значений
        int numberC = Convert.ToInt32(Console.ReadLine()); // ЧТение целого числа

        if (numberA < numberB)
        {
         numberA = numberB;
        }
         if (numberA < numberC)
        {
         numberA = numberC;
        }
        
        Console.WriteLine("max : " + numberA);
    }
}