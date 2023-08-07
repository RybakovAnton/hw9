//Задача 66: Задайте значения M и N. Напишите программу, которая найдет
// сумму натуральных элементов в промежутке от M до N.
// M = 1 N = 15 -> 120
// M = 4 N = 8 -> 30

Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int SumNumber(int start, int end)
{
    if (start==end)
    {
        return end;
    }
    else 
    {
        return start + SumNumber(start + 1, end);
    }
    
}

Console.WriteLine(SumNumber(num, num2));
