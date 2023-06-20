// Задача 10
Console.WriteLine("Программа принемает трех значное число и выводит вторую цифру");
int a = int.Parse(Console.ReadLine() ?? "");
int b = (a % 10);
int c = ((a % 100 - b) / 10);
Console.WriteLine($"Cередина данного числа   {c} " );

// Задача 13
int number = ReadInt("Введите число и программа покажет 3 цифру по порядку : ");
int count = number.ToString().Length;
Console.WriteLine(MakeArray(number, count));

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
    int zaza = 0;
    if (b < 3)
    {
        Console.WriteLine("Третья цыфра в количестве : ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        zaza = (a / c) % 10;
    }
    return zaza;

    
}
// Задача 15
Console.WriteLine("Введите число дня недели от 1 до 7: ");
int number_a = int.Parse(Console.ReadLine() ?? "");
if (number_a < 1 ^ number_a > 7)
    Console.WriteLine("Вы ввели неверное число");

if (number_a > 5 && number_a < 8)
    Console.WriteLine("Да, этот день выходной!");

if (number_a > 0 && number_a < 6)
    Console.WriteLine("Это рабочий день! ");

    // Алчакова Ильи