using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAO;

public class CourseDAO()
{

    public List<Course> CourseList()
    {
        using AppDbContext context = new AppDbContext();
        var courses = context.Courses.ToList();
        if (courses != null)
        {
            Console.WriteLine("Ket noi thanh cong");

        }
        Console.WriteLine("khong thanh cong");
        return null;

    }
}
