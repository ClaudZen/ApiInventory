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
using AutoMapper;
using Api.Models.Category;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
      

        private readonly ILogger<CategoryController> _logger;
        private readonly IRepositoryWrapper _repositoryWrapper ;
        private readonly IMapper _mapper;

        public CategoryController(ILogger<CategoryController> logger, 
            IRepositoryWrapper repositoryWrapper, 
            IMapper mapper)
        {
            _logger = logger;
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        [HttpGet("list")]
        public IEnumerable<CategoryListViewModel> GetList()
        {
            var result = _repositoryWrapper.Category.GetAllCategoriesByState(GeneralState.ENABLED);
            return _mapper.Map<IEnumerable<CategoryListViewModel>>(result) ;
        }


    }
}
