using DataBase;
using DataBase.Entities;
using Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Service.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationContext dBContext) : base(dBContext)
        {
        }

        public IEnumerable<Category> GetAllCategoriesByState(string state)
        {
            return _dBcotext.Categories.Where(x => x.State.Equals(state)).ToList();
        }
    }
}
