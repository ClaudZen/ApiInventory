using DataBase;
using DataBase.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service.Util;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
      

        private readonly ILogger<ProductController> _logger;
        private readonly IRepositoryWrapper _repositoryWrapper ;

        public ProductController(ILogger<ProductController> logger, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var model = _repositoryWrapper.Product.GetAllProductsByState(GeneralState.ENABLED);
            return model;
        }


    }
}
