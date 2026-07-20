using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Country")]
public partial class Country
{
    [Key]
    public int CountryCode { get; set; }

    [StringLength(50)]
    public string? CountryNameHebrew { get; set; }

    [StringLength(50)]
    public string? CountryNameEnglish { get; set; }
}
