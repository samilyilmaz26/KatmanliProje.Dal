using KatmanliProje.Core;
using KatmanliProje.Dal;
using KatmanliProje.Entities;
using KatmanliProje.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliProje.Repository.Classes
{
    
   public class CategoriesRepository: BaseRepository<Categories> , ICategoriesRepository
    {
        public CategoriesRepository(SirketContext option):base(option)
        {
            
        }
        
    }
}
