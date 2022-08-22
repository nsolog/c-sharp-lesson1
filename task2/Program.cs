Console.Write("Введите первое число: ");
string a = Console.ReadLine();
Console.Write("Введите второе число: ");
string b = Console.ReadLine();

int convertedA = int.Parse(a);
int convertedB = int.Parse(b);

if (convertedA > convertedB)
{
    Console.Write("max = ");
    Console.Write(a);
}
else
{
    Console.Write("max = ");
    Console.Write(b);
}