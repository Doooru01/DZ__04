// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("введите число");
int A = Convert.ToInt32(Console.ReadLine());
int S = 0;
for (int D = A; D > 0; D = D / 10)
{
    S = S + D % 10;
}
Console.WriteLine(S);