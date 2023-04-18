using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndBookStore.Data.Repositories.IRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        bool Delete(int productId);
        List<T> GetAll();
        T GetById(int id);
        void Save();
    }
}
