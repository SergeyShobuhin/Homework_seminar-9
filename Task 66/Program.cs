// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Определяем число и передаём в метод
Console.WriteLine("Введите число M:");
int numStart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int numEnd = Convert.ToInt32(Console.ReadLine());

int sum = SumNaturalElement(numStart, numEnd);
Console.WriteLine($"Сумма натуральных элементов в диапазоне от {numStart} до {numEnd} = {sum}");

// задаём метод рекурсии
int SumNaturalElement(int numStart, int numEnd)
{

    if (numStart == numEnd)
    {
        Console.WriteLine($"{numEnd}"); // для общего понимания - последнее действие на соответствие условия для завершения рекурсии
        return numEnd;


    }
    Console.Write($"{numStart}" + " + "); // выводим цикл пока не выполнится numStart == numEnd

    int sum = numStart + SumNaturalElement(numStart + 1, numEnd); // суммируем все циклы рекурсии


    if (numStart > numEnd)
    {

        return numEnd + SumNaturalElement(numStart, numEnd);

    }

    return sum;

}
