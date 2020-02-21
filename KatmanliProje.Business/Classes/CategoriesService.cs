using KatmanliProje.Business.Interfaces;
using KatmanliProje.Dal;
using KatmanliProje.Dto;
using KatmanliProje.Repository.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using KatmanliProje.Repository.Interfaces;

namespace KatmanliProje.Business.Classes
{
    public class CategoriesService : ICategoriesService
    {
        ICategoriesRepository _catRepo;
        public CategoriesService(ICategoriesRepository catRepo)
        {
            _catRepo = catRepo;
        }
        public ICollection<CategoriesDTO> GetCategories()
        {
            return _catRepo.Set().Select(x => new CategoriesDTO
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            }).ToList();

        }

    }
}
