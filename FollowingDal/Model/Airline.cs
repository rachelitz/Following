using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Airline")]
public partial class Airline
{
    [Key]
    public int CompanyCode { get; set; }

    [StringLength(50)]
    public string? HebrewCompanyName { get; set; }

    [StringLength(50)]
    public string? EnglishCompanyName { get; set; }
}
