﻿Console.Clear();
Console.Write("Введите число натуральное число N: ");
int numberN = int.Parse(Console.ReadLine());
int count=1;
while (count<=numberN)
{
    if (count%2==0)
    {
        Console.Write(count);
        count++;
    }
    else 
    {
        Console.Write(" ");
        count++;
    }
}


