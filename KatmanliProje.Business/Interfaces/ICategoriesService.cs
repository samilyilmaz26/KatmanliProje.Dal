using KatmanliProje.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace KatmanliProje.Business.Interfaces
{
   public interface ICategoriesService
    {
        ICollection<CategoriesDTO> GetCategories();
    }
}
