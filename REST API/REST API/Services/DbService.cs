using REST_API.Models;
using REST_API.Utils;

namespace REST_API.Services;

public class DbService : IDbService
{
    public void AddStudent(Student student)
    {
        var utils = new Utils.Utils();
        var u = utils.readFromFile();
        var students = new HashSet<Student>(new StudentCompareHandler());

        foreach (var s in u)
        {
            students.Add(s);
        }

        if (!students.Contains(student))
        {

            if (students.Add(student))
            {
                students.Add(student);
                    
            }
        }


        utils.SaveCollection(students);
    }
}