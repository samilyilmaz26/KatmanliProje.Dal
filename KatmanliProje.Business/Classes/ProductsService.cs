using KatmanliProje.Business.Interfaces;
using KatmanliProje.Dto;
using KatmanliProje.Repository.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using KatmanliProje.Repository.Interfaces;

namespace KatmanliProje.Business.Classes
{
    public class ProductsService : IProductsService
    {
        IProductsRepository _proRepo;
        public ProductsService(IProductsRepository proRepo)
        {
            _proRepo = proRepo;
        }
        public ICollection<ProductsDTO> GetProducts()
        {
            return _proRepo.Set().Select(x => new ProductsDTO
            {
                 CategoryId = x.CategoryId,
                  ProductId = x.ProductId,
                  ProductName = x.ProductName
                   
            }).ToList();
        }
    }
}
