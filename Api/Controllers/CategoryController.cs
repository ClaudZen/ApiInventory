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
    public class CategoryController : ControllerBase
    {
      

        private readonly ILogger<CategoryController> _logger;
        private readonly IRepositoryWrapper _repositoryWrapper ;

        public CategoryController(ILogger<CategoryController> logger, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            var model = _repositoryWrapper.Category.GetAllCategoriesByState(GeneralState.ENABLED);
            return model;
        }


    }
}
