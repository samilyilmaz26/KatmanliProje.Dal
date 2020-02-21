using KatmanliProje.Core;
using KatmanliProje.Dal;
using KatmanliProje.Entities;
using KatmanliProje.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliProje.Repository.Classes
{
  public  class ProductsRepository: BaseRepository<Products>,IProductsRepository
    {
        public ProductsRepository(SirketContext option):base(option)
        {

        }
    }
}
