using System;
using System.Collections.Generic;

namespace EntityDbFirst.Models;

public partial class Employee
{
    
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public long Salary { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string Department { get; set; } = null!;
}
