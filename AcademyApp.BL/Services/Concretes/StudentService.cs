using AcademyApp.BL.Dtos;
using AcademyApp.BL.Dtos.Student;
using AcademyApp.BL.Profiles;
using AcademyApp.BL.Services.Interfaces;
using AcademyApp.Core.Entities;
using AcademyApp.DAL.Repositories.Concretes;
using AcademyApp.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace AcademyApp.BL.Services.Concretes
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _repository;
       

        public StudentService()
        {
            _repository = new Repository<Student>();
        }
        public void CreateStudent(StudentCreateDto studentCreateDto)
        {
            var student = StudentProfile.StudentCreateDtoToStudent(studentCreateDto);
            _repository.Add(student);

        }

        public void DeleteStudent(int id)
        {
            var student = _repository.GetById(id, isTracking:true);
            if (student == null) return;

            _repository.Delete(student);
            _repository.Savechanges();

        }

        public List<StudentReturnDto> GetAllStudents()
        {
            var students= StudentProfile.StudentsToStudentReturnDto(_repository.GetAll().ToList());
            return students;
        }

        public StudentReturnDto GetStudentById(int id)
        {
           
            var student = _repository.GetById(id, false, include =>
                        include.Include(s=>s.Group)
                );

            return StudentProfile.StudentToStudentReturnDto(student);
        }

    }
}
