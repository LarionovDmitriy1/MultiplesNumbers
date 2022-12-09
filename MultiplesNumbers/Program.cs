using MultiplesNumbers;
Numbers number = new();
Console.WriteLine("Введите число");
Console.WriteLine();
string enter = Console.ReadLine();
bool isParse = int.TryParse(enter, out var numbers);
if (isParse)
{
    number.CheckingForTheMultiplicityOfANumber(numbers);
}
else
{
    Console.WriteLine();
    Console.WriteLine("Ошибка");
    Console.WriteLine();
}