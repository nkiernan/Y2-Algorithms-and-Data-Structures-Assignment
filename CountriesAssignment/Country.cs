using System;
using System.Collections.Generic;

namespace CountriesAssignment
{
    class Country : IComparable
    {
        private string name;
        private double gdpGrowth;
        private double inflation;
        private double tradeBalance;
        private uint hdiRanking;
        private LinkedList<String> mainTradePartners;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double GdpGrowth
        {
            get { return gdpGrowth; }
            set { gdpGrowth = value; }
        }

        public double Inflation
        {
            get { return inflation; }
            set { inflation = value; }
        }

        public double TradeBalance
        {
            get { return tradeBalance; }
            set { tradeBalance = value; }
        }

        public uint HdiRanking
        {
            get { return hdiRanking; }
            set { hdiRanking = value; }
        }

        public LinkedList<String> MainTradePartners
        {
            get { return mainTradePartners; }
            set { mainTradePartners = value; }
        }

        public Country() { }

        public int CompareTo(object other)
        {
            Country temp = (Country)other;
            return name.CompareTo(temp.name);
        }
    }
}