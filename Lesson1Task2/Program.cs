// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int[] Numbers = { 2, 3, 7 };

int max = Numbers[0];
for (int i = 1; i < Numbers.Length; i++)
{
    if (Numbers[i] > max)
    {
        max = Numbers[i];

    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Максимальное число {max}");
System.Console.WriteLine();
