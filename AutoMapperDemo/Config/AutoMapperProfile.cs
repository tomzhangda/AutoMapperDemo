using AutoMapper;
using AutoMapperDemo.Models;
using AutoMapperDemo.ViewModels;

namespace AutoMapperDemo.Config
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Class, ClassDto>().ReverseMap();
            CreateMap<Student, StudentDto>()
                .ForMember(dest=> dest.ClassStudentName,
                    option=>option.MapFrom(source => source.Class.Name + "-" + source.Name 
                     ))
                .ReverseMap();
        }
    }
}
