//Integer tam sayıları tutmak için kullanırız. (-2147483648 ile 2147483647 arasında değer verebiliriz.)
//Long tam sayıları tutmak için kullanırız. (-9223372036854775808 ile 9223372036854775807 arasında değer verebiliriz.)
//Short tam sayıları tutmak için kullanırız. (-32768 ile 32767 arasında değer alır.)
//Byte tam sayıları tutmak için kullanırız. (0 ile 255 arasında değer alır.)
//Bool true-false kontrolü için kullanılız. (true ya da false alır.)
//Char tek karakter tutmak için kullanırız. (tek bir karakter tutabilir.)
//Double ondalıklı sayıları tutmak için kullanırız. 
//Decimal daha hassas sayıları tutmak için kullanılır.
//Enum sabitleri 0'dan başlar. Fakat bu değeri değiştirebiliriz. İstersek tüm değerleri kendimiz verebiliriz.
//Var değişken tanımlamak için kullanırız. Herhangi bir tipte değişken tanımlayabiliriz. (string, int, char vb.)

int number1 = 2147483647;
long number2 = 9223372036854775807;
short number3 = 32767;
byte number4 = 255;
bool condition = true;
char character = 'E';
double number5 = 5.75;
decimal number6 = 10;
var number7 = 17;
number7 = 'C'; //Başlangıçta int verdiğimiz için C'nin sayısal değerini ekrana yazdırır.

Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine(condition);
Console.WriteLine("Character is {0}", ((int)character)); //E karakterinin sayısal değerini ekrana bastırır.
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine((int)Days.Friday);
Console.WriteLine("Number7 is {0}", number7);
Console.ReadLine();

enum Days
{
    Monday = 12, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    // Başlangıç 12 verdik. Sonra kendisi 1'er 1'er arttırdı.
    // Hepsine ayrı değerler de verebiliriz.
}

