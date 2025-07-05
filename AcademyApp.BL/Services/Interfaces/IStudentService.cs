using AcademyApp.BL.Dtos;
using AcademyApp.BL.Dtos.Student;

namespace AcademyApp.BL.Services.Interfaces
{
    public interface IStudentService
    {
        void CreateStudent(StudentCreateDto studentCreateDto);
        List<StudentReturnDto> GetAllStudents();
        StudentReturnDto GetStudentById(int id);
        void DeleteStudent(int id);
       


    }
}
