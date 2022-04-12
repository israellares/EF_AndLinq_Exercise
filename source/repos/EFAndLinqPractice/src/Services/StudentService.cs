using EFAndLinqPractice_SchoolAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace EFAndLinqPractice_SchoolAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolContext _dbContext;

        public StudentService(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Student Create(Student student)
        {
            _dbContext.Add(student);
            _dbContext.SaveChanges();
            int lastInsertedId = student.Id;
            return GetById(lastInsertedId);
        }

        public Student GetById(int id)
        {
          return  _dbContext.Students.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _dbContext.Students.ToList();
        }

        public IEnumerable<Student> GetStudentsByCourseId(int courseId)
        {
            return _dbContext.Courses.Where(x => x.Id == courseId).SelectMany(c => c.Students).ToList();
        }

        public void DeleteById(int id)
        {
            _dbContext.Remove(_dbContext.Students.Single(x => x.Id == id));
        }
    }
}