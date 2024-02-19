using Microsoft.EntityFrameworkCore;
using RestAPIcurso.Model;
using RestAPIcurso.Model.Base;
using RestAPIcurso.Model.Context;
using System;
using System.Collections.Generic;


namespace RestAPIcurso.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySQLContext _context;

        private DbSet<T> _dbSet;
        public GenericRepository(MySQLContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public List<T> FindAll()
        {
            return _dbSet.ToList();
        }
        public T FindById(long id)
        {
            return _dbSet.SingleOrDefault(p => p.Id.Equals(id));
        }
        public T Create(T item)
        {
            try
            {
                _dbSet.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public T Update(T item)
        {
            if (!Exists(item.Id)) return null;

            var result = _dbSet.SingleOrDefault(p => p.Id.Equals(item.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item.Id);
                    _context.SaveChanges();
                    
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return item;
        }

        public void Delete(long id)
        {
            var result = _dbSet.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _dbSet.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }

       

        

        
    }
}
