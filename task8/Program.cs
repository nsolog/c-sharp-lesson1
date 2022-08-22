Console.Write("Введите число: ");
string number = Console.ReadLine();

int convertedNumber = int.Parse(number);

for (int i = 1; i <= convertedNumber; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}