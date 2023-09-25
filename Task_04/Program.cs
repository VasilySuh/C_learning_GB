// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//Вводим и фиксируем первое число.
Console.WriteLine("Введите первое число:");
int frstNum = Convert.ToInt32(Console.ReadLine());

//Вводим и фиксируем второе число.
Console.WriteLine("Введите второе число:");
int secNum = Convert.ToInt32(Console.ReadLine());

//Вводим и фиксируем третье число.
Console.WriteLine("Введите третье число:");
int thrdNum = Convert.ToInt32(Console.ReadLine());

//Назначаем первое значение максимальным и сравниваем через ветки.
int maxNum = 0;
int size = 3;
int count = 1;

while (size > count);
{
    if (frstNum > secNum);
        {
            maxNum = frstNum;
            count = count + 1;
        }
    if else (secNum > frstNum);
        {
        maxNum = secNum;
        count = count + 1;
        }
    if (thrdNum > maxNum);
        {
            maxNum = thrdNum;
            count = count + 1;
        }
}
Console.Write("Максимальное число:");
Console.WriteLine(maxNum);