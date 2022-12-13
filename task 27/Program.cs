// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int total = 0;
while(num != 0)
{
    total += num%10;
    num = num/10;
}
Console.WriteLine("Сумма цифр числа равна: " + total);
