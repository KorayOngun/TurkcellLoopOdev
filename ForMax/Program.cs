
int[] numbers = { 4, 13, 32, 11, 9, 2, 15, 31, 21, 7 };
int max = Int32.MinValue;
for (int i = 0; i < numbers.Length; i++)
{
    max = numbers[i] > max ? numbers[i] : max;
}
Console.WriteLine(max);