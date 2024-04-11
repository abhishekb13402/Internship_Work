
using AutoMapper;
using AutoMapperExample.Dto;
using AutoMapperExample.Models;

public class MappingConfiguration
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(configurationExpression =>
        {
            configurationExpression.CreateMap<UserDto, User>().ReverseMap();

        });

        return mappingConfig;
    }

}