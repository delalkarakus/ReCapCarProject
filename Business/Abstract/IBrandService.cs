﻿
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand Get(int id);

        void Add(Brand brand);
        void Uptade(Brand brand);
        void Delete(Brand brand);
    }
}
