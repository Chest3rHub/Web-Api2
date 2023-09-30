using System.Diagnostics.CodeAnalysis;
using REST_API.Models;

namespace REST_API.Utils;

public class StudentCompareHandler : IEqualityComparer<Student>
{
    public bool Equals(Student x, Student y)
    {
           
        return StringComparer.CurrentCultureIgnoreCase.Equals($"{x.IdStudent}", $"{y.IdStudent}");
    }

    public int GetHashCode([DisallowNull] Student student)
    {
        return StringComparer.CurrentCultureIgnoreCase.GetHashCode($"{student.IdStudent}");
    }
}