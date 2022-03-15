Main();
static void Main()

{
    int[] arr1 = new int[10000];
    int i, n, sum,result;


    Console.WriteLine("Input the number of elements to be enter :");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input {0} elements in the array :", n);
    for (i = 0; i < n; i++)
    {
        Console.Write("element - {0} : ", i);
        arr1[i] = Convert.ToInt32(Console.ReadLine());
        
    }

    Console.WriteLine("-");
    Console.WriteLine("+");
    Console.WriteLine("*");
    Console.WriteLine("/");
    Console.WriteLine("5 - sort.min");
    Console.WriteLine("6 -continue of Q3 ");
    string action = Console.ReadLine();
    switch (action)
    {
        case "+":
            {
                sum = arr1.Sum();
                Console.WriteLine(sum);

                break;
            }
        case "-":
            {
                int sub = 0;
                foreach (int item in arr1)
                {
                    sub-=item;
                }
                Console.WriteLine(sub);

                break;
            }
        case "*":
            {
                int multi = 0;
                foreach (int item in arr1)
                {
                    multi*=item;
                }
                Console.WriteLine(multi);
                break;
            }
        case "/":

            {
                int division = 0;
                foreach (int item in arr1)
                {
                    division*= item;
                }
                Console.WriteLine(division);
                break;
            }
        case "5"://sortmin
            {
                int Count = 0;
                for (int x = 0; x < n; x++)
                {
                    for (int y = x +1; y < n; y++)
                    {
                        if (arr1[x] == arr1[y])
                        {
                            Count++;
                        }
                    }
                    
                     
                    
                }
                for (i = n -1; i >= 0; i--)
                {
                    Console.WriteLine(arr1[i]);
                }

                break;

            }
        case "6":
            {
              string[] strarr1 = Array.ConvertAll(arr1,ele=>ele.ToString());
              for (int x = 0; x < n; x++)
              {
                    for (int j = x + 1; j < n; j++)
                    {
                        Console.WriteLine($"({arr1[x]}, {arr1[j]})");
                        Console.WriteLine(arr1[x] * arr1[j]); 
                        Console.WriteLine(arr1[x] / arr1[j]);
                        Console.WriteLine(arr1[x] - arr1[j]);
                        Console.WriteLine(arr1[x] + arr1[j]);
                        Console.WriteLine("-------------------");
                        if (strarr1[5] == null)
                        {
                            Console.WriteLine("the element of array not enough");
                            Main();
                        }
                        else
                        {
                            continue;
                        }
                        result = arr1[0] * arr1[1];
                        int result1 = arr1[2] / arr1[3];
                        int result2 = arr1[4] - arr1[5];
                        int result4 = arr1[6] + arr1[7];
                        int result3 = result + result1 + result2 + result4; 
                        Console.WriteLine(result + result1 + result2 + result4);
                        if (result3 == 0)
                        {
                            Console.WriteLine("the result is zero");
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                        break; 


                    }
              }
                break;
            }
        default:
            Console.WriteLine("action not valued");
            break;







    }



}




