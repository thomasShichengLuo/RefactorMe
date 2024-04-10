

namespace RefactorMe.Currency.Implementation
{
    public class DefaultConverter : ICurrencyConverter
    {
        public double Convert(double amount) => amount;
    }
}
