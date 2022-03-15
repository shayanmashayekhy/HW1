//1.1
bool istrue = true;
while (istrue)
{ 
    Console.WriteLine("please enter your numbers");
    Console.Write("num1 :");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("num2 :");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("num3 :");
    int num3 = Convert.ToInt32(Console.ReadLine());
    Console.Write("num4 :");
    int num4 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("please select your operator :");
    Console.WriteLine(" for + please press A");
    Console.WriteLine(" for - please press B");
    Console.WriteLine(" for * please press C");
    Console.WriteLine(" for / please press D");

    var _operator = Console.ReadKey();
    Console.WriteLine();
    switch (_operator.Key)
    {
        case ConsoleKey.A:
            Console.WriteLine($"{num1} + {num2} + {num3} + {num4} = {num1 + num2 + num3 + num4}");
            break;
        case ConsoleKey.B:
            Console.WriteLine($"{num1} - {num2} - {num3} - {num4} = {num1 - num2 - num3 - num4}");
            break;
        case ConsoleKey.C:
            Console.WriteLine($"{num1} * {num2} * {num3} * {num4} = {num1 * num2 * num3 * num4}");
            break;
        case ConsoleKey.D:
            Console.WriteLine($"{num1} / {num2} / {num3} / {num4} = {num1 / num2 / num3 / num4}");
            break;

        default:
            Console.WriteLine("your input not available");
            break;

    }
}