// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// == сравнить
// = присвоить

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > b && a > c)

{
    max = a;
}

else if(b > a && b > c)
{
   max = b;
}

else if(c > a && b < c)
{
   max = c;
}
System.Console.WriteLine(max);
