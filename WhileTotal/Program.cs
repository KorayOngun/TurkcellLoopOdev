int[] numbers = { 4, 13, 32, 11, 9, 2, 15, 31, 21, 7 };

int total = 0;
int index = 0;


int lastIndex = numbers.Length;

while (index < lastIndex)
{
    total += numbers[index++];
}
Console.WriteLine($"Toplam {total}");

//while (true)
//{
//    total += numbers[index++];
//    if (index == numbers.Length) break;
//}
//Console.WriteLine($"Toplam {total}");


