using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Hotel")]
public partial class Hotel
{
    [Key]
    public int HotelCode { get; set; }

    [StringLength(50)]
    public string? HotelName { get; set; }

    public int? CityCode { get; set; }

    public bool? Certified { get; set; }

    [StringLength(50)]
    public string? Mail { get; set; }

    public int? Phone { get; set; }

    [StringLength(50)]
    public string? ContactName { get; set; }

    [Column(TypeName = "text")]
    public string Comment { get; set; } = null!;

    public double? PointX { get; set; }

    public double? PointY { get; set; }

    public int? Stars { get; set; }

    public bool? Location { get; set; }

    public int? RatingCode { get; set; }

    public int? PaymentCurrencyCode { get; set; }
}
