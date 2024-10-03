using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject.Models;

public class Course
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CourseID { get; set; } 

    public string? CourseName { get; set; }

    public decimal Rating { get; set; } 

    public override string ToString()
    {
        return $"{CourseID} - {CourseName}";
    }
}
