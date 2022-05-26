//  Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа по убыванию в промежутке от M до  N.
//  M = 1; N = 5. -> "5,4,3,2,1"
//  M = 4; N = 8. -> "8,7,6,5,4"

Console.Clear();

/*int m = InputNumbers("Введите значения m: ");
int n = InputNumbers("Введите значения n: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void GetNumbers(int m, int n)
{
    if (n > m + 1)
    {
        Console.WriteLine($"{n - 1}");
        GetNumbers(m, n - 1);
    }
}

void PrintNumber(int n, int count)
{
    if (count > n) return;
    PrintNumber(n, count + 1);
    Console.Write(count + ", ");
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}*/




//  Задача 66: Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8  -> 30

/*int m = InputNumber("Введите значение m: ");
int n = InputNumber("Введите значение n: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {sum} ");
        return;
    }
    PrintSumm(m, n - 1, sum);
}
int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int GetSum(int m, int n)
{
    if (m >= n) return (m + GetSum(m + 1, n));
    return 0;
}
*/



//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//  m = 3, n = 2  ->  A(m,n) = 29

int m = InputNumber("Введите значение m: ");
int n = InputNumber("Введите значение n: ");
int functionAkkermana = Akk(m, n);
Console.Write($"Функция Аккермана = {functionAkkermana} ");

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akk(m - 1, 1);
    else return Akk(m - 1, Akk(m, n - 1));
}
int InputNumber (string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

