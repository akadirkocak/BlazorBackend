﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult <Product> GetById(int productId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);

    }
}
