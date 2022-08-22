Console.Write("Введите первое число: ");
string numberA = Console.ReadLine();
Console.Write("Введите второе число: ");
string numberB = Console.ReadLine();

int convertedA = int.Parse(numberA);
int convertedB = int.Parse(numberB);

if (convertedA > convertedB)
{
    Console.Write("max = ");
    Console.Write(convertedA);
}
else
{
    Console.Write("max = ");
    Console.Write(convertedB);
}