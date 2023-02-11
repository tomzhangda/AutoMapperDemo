using AutoMapper;
using AutoMapperDemo.Models;
using AutoMapperDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper)
        {
            _logger = logger;
            this.mapper = mapper;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        public static List<Class > classes = new List<Class >()
        {
            new Class ()
            {
                Id = 1,
                Name = "t111"
            },
            new Class ()
            {
                Id = 2,
                Name = "ttt"
            }
        };

        

        public static List<Student> Students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Name = "lisi",
                Class =  classes[0],
            },
            new Student()
            {
                Id = 2,
                Name = "wangwu",
                Class =  classes[0],
            }
        };


        private IMapper mapper;

        [HttpGet("classes")]
        public async Task<ActionResult<ClassDto>> GetAllClasses()
        {
            return Ok(classes.Select(m => mapper.Map<ClassDto>(m)));
        }

      
        [HttpGet("students")]
        public async Task<ActionResult<StudentDto>> GetAllStudents()
        {
            return Ok(Students.Select(m => mapper.Map<StudentDto>(m)));
        }
    }
}