﻿using DataAccesLayer.Concrate.Repositorys;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IUserDal:IRepository<User>
    {
    }
}
