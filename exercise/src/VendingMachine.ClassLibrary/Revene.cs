namespace VendingMachine.ClassLibrary
{
    using System;
    using static global::VendingMachine.ClassLibrary.Types;

    public interface IRevenue
    {
        public decimal AcceptCoins(CoinType coin);
    }

    public class Revenue : IRevenue
    {
        private Revenue instance;

        public Revenue GetInstance()
        {
            if (instance == null)
                instance = new Revenue();

            return instance;
        }
        public decimal InsertedCoins { get; set; }
        public decimal Value { get; set; }
        public decimal AcceptCoins(CoinType coin)
        {
            if (Enum.IsDefined(typeof(CoinType), coin))
            {
                switch (coin)
                {
                    case CoinType.Nickel:
                        InsertedCoins += (decimal).05;
                        break;
                    case CoinType.Dime:
                        InsertedCoins += (decimal).10;
                        break;
                    case CoinType.Quarter:
                        InsertedCoins += (decimal).25;
                        break;
                    default:
                        break;
                }
            }
            return InsertedCoins;
        }
    }
}