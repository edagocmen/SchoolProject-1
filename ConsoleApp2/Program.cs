namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        int passedProducts = 0;
        int defectiveProducts = 0;
        int productCounter = 1;

        while (productCounter <= 10)
        {
            Console.Write("Write the test result: ");
            string answer= Console.ReadLine().Replace(" ", "");
            if (answer.ToLower()== "passed" || answer.ToLower() == "pass" || answer.ToLower() == "p")
            {
                passedProducts++;
                productCounter += 1;
            }
//tek tırnak yazınca hata veriyor == dikkat et
            else if (answer.ToLower() == "defective" || answer.ToLower() == "defected" || answer.ToLower() == "d")
            { 
                defectiveProducts++;
                productCounter += 1;
            }
            else
            {
                Console.WriteLine("please enter valid answer");
                
            }

            if (productCounter == 10)
            {
                Console.WriteLine("Products passed: " + passedProducts);
                Console.WriteLine("Products defective: " + defectiveProducts);
                if (defectiveProducts > 3)
                {
                    Console.WriteLine("Check the production line!");
                }
            }
        }    

        Console.ReadKey();
    }
}