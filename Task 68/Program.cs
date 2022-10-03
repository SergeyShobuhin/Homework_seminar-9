// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Определяем число и передаём в метод
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

var rezult = GetAkkermanСalculations(m, n);
Console.WriteLine($"A({m},{n}) = {rezult}");

// объявляем метод рекурсии
int GetAkkermanСalculations(int m, int n)
{

    if (m <= 0) // будем считать что отрицательное число это "0", поэтому <= , аналогично для n
    {
        rezult = n + 1;
        return rezult;
    }

    if (n <= 0)
    {
        return GetAkkermanСalculations(m - 1, 1);
    }

    else
    {

        return GetAkkermanСalculations(m - 1, GetAkkermanСalculations(m, n - 1));

    }
}

