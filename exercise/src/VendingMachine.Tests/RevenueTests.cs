namespace VendingMachine.Tests
{
    using System;
    using VendingMachine.ClassLibrary;
    using Xunit;
    using static VendingMachine.ClassLibrary.Types;

    public class RevenueTests
    {
        private readonly Revenue _revenue;
        public RevenueTests()
        {
            _revenue = new Revenue();
        }

        [Theory(DisplayName = "Successful Coin Acceptance")]
        [InlineData(CoinType.Quarter, "0.25")]
        [InlineData(CoinType.Dime, "0.10")]
        [InlineData(CoinType.Nickel, "0.05")]
        public void Test_Coin_Acceptance(CoinType coin, string expected)
        {
            _revenue.AcceptCoins(coin);
            Assert.Equal(Convert.ToDecimal(expected), _revenue.InsertedCoins);
        }

        [Fact(DisplayName = "Successful Multiple Coin Acceptance")]
        public void Test_MultipleCoin_Acceptance()
        {
            _revenue.AcceptCoins(CoinType.Quarter);
            _revenue.AcceptCoins(CoinType.Dime);
            _revenue.AcceptCoins(CoinType.Nickel);
            Assert.Equal(Convert.ToDecimal("0.40"), _revenue.InsertedCoins);
        }

        //[Fact]
        //public void Test_Coin_Acceptance_Pennies()
        //{
        //    var revenue = Revenue.GetInstance();
        //    revenue.AcceptCoins(coin);
        //    Assert.Equal(Convert.ToDecimal(expected), productCount);
        //}
    }
}