using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Currency")]
public partial class Currency
{
    [Key]
    public int CurrencyCode { get; set; }

    [StringLength(50)]
    public string? CurrencyName { get; set; }

    public double? Value { get; set; }
}
