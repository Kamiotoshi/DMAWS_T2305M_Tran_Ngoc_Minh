using System.ComponentModel.DataAnnotations;

public class ProjectEmployee
{
    [Required]
    public int EmployeeId { get; set; }

    [Required]
    public int ProjectId { get; set; }

    [Required]
    [StringLength(500)]
    public string Tasks { get; set; }

    public virtual Employee Employees { get; set; }
    public virtual Project Projects { get; set; }
}
