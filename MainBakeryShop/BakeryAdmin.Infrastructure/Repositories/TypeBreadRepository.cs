using AutoMapper;
using Bakeryshop.Infrastructure.EntityFramework;
using Bakeryshop.Infrastructure.EntityFramework.Entities;
using BakeryAdmin.Domain.Dtos;
using BakeryAdmin.Domain.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace BakeryAdmin.Infrastructure.Repositories
{
    public class TypeBreadRepository : ITypeBreadRepository
    {
        private readonly BakeryshopContext _dbContext;
        private readonly IMapper _mapper;

        public TypeBreadRepository(BakeryshopContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
            
        public List<TypeBreadDto> GetAll()
        {
            return _mapper.Map<List<TypeBreadDto>>(_dbContext.bksTypeBreads.ToList());
        }

        public TypeBreadDto? Save(TypeBreadDto objDto)
        {
            var typeBread = _mapper.Map<bksTypeBread>(objDto);
            if (typeBread.Id == 0)
            {
                _dbContext.bksTypeBreads.Add(typeBread);
            }
            else 
            {
                _dbContext.bksTypeBreads.Update(typeBread);
            }
            
            _dbContext.SaveChanges();

            return _mapper.Map<TypeBreadDto?>(_dbContext.bksTypeBreads.Where(a=> a.Id == typeBread.Id).FirstOrDefault());
        }

        public void Delete(long id)
        {
            var typeBread = _dbContext.bksTypeBreads.Where(a=>a.Id == id).FirstOrDefault();
            if (typeBread != null) 
            {
                _dbContext.bksTypeBreads.Remove(typeBread);
                _dbContext.SaveChanges();
            }
        }
    }
}
