int[] numbers = { 4, 13, 32, 11, 9, 2, 15, 31, 21, 7 };
int index = 0;
int lastIndex = numbers.Length;
int min = Int32.MaxValue;
while (index < lastIndex)
{
    min = numbers[index] < min ? numbers[index] : min;
    index++;
}
Console.WriteLine(min);

//--------------------------------------------------------------
//while (index < lastIndex)
//{
//    min = numbers[index++] < min ? numbers[index-1] : min;
//}
//Console.WriteLine(min);

//--------------------------------------------------------------
//while (true)
//{
//    min = numbers[index] < min ? numbers[index] : min;
//    index++;
//    if (index == lastIndex) break;
//}
//Console.WriteLine(min);