

namespace RefactorMe.Currency.Implementation
{
    public class NZDToUSDollarConverter : ICurrencyConverter
    {
        public double Convert(double amount) => amount * CurrencyConverterRateList.NZDToUSD;
    }
}
