using DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IProductRepository:IRepositoryBase<Product>
    {
        public IEnumerable<Product> GetAllProductsByState(string state);
    }
}
