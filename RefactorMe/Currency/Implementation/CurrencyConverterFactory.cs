using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMe.Currency.Implementation
{
    public static class CurrencyConverterFactory
    {
        public static ICurrencyConverter GetConverter(string currency = null)
        {
            if (string.IsNullOrEmpty(currency))
            {
                return new DefaultConverter();
            }
            switch (currency.ToUpper())
            {
                case CurrencyConverterList.NZDToUSD:
                    return new NZDToUSDollarConverter();
                case CurrencyConverterList.NZDToEUR:
                    return new NZDToEuroConverter();
                default:
                    return new DefaultConverter();
            }
        }
    }

    public static class CurrencyConverterList
    {
        public const string NZDToUSD = "NZDTOUSD";

        public const string NZDToEUR = "NZDTOEUR";

    }


    public static class CurrencyConverterRateList
    {
        public const double NZDToUSD = 0.76;

        public const double NZDToEUR = 0.67;

    }
}
