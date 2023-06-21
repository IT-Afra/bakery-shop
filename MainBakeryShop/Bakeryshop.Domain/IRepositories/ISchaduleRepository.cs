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
        public List<SchaduleDto> GetSchaduleByDate(string dateTime);
        public List<SchaduleDto> GetAll();
        public SchaduleDto Save(SchaduleDto schaduleDto);
        public void Delete(long Id);
    }
}
