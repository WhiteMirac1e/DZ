//Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for  ( int i =2; i <= num; i = i + 2 ) 
    {
        Console.WriteLine(i);
    }
