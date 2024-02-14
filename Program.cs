// задача 1
// Задайте значение М и N
// Напишите прогу, которая выведет все натур числа в промежутке от М до N
// Использовать рекурсию, не использовать циклы


Console.Write("Введите значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());
void PrintNaturalNumbers(int m, int n)
{
if (m > n)
return;

Console.Write($"{m}, ");

PrintNaturalNumbers(m+1,n);

}
PrintNaturalNumbers(m,n);
