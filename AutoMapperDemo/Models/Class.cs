using AutoMapper;
using AutoMapperDemo.ViewModels;

namespace AutoMapperDemo.Models
{
    public class Class
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;


    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Class? Class { get; set; }


    }

    
}
