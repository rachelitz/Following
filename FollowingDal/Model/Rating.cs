using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Rating")]
public partial class Rating
{
    [Key]
    public int RatingCode { get; set; }

    [StringLength(50)]
    public string? RatingName { get; set; }
}
