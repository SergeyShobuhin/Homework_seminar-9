// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Определяем число и передаём в метод
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

var rezult = NaturalNumbers(number);
Console.WriteLine(rezult);

// Рекурсивный метод
string NaturalNumbers(int n)
{

    if (n == 1) // метод будет вызывать себя пока не выполнится первое условие
    {
        return "1 - Ваш результат";
    }

    if (n <= 0)
    {
        return "Вы ввели число меньше 1";
    }
    else
    {
        string probel = ", "; // дополнительная переменная для понимания рекурсии (, при = 1 вернёт первый if)
        string numbers = $"{n + probel + NaturalNumbers(n - 1)}";
        // Console.WriteLine(numbers);

        return numbers;
    }

}





