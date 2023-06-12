

using Bakeryshop.Domain.Dtos;

namespace Bakeryshop.Domain.IRepositories
{
    public interface ITypeBreadRepository
    {
        public List<TypeBreadDto> GetAll();
        public void Update(TypeBreadDto objDto);
        public void Save(TypeBreadDto objDto);
        public void Delete(long id);

    }
}
