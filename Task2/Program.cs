Console.WriteLine("Введите число 1");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2=Convert.ToInt32(Console.ReadLine());
int max=number1;
int min=number2;

if (number1>number2) 
{
    max=number1;
    min=number2;
}
if (number2>number1) 
{
    max=number2;
    min=number1;
}

Console.Write("max=");
Console.WriteLine(max);
Console.Write("min=");
Console.WriteLine(min);

