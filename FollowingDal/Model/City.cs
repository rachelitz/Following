using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("City")]
public partial class City
{
    [Key]
    public int CityCode { get; set; }

    public int? CountryCode { get; set; }

    [StringLength(50)]
    public string? CityNameHebrew { get; set; }

    [StringLength(50)]
    public string? CityNameEnglish { get; set; }
}
