using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Status")]
public partial class Status
{
    [Key]
    public int StatusCode { get; set; }

    [StringLength(50)]
    public string? StatusName { get; set; }
}
