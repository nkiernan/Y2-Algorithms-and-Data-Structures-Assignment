using System.Collections.Generic;

namespace CountriesAssignment
{
    class CountryTree : AVLTree<Country>
    {
        public List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();
            getCountries(root, countries);
            return countries;
        }

        private void getCountries(Node<Country> tree, List<Country> countries)
        {
            if (tree != null)
            {
                getCountries(tree.Left, countries);
                countries.Add(tree.Data);
                getCountries(tree.Right, countries);
            }
        }

        public CountryTree FindTradePartners(Country searchTerm)
        {
            CountryTree tradePartners = new CountryTree();
            foreach (string partner in searchTerm.MainTradePartners)
            {
                foreach (Country country in GetCountries())
                {
                    if (country.Name.Equals(partner))
                    {
                        tradePartners.InsertItem(country);
                    }
                    else if (country.MainTradePartners.Contains(searchTerm.Name) && !tradePartners.Contains(country))
                    {
                        tradePartners.InsertItem(country);
                    }
                }
            }
            return tradePartners;
        }

        public Country GetBiggestTradePotential()
        {
            Country biggestTradePotential = new Country();
            List<Country> allCountries = GetCountries();
            double sumOfPartnerGdp;
            double biggestPartnerGdpSum = 0;
            foreach (Country country in allCountries)
            {
                sumOfPartnerGdp = 0;
                
                foreach (Country partner in FindTradePartners(country).GetCountries())
                {
                    sumOfPartnerGdp += partner.GdpGrowth;
                }

                if (sumOfPartnerGdp > biggestPartnerGdpSum)
                {
                    biggestPartnerGdpSum = sumOfPartnerGdp;
                    biggestTradePotential = country;
                }
            }
            return biggestTradePotential;
        }
    }
}