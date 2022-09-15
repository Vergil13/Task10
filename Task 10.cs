
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Write("введите трехъзначное число");
int x=Convert.ToInt32(Console.ReadLine());
if   (x<=99)
Console.Write("Отсутствует 3 я цифра   ");
else if (x>=1000)
Console.WriteLine("вы ввели слишком большое число");
else 
 Console.WriteLine(Convert.ToString(x)[1]);

