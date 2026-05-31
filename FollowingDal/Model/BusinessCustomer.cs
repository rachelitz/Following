using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("BusinessCustomer")]
public partial class BusinessCustomer
{
    [Key]
    public int CustomerCode { get; set; }

    [StringLength(50)]
    public string? CompanyName { get; set; }

    [StringLength(50)]
    public string? ContactName { get; set; }

    public int? Phone { get; set; }

    [StringLength(50)]
    public string? Mail { get; set; }
}
