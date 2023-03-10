int[] numbers = { 4, 13, 32, 11, 9, 2, 15, 31, 21, 7 };
int total = 0;
for (int i = 0; i < numbers.Length; i++ )
{
    total += numbers[i];
}
Console.WriteLine( $"Toplam {total}" );

