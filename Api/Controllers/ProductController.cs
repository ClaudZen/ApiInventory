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
using Api.Models.Product;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
      

        private readonly ILogger<ProductController> _logger;
        private readonly IRepositoryWrapper _repositoryWrapper ;
        private readonly IMapper _mapper;

        public ProductController(ILogger<ProductController> logger,
            IRepositoryWrapper repositoryWrapper,
            IMapper mapper)
        {
            _logger = logger;
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        [HttpGet("list")]
        public IEnumerable<ProductListViewModel> GetList()
        {
            var result = _repositoryWrapper.Product.GetAllProductsByState(GeneralState.ENABLED);
            return _mapper.Map<IEnumerable<ProductListViewModel>>(result);
        }


    }
}
