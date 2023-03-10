
int[] numbers = { 4, 13, 32, 11, 9, 2, 15, 31, 21, 7 };
int min = Int32.MaxValue;
for (int i = 0; i < numbers.Length; i++)
{
    min = numbers[i] < min ? numbers[i] : min;
}    
Console.WriteLine(min);