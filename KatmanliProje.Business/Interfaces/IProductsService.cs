using KatmanliProje.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliProje.Business.Interfaces
{
   public interface IProductsService
    {
        ICollection<ProductsDTO> GetProducts();
    }
}
