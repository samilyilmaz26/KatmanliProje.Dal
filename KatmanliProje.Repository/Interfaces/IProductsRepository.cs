using KatmanliProje.Core;
using KatmanliProje.Dto;
using KatmanliProje.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliProje.Repository.Interfaces
{
  public  interface IProductsRepository: IBaseRepository<Products>
    {
      //  ICollection<ProductsDTO> Doldur();
    }
}
