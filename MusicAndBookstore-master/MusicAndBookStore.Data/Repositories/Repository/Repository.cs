using Microsoft.EntityFrameworkCore;
using MusicAndBookStore.Data.Repositories.IRepository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndBookStore.Data.Repositories.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> _dbSet;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public bool Delete(int productId)
        {
            T entity = _dbSet.Find(productId);
            _context.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();  
        }
        public T GetById(int id)
        {
            T entity = _dbSet.Find(id);
            return entity;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
