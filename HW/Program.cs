/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);
*/

/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30


Console.Write("");
Console.WriteLine();
int numberM = EnterUserData("Введите M:");
int numberN = EnterUserData("Введите N:");
int temp = 0;
if (numberM > numberN)
{
    temp = numberM;
    numberM = numberN;
    numberN = temp;
}
Console.WriteLine();
Console.Write($"Сумма всех чисел от {numberM} до {numberN} = {SumFunction(numberM, numberN)}");
Console.WriteLine();

int SumFunction(int startValue, int endValue)
{
    if (startValue == endValue)
    {
        return startValue;
    }
    return SumFunction(startValue, endValue - 1) + endValue ;
}

int EnterUserData(string nameUserData )
{
    Console.Write($"{nameUserData}");
    return int.Parse(Console.ReadLine());
}
*/

/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

AkkermanFunction(m, n);



void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n));
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
*/