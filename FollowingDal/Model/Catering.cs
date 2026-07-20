using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Catering")]
public partial class Catering
{
    [Key]
    public int CateringCode { get; set; }

    [StringLength(50)]
    public string? CateringName { get; set; }

    public int? CountryCode { get; set; }

    [StringLength(50)]
    public string? ContactName { get; set; }

    public int? Phone { get; set; }

    [StringLength(50)]
    public string? Mail { get; set; }
}
