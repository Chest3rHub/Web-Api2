using REST_API.Models;

namespace REST_API.Services;

public interface IDbService
{
    public void AddStudent(Student student);
}