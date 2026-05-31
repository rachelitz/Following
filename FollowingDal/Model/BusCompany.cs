using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("BusCompany")]
public partial class BusCompany
{
    [Key]
    public int CompanyCode { get; set; }

    [StringLength(50)]
    public string? CompanyName { get; set; }

    public int? Phone { get; set; }

    public int? CountryCode { get; set; }

    public double? EmptyBusCost { get; set; }

    public double? ShabatCost { get; set; }

    public double? SecondDriverCost { get; set; }
}
