using UniversityApiBackend.DataAccess;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.Services
{
    public class CoursesServices : ICoursesServices
    {
        private UniversityDBContext _context { get; set; }

        public CoursesServices(UniversityDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCoursesWithConcreteCategory()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesWithNoChapters()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesFromAStudent()
        {
            throw new NotImplementedException();
        }
    }
}
