Console.WriteLine("Введите 3 числа: ");
string numberA = Console.ReadLine();
string numberB = Console.ReadLine();
string numberC = Console.ReadLine();

int convertedNumberA = int.Parse(numberA);
int convertedNumberB = int.Parse(numberB);
int convertedNumberC = int.Parse(numberC);

int max = convertedNumberA;

if (convertedNumberB > max)
{
    max = convertedNumberB;
}

if (convertedNumberC > max)
{
    max = convertedNumberC;
}

Console.Write("max = ");
Console.Write(max);