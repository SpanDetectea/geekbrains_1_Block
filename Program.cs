string[] array = { "Hello", "2", "world", ":-)" };
// string[] array = { "1234", "1567", "-2", "computer science" };
// string[] array = { "Russia", "Denmark", "Kazan" };
int count = 0;
for (int i = 0; i <= array.GetLength(0) - 1; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}
string[] newArray = new string[count];
count = 0;
for (int i = 0; i <= array.GetLength(0) - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[count] = array[i];
        count++;
    }
}
System.Console.WriteLine($"[{String.Join(", ", newArray)}]");