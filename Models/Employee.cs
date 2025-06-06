﻿using System;
using System.Collections.Generic;

namespace BT_NetcoreMVC.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
