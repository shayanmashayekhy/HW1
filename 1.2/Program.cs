

class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("Enter the action to be performed");
        Console.WriteLine("Press 1 for Addition");
        Console.WriteLine("Press 2 for Subtraction");
        Console.WriteLine("Press 3 for Multiplication");
        Console.WriteLine("Press 4 for Division");
        Console.WriteLine("please enter action 1:");
        int action1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please enter action 2 :");
        int action2 =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 1st input");
        int input_1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd input");
        int input_2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 3st input");
        int input_3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 4nd input");
        int input_4 = Convert.ToInt32(Console.ReadLine());
        int[] array = { input_1, input_2, input_3, input_4 };
        foreach (int i in array)
        {
            int result = 0;
            switch (action1)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();

            switch (action2)
            {
                case 1:
                    {
                        result = Addition(input_3, input_4);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_3, input_4);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_3, input_4);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_3, input_4);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;



            }
        }
    }




        //Addition  
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Substraction  
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Division  
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
}

