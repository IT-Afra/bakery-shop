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
        public long AddSchadule(SchaduleDto schaduleDto);
        public void EditSchadule(SchaduleDto schaduleDto);
        public void DeleteSchadule(long SchaduleID);
        public long AddSchaduleDetail(SchaduleDetailDto schaduleDetailDto);
        public void EditSchaduleDetail(SchaduleDetailDto schaduleDetailDto);
        public void DeleteSchaduleDetail(long SchaduleDetailID);
    }
}
