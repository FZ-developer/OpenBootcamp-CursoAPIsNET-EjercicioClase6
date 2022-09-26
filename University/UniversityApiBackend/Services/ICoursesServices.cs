using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.Services
{
    public interface ICoursesServices
    {

        IEnumerable<Course> GetCoursesWithConcreteCategory();

        IEnumerable<Course> GetCoursesWithNoChapters();

        IEnumerable<Course> GetCoursesFromAStudent();
    }
}
