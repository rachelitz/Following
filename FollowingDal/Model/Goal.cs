using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Goal")]
public partial class Goal
{
    [Key]
    public int GoalCode { get; set; }

    [StringLength(50)]
    public string? GoalName { get; set; }
}
