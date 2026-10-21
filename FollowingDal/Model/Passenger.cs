using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Passenger")]
public partial class Passenger
{
    [Key]
    public int PassengerId { get; set; }

    [StringLength(50)]
    public string? HebrewFirstNamePassenger { get; set; }

    [StringLength(50)]
    public string? EnglishFirstNamePassenger { get; set; }

    [StringLength(50)]
    public string? HebrewLastNamePassenger { get; set; }

    [StringLength(50)]
    public string? EnglishLastNamePassenger { get; set; }

    [StringLength(50)]
    public string? Mail { get; set; }

    public int? Phone { get; set; }

    public bool? Gender { get; set; }
}
