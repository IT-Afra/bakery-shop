using Bakeryshop.Domain.Dtos;
using Bakeryshop.Domain.IRepositories;
using AutoMapper;
using Bakeryshop.Infrastructure.EntityFramework;
using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bakeryshop.Infrastructure.Repositories
{
    public class SchaduleRepository : ISchaduleRepository
    {
        private readonly BakeryshopContext _dbContext;
        private readonly IMapper _mapper;

        public SchaduleRepository(BakeryshopContext dbContex , IMapper mapper)
        {
            _dbContext = dbContex;
            _mapper = mapper;
        }

        public List<SchaduleDto> GetAll()
        {
            return _mapper.Map<List<SchaduleDto>>(
                _dbContext.bksSchadules
                .Include(a => a.SchaduleDetails).ToList());
        }

        public List<SchaduleDto> GetSchaduleByDate(string dateTime)
        {
            return _mapper.Map<List<SchaduleDto>>(
               _dbContext.bksSchadules
               .Include(a => a.SchaduleDetails)
                .Where(a=> a.SchaduleDate == dateTime)
                .ToList());
        }

        public SchaduleDto Save(SchaduleDto objDto)
        {
            var SchaduleSave = _mapper.Map<bksSchadule>(objDto);
            if (SchaduleSave.Id == 0)
            {
                _dbContext.bksSchadules.Add(SchaduleSave);
            }
            else
            {
                _dbContext.bksSchadules.Update(SchaduleSave);
            }
            _dbContext.SaveChanges();

            return _mapper.Map<SchaduleDto>(_dbContext.bksSchadules
                    .Include(a => a.SchaduleDetails)
                        .Where(a => a.Id == SchaduleSave.Id));

        }
        public void Delete(long Id)
        {
            var SchaduleDel = _dbContext.bksSchadules
                .Where(a => a.Id == Id).FirstOrDefault();

            if (SchaduleDel != null)
            {
                _dbContext.bksSchadules.Remove(SchaduleDel);
                _dbContext.SaveChanges();
            }
        }
    }
}
