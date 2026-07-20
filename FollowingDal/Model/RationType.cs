using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("RationType")]
public partial class RationType
{
    [Key]
    public int RationTypeCode { get; set; }

    [StringLength(50)]
    public string? RationTypeName { get; set; }
}
