string[] inputArray = { "cat", "dog", "apple", "hi", "yes", "no", "banana", "pie" };
string[] resultArray = new string[inputArray.Length];
int resultCount = 0;

foreach (var str in inputArray)
{
    if (str.Length <= 3)
    {
        resultArray[resultCount] = str;
        resultCount++;
    }
}

Console.WriteLine("\nМассив строк, длина которых <= 3:");
for (int i = 0; i < resultCount; i++)
    {
    Console.WriteLine(resultArray[i]);
    }
