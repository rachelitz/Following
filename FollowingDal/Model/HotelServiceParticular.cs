using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("HotelServiceParticular")]
public partial class HotelServiceParticular
{
    [Key]
    public int HotelServiceParticularCode { get; set; }

    public int? HotelCode { get; set; }

    public int? HotelServiceCode { get; set; }

    public int? Amount { get; set; }

    public double TariffGroup { get; set; }

    public double TariffSingle { get; set; }
}
