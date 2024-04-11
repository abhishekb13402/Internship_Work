using AutoMapper;
using Mini_Project.Dto;
using Mini_Project.Models;
using System.Data;

namespace Mini_Project
{
    public class MappingConfiguration
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(configurationExpression =>
            {
                configurationExpression.CreateMap<User,UserDto>().ReverseMap();
                configurationExpression.CreateMap<TodoTask,TodoTaskDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
