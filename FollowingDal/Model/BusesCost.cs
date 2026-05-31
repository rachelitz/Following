using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("BusesCost")]
public partial class BusesCost
{
    [Key]
    public int BusesCostCode { get; set; }

    public int BusCompanyCode { get; set; }

    public int? NumberSeats { get; set; }
}
