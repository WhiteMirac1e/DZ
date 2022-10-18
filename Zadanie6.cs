string Ev(int num)
    {
        string result = "Нечетное";
        if (num % 2 == 0 )
            {
                result = "Четное";
                return result;
            }
            else
                {
                    return result;
                }
    }


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ev(num));
