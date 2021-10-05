﻿using DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ICategoryRepository:IRepositoryBase<Category>
    {
        public IEnumerable<Category> GetAllCategoriesByState(string state);
    }
}
