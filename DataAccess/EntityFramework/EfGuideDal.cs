﻿using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;

namespace DataAccess.Repository;

public class EfGuideDal : GenericRepository<Guide> , IGuideDal
{
    public EfGuideDal(Context context) : base(context)
    {
    }
}