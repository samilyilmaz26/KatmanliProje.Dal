using KatmanliProje.Dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliProje.Core
{
  public  class BaseRepository<T> where T: class ,new()
    {
        private SirketContext _context;

        public BaseRepository(SirketContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChangesAsync();
        }

      

        public async Task <T> Find(int id)
        {
            System.Threading.Thread.Sleep(3000);
            return await _context.Set<T>().FindAsync(id);
            
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public DbSet<T> Set()
        {
            return _context.Set<T>();
        }
    }
}
