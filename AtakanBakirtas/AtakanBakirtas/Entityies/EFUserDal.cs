using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtakanBakirtas.Entityies
{
    public class EFUserDal:GenericRepository<User>,IUserDal
    {
    }
}