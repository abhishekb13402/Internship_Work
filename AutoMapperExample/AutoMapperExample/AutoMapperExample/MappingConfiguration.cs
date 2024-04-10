
using AutoMapper;

internal class MappingConfiguration
{
    internal static object RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(configurationExpression =>
        {
            configurationExpression.CreateMap<UserDto, User>().ReverseMap();
           
        });

        return mappingConfig;
    }
}