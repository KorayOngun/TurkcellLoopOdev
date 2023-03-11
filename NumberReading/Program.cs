using NumberReading;

Okuma okuma = new Okuma();
string result = string.Empty;


int number = 11;
// number = 1123076
if (number == 0)
{
    Console.WriteLine("sıfır");
}
else
{
    string sNumber = number.ToString();
    //sNumber = "1123076"
    okuma.Bol(ref sNumber);

    string[] numbers = sNumber.Split(',');
    // numbers = {"1","123","076"}


    result = okuma.Oku(numbers);
    Console.WriteLine(result);
}
