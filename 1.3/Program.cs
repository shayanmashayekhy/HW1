//1.3&1.4

Console.WriteLine("please enter num 1 :");
var num1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please enter num 2 :");
var num2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Sqrt(num1));
Console.WriteLine(Math.Sqrt(num2));
Console.WriteLine(Math.Pow(num1, num2));
Console.WriteLine(Math.Pow(num2, num1));

//Console.WriteLine(Math.Sqrt(num1));
//Console.WriteLine(Math.Sqrt(num2));
//Console.WriteLine(Math.Pow(num1, num2));
//Console.WriteLine(Math.Pow(num2, num1));

int[] num = {num1 , num2};

for (; ; )
{
    Console.WriteLine(Math.Sqrt(num1));
    Console.WriteLine(Math.Sqrt(num2));
    Console.WriteLine(Math.Pow(num1, num2));
    Console.WriteLine(Math.Pow(num2, num1));
    break;
}