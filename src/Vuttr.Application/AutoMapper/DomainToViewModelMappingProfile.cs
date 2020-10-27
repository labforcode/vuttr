using AutoMapper;
using Vuttr.Application.ViewModels.Ferramentas;
using Vuttr.Application.ViewModels.Tags;
using Vuttr.Domain.Entities.Ferramentas;
using Vuttr.Domain.Entities.Tags;

namespace Vuttr.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Ferramenta, FerramentaViewModel>();
            CreateMap<Tag, TagViewModel>();
        }
    }
}
