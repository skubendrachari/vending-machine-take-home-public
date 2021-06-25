namespace VendingMachine.ClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using static global::VendingMachine.ClassLibrary.Types;

    public interface IProduct
    {
        public string Display();
        public void Stock(int colas, int chips, int candies);
        public void Unstock(int item, int quantity);
    }

    public class Product : IProduct
    {
        private Product instance;

        public Product GetInstance()
        {
            if (instance == null)
                instance = new Product();

            return instance;
        }

        private Dictionary<int, Tuple<ItemType, decimal, int>> machineItems; //key, Item, cost, quantity

        public Product() => machineItems = new Dictionary<int, Tuple<ItemType, decimal, int>>();

        public Dictionary<int, Tuple<ItemType, decimal, int>> MachineItems => machineItems;

        public void Stock(int colas, int chips, int candies) => machineItems = new Dictionary<int, Tuple<ItemType, decimal, int>>
            {
                {1, Tuple.Create(ItemType.Cola, (decimal)1.0, colas)},
                {2, Tuple.Create(ItemType.Candy, (decimal)0.65, chips)},
                {3, Tuple.Create(ItemType.Chips, (decimal)0.50, candies)}
            };

        public string Display()
        {
            var products = new StringBuilder();
            int total = 0;
            decimal revenue = 0;
            string formatString = "{0} \t {1} \t {2} \t {3}";
            products = products.AppendLine("# \t Item \t Price \t Quantity");

            foreach (var machineItem in machineItems)
            {
                products = machineItem.Value.Item1 switch
                {
                    ItemType.Cola => products.AppendLine(string.Format(formatString, machineItem.Key.ToString(), machineItem.Value.Item1, machineItem.Value.Item2, machineItem.Value.Item3)),
                    ItemType.Chips => products.AppendLine(string.Format(formatString, machineItem.Key.ToString(), machineItem.Value.Item1, machineItem.Value.Item2, machineItem.Value.Item3)),
                    ItemType.Candy => products.AppendLine(string.Format(formatString, machineItem.Key.ToString(), machineItem.Value.Item1, machineItem.Value.Item2, machineItem.Value.Item3)),
                    _ => products.AppendLine("No products"),
                };
                total += machineItem.Value.Item3;
                revenue += machineItem.Value.Item2 * machineItem.Value.Item3;
            }
            products = products.AppendLine("Total Items: " + total);
            products = products.AppendLine("Expected Revenue: " + revenue);
            return products.ToString();
        }

        public void Unstock(int item, int quantity)
        {
            machineItems[item] = Tuple.Create(machineItems[item].Item1, machineItems[item].Item2, machineItems[item].Item3 - quantity);
        }
    }
}