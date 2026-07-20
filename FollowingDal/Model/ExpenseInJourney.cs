using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("ExpenseInJourney")]
public partial class ExpenseInJourney
{
    [Key]
    public int ExpenseInJourneyCode { get; set; }

    public int? ExpenseCode { get; set; }

    public double? Cost { get; set; }

    public int? CurrencyCode { get; set; }

    public bool? SingleOrGroup { get; set; }
}
