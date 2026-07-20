using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Product")]
public partial class Product
{
    [Key]
    public int ProductCode { get; set; }

    public int? CategoryCode { get; set; }

    [StringLength(50)]
    public string? ProductName { get; set; }

    public bool? SingleOrGeneral { get; set; }

    public double? QuantityPerPerson { get; set; }

    public int? GoalCode { get; set; }
}
