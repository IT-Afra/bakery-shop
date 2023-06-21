using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bakeryshop.Domain.Dtos;

namespace Bakeryshop.Domain.IRepositories
{
    public interface ISchaduleRepository
    {
        public List<SchaduleDetailDto> GetSchaduleByDate(DateTime dateTime);
        public List<SchaduleDetailDto> GetAll();
        public long Save(SchaduleDto schaduleDto);
        public void Delete(long SchaduleID);
    }
}
