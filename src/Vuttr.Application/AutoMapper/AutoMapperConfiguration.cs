using AutoMapper;

namespace Vuttr.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(configuration =>
            {
                configuration.AddProfile<DomainToViewModelMappingProfile>();
                configuration.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}
