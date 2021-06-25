namespace VendingMachine
{
    using System;
    using VendingMachine.ClassLibrary;
    using static VendingMachine.ClassLibrary.Types;

    class Program
    {
        public static string Greet()
        {
            return "Greetings!";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Greet());

            var product = new Product();
            var revenue = new Revenue();

            product.Stock(20, 10, 5);

            Console.WriteLine(product.Display());

            while (true)
            {
                Console.Write("What would you like? Pick an item number: ");
                var itemType = Console.ReadLine();

                int selectedItem = itemType switch { "1" => 1, "2" => 2, "3" => 3, _ => 0, };

                decimal selectedItemPrice = 0;
                if (selectedItem == 0)
                    Console.WriteLine("Incorrect selection!");
                else
                {
                    selectedItemPrice = product.MachineItems[selectedItem].Item2;
                    Console.WriteLine("The selected item costs: " + selectedItemPrice);
                }

                Console.WriteLine("Insert Nickel (type n), Dime (type d), or Quarter (type q)");
                while (true)
                {
                    string insertedCoin = Console.ReadLine().ToLower() switch
                    {
                        "n" => "Nickel",
                        "d" => "Dime",
                        "q" => "Quarter",
                        _ => string.Empty,
                    };
                    if (Enum.IsDefined(typeof(CoinType), insertedCoin))
                        revenue.AcceptCoins((CoinType)Enum.Parse(typeof(CoinType), insertedCoin));
                    else
                        Console.WriteLine("Invalid coin inserted!, coin returned");

                    if (revenue.InsertedCoins >= selectedItemPrice)
                    {
                        product.Unstock(selectedItem, 1);
                        revenue.Value += selectedItemPrice;
                        Console.WriteLine("Vending, Thank you!");
                        if (revenue.InsertedCoins - selectedItemPrice != 0)
                            Console.WriteLine(string.Format("{0} coins returned", revenue.InsertedCoins - selectedItemPrice));
                        Console.WriteLine("Vending Machine Revenue: " + revenue.Value);

                        Console.WriteLine(product.Display());
                        revenue.InsertedCoins = 0;
                        break;
                    }
                    else
                        Console.WriteLine(string.Format("Insert {0} coins", selectedItemPrice - revenue.InsertedCoins));
                }
            }
        }
    }
}