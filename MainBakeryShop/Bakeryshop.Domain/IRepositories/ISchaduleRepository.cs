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
        public List<SchaduleDto> GetAll();
        public void Update(SchaduleDto objDto);
        public void Save(SchaduleDto objDto);
        public void Delete(long id);
    }
}
