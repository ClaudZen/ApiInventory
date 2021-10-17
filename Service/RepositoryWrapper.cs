using DataBase;
using Service.Interfaces;
using Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ApplicationContext _applicationCotext;
        private ICategoryRepository _categoryRepository;
        private IProductRepository _productRepository;

        public RepositoryWrapper(ApplicationContext applicationCotext)
        {
            _applicationCotext = applicationCotext;
        }

        public ICategoryRepository Category
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_applicationCotext);
                }

                return _categoryRepository;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_applicationCotext);
                }

                return _productRepository;
            }
        }

   

        public void Save()
        {
            _applicationCotext.SaveChanges();
        }
    }
}
