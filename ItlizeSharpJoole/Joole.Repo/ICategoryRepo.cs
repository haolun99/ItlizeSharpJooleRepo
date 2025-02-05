﻿using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole.Repo
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetCategoryNames();
        Category GetCategory(int id);
    }
}
