using System;

namespace application1
{
    class Program
    {
        public static decimal calCost(int quantity, decimal unitCost)
        {
            return quantity * unitCost;
        }
        static void Main(string[] args)
        {
            var name = String.Empty;
            var cash = 0.0m;
            var beverage = "";
            var unitCost = 0.0m;
            var selection = 'a';
            var ageTo = 0.0;
            var quantity = 0;
            var EXIT = false;
            Console.WriteLine("Hello Everyone Welcome!");
            while (name == "")
            {
                Console.WriteLine("Enter your name:");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Hello {name}");

            Console.WriteLine($"Enter your age {name}");
            var x = Console.ReadLine();
            ageTo = Convert.ToInt32(x);


            if (ageTo < 18)
            {
                Console.WriteLine($"{name} you cannot buy beverage in this site");

            }
            else
            {
                do
                {


                    Console.WriteLine("You can select the following beverages \nA.Whisky\nB.Beer\nC.Wine");
                    var select = Console.ReadLine();
                    selection = Convert.ToChar(select);
                    switch (selection)
                    {
                        case 'A':
                            beverage = "Whisky";
                            Console.WriteLine("Enter number of bottles:");
                            var ans = Console.ReadLine();
                            quantity = Convert.ToInt16(ans);
                            unitCost = 10.0m;
                            break;
                        case 'B':
                            beverage = "beer";
                            Console.WriteLine("Enter number of bottles:");
                            var ans1 = Console.ReadLine();
                            quantity = Convert.ToInt16(ans1);
                            unitCost = 5.0m;
                            break;
                        case 'C':
                            beverage = "wine";
                            Console.WriteLine("Enter number of bottles:");
                            var ans2 = Console.ReadLine();
                            quantity = Convert.ToInt16(ans2);
                            unitCost = 16.0m;
                            break;
                        default:
                            Console.WriteLine("enter correct choice");
                            break;
                    }


                    cash = Program.calCost(quantity, unitCost);
                    Console.WriteLine($"Your beverage is {beverage} Your total amount is{cash} ");
                    Console.WriteLine("press y to exit or press any key to continue");
                    var z = Console.ReadLine();
                    if (z == "y")
                    {
                        EXIT = true;
                    }
                } while (EXIT == false);
            }
        }


    }
}
