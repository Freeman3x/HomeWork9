//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if(n > 1)ShowNumbers(n -1);
}

Console.WriteLine("Input N: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);
*/

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
/*int SumNumbersMN(int n,int m)
{
    if(Math.Max(n,m) != Math.Min(n,m)) return SumNumbersMN(Math.Max(n,m),Math.Min(n,m)+1)+  Math.Min(n,m);
    else return 0;
}

Console.WriteLine("Input N: ");
int num_n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input M: ");
int num_m = Convert.ToInt32(Console.ReadLine());
int res = SumNumbersMN(num_n,num_m) + Math.Max(num_m,num_n);
Console.WriteLine(res);
*/

//Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную
/*void Perevod(int a)
{
    if(a > 0) Perevod(a / 2);
    {
    if(a % 2 > 0) Console.Write(1 + " ");
    else Console.Write(0 + " ");
    }
}

Console.WriteLine("Input N: ");
int num = Convert.ToInt32(Console.ReadLine());
Perevod(num);
*/
