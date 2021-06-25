namespace VendingMachine.ClassLibrary
{
    using System;
    using System.ComponentModel;

    public static class Types
    {
        public enum ItemType
        {
            Cola = 1, Chips = 2, Candy = 3
        }

        public enum CoinType
        {
            [Description("0.05")]
            Nickel,
            [Description("0.10")]
            Dime,
            [Description("0.25")]
            Quarter
        }
    }
}