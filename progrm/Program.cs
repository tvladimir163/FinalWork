Console.Clear();

string[] array1 = new string[6] {"hello", "world", "1", "22", "333", "4444"};
string[] array2 = new string[array1.Length];

int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
Console.WriteLine($"первый массив: [{string.Join(" ", array1)}]");
Console.WriteLine($"второй массив: [{string.Join(", ", array2)}]");