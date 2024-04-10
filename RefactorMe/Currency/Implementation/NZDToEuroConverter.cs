

namespace RefactorMe.Currency.Implementation
{
    public class NZDToEuroConverter : ICurrencyConverter
    {
        public double Convert(double amount) => amount * CurrencyConverterRateList.NZDToEUR;
    }
}
