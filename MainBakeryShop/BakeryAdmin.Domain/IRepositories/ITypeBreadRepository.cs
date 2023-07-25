using BakeryAdmin.Domain.Dtos;

namespace BakeryAdmin.Domain.IRepositories
{
    public interface ITypeBreadRepository
    {
        public List<TypeBreadDto> GetAll();
        public TypeBreadDto? Save(TypeBreadDto objDto);
        public void Delete(long id);

    }
}
