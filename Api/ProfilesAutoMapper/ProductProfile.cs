using Api.Models.Product;
using AutoMapper;
using DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ProfilesAutoMapper
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductListViewModel>();
            CreateMap<Product, ProductSelectViewModel>();
        }
       
    }
}
