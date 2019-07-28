using System;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using FMPI.Marketing.Core.Models;

namespace FMPI.Marketing.Infrastructure
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private SMFargoContext _context = null;
        private DbSet<T> _table = null;

        public Repository(SMFargoContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetById(object id)
        {
            return _table.Find(id);
        }

        public void Insert(T obj)
        {

        }

        public void Update(T obj)
        {

        }

        public void Delete(object id)
        {
            
        }

        public void Save()
        {
            
        }
    }
}