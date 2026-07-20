using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("ProductInMenu")]
public partial class ProductInMenu
{
    [Key]
    [Column("ProductInMenu")]
    public int ProductInMenu1 { get; set; }

    public int? SchedulingMealCode { get; set; }

    public int? ProductCode { get; set; }
}
