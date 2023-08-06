// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine()!);
int result = 1;
Console.Write("Чётные числа от 1 до " + num + ": " );
if (num % 2 == 0)
{
    while (result <= num)
    {
        if (result % 2 == 0)
        {
            if (result == num)
            {
                Console.Write(result);
            }
            else
            {
                Console.Write(result + ", ");
            }
    }
    
    result++;
    }
}
else
{
    while (result < num)
    {
        if (result % 2 == 0)
        {
            if (result == num-1)
            {
                Console.Write(result);
            }
            else
            {
                Console.Write(result + ", ");
            }
        }
    
    result++;
    }
}