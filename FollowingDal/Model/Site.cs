using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Site")]
public partial class Site
{
    [Key]
    public int SiteCode { get; set; }

    public int? CityCode { get; set; }

    public int? CountryCode { get; set; }

    [StringLength(50)]
    public string? HebrewSiteName { get; set; }

    [StringLength(50)]
    public string? EnglishSiteName { get; set; }

    public int? StayTime { get; set; }

    public double? Cost { get; set; }

    public double? PointX { get; set; }

    public double? PointY { get; set; }
}
