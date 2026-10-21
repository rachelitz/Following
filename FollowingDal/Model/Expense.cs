using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("Expense")]
public partial class Expense
{
    [Key]
    public int ExpenseCode { get; set; }

    [StringLength(50)]
    public string? ExpenseType { get; set; }
}
