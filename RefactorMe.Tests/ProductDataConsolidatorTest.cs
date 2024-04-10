using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactorMe.Currency.Implementation;
using System.Linq;


namespace RefactorMe.Tests
{
    [TestClass]
    public class ProductDataConsolidatorTest
    {

        [TestMethod]
        public void AllProductsCount()
        {
            var currencyConverter = CurrencyConverterFactory.GetConverter("USDtoCNY");
            var products = new ProductDataConsolidator(currencyConverter).GetAllProducts();
            Assert.AreEqual(8, products.Count());
        }

        [TestMethod]
        public void AllProductsTypeTest()
        {
            var currencyConverter = CurrencyConverterFactory.GetConverter(string.Empty);
            var products = new ProductDataConsolidator(currencyConverter).GetAllProducts();
            Assert.AreEqual(ProductNameList.Lawnmower, products.FirstOrDefault(x => x.Name == "Hewlett-Packard Rideable Lawnmower").Type);
            Assert.AreEqual(ProductNameList.PhoneCase, products.FirstOrDefault(x => x.Name == "Amazon Fire Burgundy Phone Case").Type);
            Assert.AreEqual(ProductNameList.TShirt, products.FirstOrDefault(x => x.Name == "Disney Sleeping Beauty T-Shirt").Type);
        }

        [TestMethod]
        public void AllProductsPrice()
        {
            var products = new ProductDataConsolidator().GetAllProducts();
            Assert.AreEqual(3000.0, products.FirstOrDefault(x=> x.Name == "Hewlett-Packard Rideable Lawnmower").Price);
            Assert.AreEqual(14.0, products.FirstOrDefault(x => x.Name == "Amazon Fire Burgundy Phone Case").Price);
        }

        [TestMethod]
        public void AllProductsUSDPrice()
        {
            var currencyConverter = CurrencyConverterFactory.GetConverter(CurrencyConverterList.NZDToUSD);
            var products = new ProductDataConsolidator(currencyConverter).GetAllProducts();
            Assert.AreEqual(3000.0 * CurrencyConverterRateList.NZDToUSD, products.FirstOrDefault(x => x.Name == "Hewlett-Packard Rideable Lawnmower").Price);
            Assert.AreEqual(14.0 * CurrencyConverterRateList.NZDToUSD, products.FirstOrDefault(x => x.Name == "Amazon Fire Burgundy Phone Case").Price);
        }

        [TestMethod]
        public void AllProductsEuroPrice()
        {
            var currencyConverter = CurrencyConverterFactory.GetConverter(CurrencyConverterList.NZDToEUR);
            var products = new ProductDataConsolidator(currencyConverter).GetAllProducts();
            Assert.AreEqual(3000.0 * CurrencyConverterRateList.NZDToEUR, products.FirstOrDefault(x => x.Name == "Hewlett-Packard Rideable Lawnmower").Price);
            Assert.AreEqual(14.0 * CurrencyConverterRateList.NZDToEUR, products.FirstOrDefault(x => x.Name == "Amazon Fire Burgundy Phone Case").Price);
        }
    }
}
