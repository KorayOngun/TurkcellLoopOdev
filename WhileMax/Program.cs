int[] numbers = { 4, 13, 32, 11, 9, 2, 15, 31, 21, 7 };
int index = 0;
int lastIndex = numbers.Length;
int max = Int32.MinValue;

while (index < lastIndex)
{
    max = numbers[index] > max ? numbers[index] : max;
    index++;
}
Console.WriteLine(max);
//--------------------------------------------------------------
//while (index < lastIndex)
//{
//    max = numbers[index++] > max ? numbers[index-1] : max;
//}
//Console.WriteLine(max);

//--------------------------------------------------------------
//while (true)
//{
//    max = numbers[index] > max ? numbers[index] : max;
//    index++;
//    if (index == lastIndex) break;
//}
//Console.WriteLine(max);