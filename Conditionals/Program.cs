//If else yapısını koşulları kontrol etmek için kullanırız.

Console.WriteLine("-----If-Else-----");
int number1 = 27;
if (number1 == 27)
{
    Console.WriteLine("Number is 27");
}
else if (number1 == 28)
{
    Console.WriteLine("Number is 28");
}
else
{
    Console.WriteLine("Number is not 27 or 28");
}

Console.WriteLine("-----Single Line If-----");
int number2 = 11;
Console.WriteLine(number2 == 10 ? "Number is 10" : "Number is not 10");

Console.WriteLine("-----Switch-Case-----");
switch (number1)
{
    case 17:
        Console.WriteLine("Number is 17");
        break;
    case 27:
        Console.WriteLine("Number is 27");
        break;
    default:
        Console.WriteLine("Number is not 17 or 27");
        break;
}

Console.WriteLine("-----Çoklu Şart-----");
if (number2 > 0 && number2 < 100)
{
    Console.WriteLine("Number2 is between 0-100");
}
else if (number2 >= 100 && number2 < 200)
{
    Console.WriteLine("Number2 is between 100-200");
}
else if (number2 > 200 || number2 < 0)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}

Console.WriteLine("-----İç İçe If-----");
if (number1 > 0 && number1 < 100)
{
    if (number1 >= 50 && number1 <= 99)
    {
        Console.WriteLine("Number1 50 ile 99 arasındadır.");
    }
    else if (number1 < 50 && number1 >= 0)
    {
        Console.WriteLine("Number1 0 ile  50 arasındadır.");
    }
}
else
{
    Console.WriteLine("Number1 0-100 arasında değildir.");
}

Console.ReadLine();
