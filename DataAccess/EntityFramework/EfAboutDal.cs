﻿using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;

namespace DataAccess.EntityFramework;

public class EfAboutDal: GenericRepository<About>, IAboutDal
{
   
}