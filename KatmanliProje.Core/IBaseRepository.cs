using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliProje.Core
{
   public interface IBaseRepository<T> where T: class ,new()
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        DbSet<T> Set();

        Task< T> Find(int id);
    }
}
