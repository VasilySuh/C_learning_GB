// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int sizeNum = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] numbers = {0, sizeNum - 1};
while (count < sizeNum);
{
    if (count % 2 == 0)
    {
        numbers = + count;
        count = count + 1;
    }
    else
    {
        count = count + 1;
    }
}
Console.WriteLine(numbers);