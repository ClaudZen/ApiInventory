using DataBase;
using DataBase.Entities;
using Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Service.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext dBContext) : base(dBContext)
        {
        }


        public IEnumerable<Product> GetAllProductsByState(string state)
        {
            return _dBcotext.Products.Where(x => x.State.Equals(state)).ToList();
        }


    }
}
