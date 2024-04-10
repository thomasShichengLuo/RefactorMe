using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMe.Currency
{
    public interface ICurrencyConverter
    {
        double Convert(double amount);
    }
}
