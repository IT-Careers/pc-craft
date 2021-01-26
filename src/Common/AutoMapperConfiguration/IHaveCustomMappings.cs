using AutoMapper;

namespace AutoMapperConfiguration
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfigurationExpression mapperConfig);
    }
}
