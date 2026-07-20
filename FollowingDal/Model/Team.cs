using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Team")]
public partial class Team
{
    [Key]
    public int EmployeeId { get; set; }

    [StringLength(50)]
    public string? HebrewFirstNameEmployee { get; set; }

    [StringLength(50)]
    public string? EnglishFirstNameEmployee { get; set; }

    [StringLength(50)]
    public string? HebrewLastNameEmployee { get; set; }

    [StringLength(50)]
    public string? EnglishLastNameEmployee { get; set; }

    public int? Phone { get; set; }

    [StringLength(50)]
    public string? Mail { get; set; }

    public int? RoleCode { get; set; }

    public int? CostToDay { get; set; }
}
