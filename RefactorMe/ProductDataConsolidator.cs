using RefactorMe.Currency;
using RefactorMe.DontRefactor.Data.Implementation;
using RefactorMe.DontRefactor.Models;
using System.Collections.Generic;
using System.Linq;

namespace RefactorMe
{
    public class ProductDataConsolidator : IProductDataConsolidator
    {
        private readonly ICurrencyConverter _currencyConverter;

        public ProductDataConsolidator(ICurrencyConverter currencyConverter = null) 
        {
            _currencyConverter = currencyConverter;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>();
            products.AddRange(new LawnmowerRepository().GetAll().Select(p => new Product
            {
                Id = p.Id,
                Name = p.Name,
                Price = _currencyConverter != null ? _currencyConverter.Convert(p.Price) : p.Price,
                Type = ProductNameList.Lawnmower
            }).ToList());
            products.AddRange(new PhoneCaseRepository().GetAll().Select(p => new Product
            {
                Id = p.Id,
                Name = p.Name,
                Price = _currencyConverter != null ? _currencyConverter.Convert(p.Price) : p.Price,
                Type = ProductNameList.PhoneCase
            }).ToList());
            products.AddRange(new TShirtRepository().GetAll().Select(p => new Product
            {
                Id = p.Id,
                Name = p.Name,
                Price = _currencyConverter != null ? _currencyConverter.Convert(p.Price) : p.Price,
                Type = ProductNameList.TShirt
            }).ToList());
            return products;
        }

    }

}
