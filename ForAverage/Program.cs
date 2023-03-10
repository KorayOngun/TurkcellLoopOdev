int[] numbers = { 4, 13, 32, 11, 9, 2, 15, 31, 21, 7 };
double total  = 0; 
int index  = numbers.Length;
for (int i = 0; i < index; i++)
{
    total += numbers[i];
}
double average = total / numbers.Length;
Console.WriteLine($"Ortalama {average}");



//----------------------------------------------------------
//int i;
//for (i=0; i < numbers.Length; i++)
//{
//    total += numbers[i];
//}
//Console.WriteLine($"Ortalama {total/i}");