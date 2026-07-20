using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("GroupType")]
public partial class GroupType
{
    [Key]
    public int TypeGroupCode { get; set; }

    [StringLength(50)]
    public string? TypeGroupName { get; set; }
}
