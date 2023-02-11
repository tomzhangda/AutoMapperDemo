namespace AutoMapperDemo.ViewModels
{
    public class ClassDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }

    public class StudentDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string ClassName { get; set; } = string.Empty;

        public int ClassId { get; set; }

        public string ClassStudentName { get; set; } = string.Empty;
    }


     
}
