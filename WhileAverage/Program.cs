int[] numbers = { 4, 13, 32, 11, 9, 2, 15, 31, 21, 7 };

double total = 0;
int index = 0;
double average = 0;
// index++ bir satır sonra çalışacağı için <numbers.length-1> değil
int lastIndex = numbers.Length;

while (index < lastIndex)
{
    total += numbers[index++];
}
average = total / lastIndex;
Console.WriteLine($"Ortalama {average}");

//while (true)
//{
//    total += numbers[index++];
//    if (index == lastIndex) break;
//}
//average = total / numbers.Length;
//Console.WriteLine($"Ortalama {average}");
