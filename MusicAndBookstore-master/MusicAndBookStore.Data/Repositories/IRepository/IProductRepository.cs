using MusicAndBookStore.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndBookStore.Data.Repositories.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        ArrayList GetAllProducts();
        int PurchaseProduct();
    }
}
