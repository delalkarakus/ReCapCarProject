﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public Brand Get(int id)
        {
            return _brandDal.Get(b => b.BrandId == id);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

      

        public void Uptade(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
