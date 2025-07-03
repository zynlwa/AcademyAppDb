using AcademyApp.BL.Dtos;
using AcademyApp.BL.Dtos.Student;
using AcademyApp.Core.Entities;

namespace AcademyApp.BL.Profiles
{
    public class StudentProfile
    {
        public static Student StudentCreateDtoToStudent(StudentCreateDto studentCreateDto)
        {
            return new Student()
            {
                Name= studentCreateDto.Name,
                Surname= studentCreateDto.Surname,
                Email= studentCreateDto.Email,
                GroupId= studentCreateDto.GroupId
            };
        }
        public static StudentReturnDto StudentToStudentReturnDto(Student student)
        {
            return new StudentReturnDto()
            {
                Name = student.Name,
                Surname = student.Surname,
                Email = student.Email,
                GroupId = student.GroupId
            };
        }
        public static List<StudentReturnDto> StudentsToStudentReturnDto(List<Student> students)
        {
            var studenReturnDto= new List<StudentReturnDto>();
            foreach (var student in students)
            {
                studenReturnDto.Add(StudentToStudentReturnDto(student));

            }
            return studenReturnDto;
        }
    }
}
