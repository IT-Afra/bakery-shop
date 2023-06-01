using AutoMapper;
using Bakeryshop.Infrastructure.EntityFramework;
using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Bakeryshop.Domain.Dtos;
using Bakeryshop.Domain.IRepositories;

namespace Bakeryshop.Infrastructure.Repositories
{
    public class TypeBreadRepository : ITypeBreadRepository
    {
        private BakershopContext dbContext { get; set; }
        private IMapper mapper { get; set; }

        public TypeBreadRepository()
        {
            dbContext = new BakershopContext();

            var config = new MapperConfiguration(cfg => 
                cfg.CreateMap<bksTypeBread, TypeBreadDto>().ReverseMap()
            );
            mapper = new Mapper(config);
        }
            
        public List<TypeBreadDto> GetAll()
        {
            return mapper.Map<List<TypeBreadDto>>( dbContext.bksTypeBreads.ToList());
        }

        public void Save(TypeBreadDto objDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
