namespace VendingMachine.Tests
{
    using System;
    using VendingMachine.ClassLibrary;
    using Xunit;
    using static VendingMachine.ClassLibrary.Types;

    public class ProductTests
    {
        private readonly Product _product;
        public ProductTests()
        {
            _product = new Product();
        }

        [Theory(DisplayName = "Successful Display Vending Products")]
        [InlineData(1, 2, 3, "6")]
        [InlineData(3, 0, 3, "6")]
        [InlineData(3, 0, 0, "3")]
        [InlineData(0, 0, 0, "0")]
        public void Test_Display_Vending_Products(int colas, int chips, int candies, string expected)
        {
            _product.Stock(colas, chips, candies);
            Assert.Contains(expected, _product.Display());
        }

        [Theory(DisplayName = "Successful Stock Inventory")]
        [InlineData(1, 2, 3, "6")]
        [InlineData(3, 0, 3, "6")]
        [InlineData(3, 0, 0, "3")]
        [InlineData(0, 0, 0, "0")]
        public void Test_Stock_Inventory(int colas, int chips, int candies, string expected)
        {
            _product.Stock(colas, chips, candies);
            var productCount = _product.MachineItems[(int)ItemType.Cola].Item3 + _product.MachineItems[(int)ItemType.Chips].Item3 + _product.MachineItems[(int)ItemType.Candy].Item3;
            Assert.Equal(Convert.ToDecimal(expected), productCount);
        }

        [Theory(DisplayName = "Successful Unstock Inventory")]
        [InlineData(ItemType.Candy, 2)]
        [InlineData(ItemType.Cola, 1)]
        [InlineData(ItemType.Chips, 0)]
        public void Test_Unstock_Inventory(ItemType item, int quantity)
        {
            _product.Stock(10, 9, 8);
            var beforeUpdateQuantity = _product.MachineItems[(int)item].Item3;
            _product.Unstock((int)item, quantity);
            Assert.Equal(_product.MachineItems[(int)item].Item3, beforeUpdateQuantity - quantity);
        }
    }
}