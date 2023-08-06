// Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше
Console.Write("Введите число №1 ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число №2 ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1>num2)
{
    Console.WriteLine("Число " + num1 + " больше числа " + num2);
}
else if (num2 > num1)
    {
        Console.WriteLine("Число" + num2 + " больше числа " + num1);
    }
    else 
        {
            Console.WriteLine("Число " + num1 + " равно " + num2);
        }