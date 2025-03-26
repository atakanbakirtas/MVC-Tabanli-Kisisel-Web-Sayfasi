using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class SkilsManager:ISkillsService
    {
        ISkilssDal _iskillsdal;
        public SkilsManager(ISkilssDal iskillsdal)
        {
            _iskillsdal = iskillsdal;
        }

        public List<Skills> GetSkills()
        {
            return _iskillsdal.List();
        }
    }
}
