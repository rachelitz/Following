using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("HotelService")]
public partial class HotelService
{
    [Key]
    public int HotelServiceCode { get; set; }

    [StringLength(50)]
    public string? HotelServiceName { get; set; }
}
