using Api.Models.Category;
using AutoMapper;
using DataBase.Entities;


namespace Api.ProfilesAutoMapper
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryListViewModel>();
            CreateMap<Category, CategorySelectViewModel>();
        }
    }
}
