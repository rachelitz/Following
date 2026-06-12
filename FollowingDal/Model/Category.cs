using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Category")]
public partial class Category
{
    [Key]
    public int CategoryCode { get; set; }

    [StringLength(50)]
    public string? CategoryName { get; set; }
}
