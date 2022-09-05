using Pre.Linq.Extensions.Cons;

List<int> numbers = new() { 1, 3, 0, 6, 8, 11, 14, 8, 2 };
string[] names = { "Alice", "Bob", "Carol", "Dave", "Eve" };

var numbersAtEvenPosition = numbers.ElementsAtEvenPositions();

Console.WriteLine("Numbers at even positions:");
Console.WriteLine("--------------------------");
foreach(int number in numbersAtEvenPosition)
{
    Console.WriteLine(number);
}
Console.WriteLine();

var namesAtEvenPosition = names.ElementsAtEvenPositions();
Console.WriteLine("Names at even positions:");
Console.WriteLine("------------------------");
foreach(string name in namesAtEvenPosition)
{
    Console.WriteLine(name);
}
Console.WriteLine();

string randomNameAtEvenPosition = names.ElementsAtEvenPositions().TakeRandom();
Console.WriteLine("Random name at even position:");
Console.WriteLine("-----------------------------");
Console.WriteLine($"Result: {randomNameAtEvenPosition}");
Console.WriteLine();

int sumNumbersAtEvenPositionSkipFirstTwo = numbers
    .Skip(2)
    .ElementsAtEvenPositions()
    .Sum();
Console.WriteLine("Sum of numbers at even position (skip first two):");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine($"Result: {sumNumbersAtEvenPositionSkipFirstTwo}");

