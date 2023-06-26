// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Exponentiation

int Exponentiation()
{
Console.WriteLine("введите A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите B");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for (int i = 2; i <= B; i++)
{
    result = result * A;
}
return result;
}

Console.WriteLine (Exponentiation());
