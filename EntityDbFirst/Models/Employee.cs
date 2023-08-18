﻿using System;
using System.Collections.Generic;

namespace EntityDbFirst.Models;

public class Employee
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int Salary { get; set; } // Adjust this data type as needed
    public DateTime DateOfBirth { get; set; }
    public string Department { get; set; }
}
