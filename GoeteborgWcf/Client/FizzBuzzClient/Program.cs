using System;
using System.Linq;

namespace FizzBuzzClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fizz Buzz Demo");
            Console.Write("Enter the limit: ");

            string x = Console.ReadLine();

            if (string.IsNullOrEmpty(x.ToString()))
            {
                Console.WriteLine("ERROR :: Ingrese un número");

            }

            GetLimit(x);
            Console.Read();
        }

        #region Test 1

        static void GetLimit(string value)
        {
            int numberLimit = 0;

            if (int.TryParse(value, out numberLimit))
            {
                using (FizzBuzzzReference.FizzBuzzServiceClient client = new FizzBuzzzReference.FizzBuzzServiceClient())
                {
                    var test = client.GetCalculate(numberLimit);

                    var result = test.ToList();
                    if (result.Any())
                    {
                        foreach (var item in result)
                        {
                            Console.WriteLine(item);
                        }
                    }

                    Console.WriteLine(test);
                }
            }
            else
            {
                Console.WriteLine("Invalid inputs!.");
            }

            Console.ReadKey();
        }
        #endregion
    }
}
