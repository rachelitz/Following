using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Model;

[Table("ServiceCateringTariff")]
public partial class ServiceCateringTariff
{
    [Key]
    public int ServiceCateringTariffCode { get; set; }

    public int? CateringCode { get; set; }

    public int? MealTypeCode { get; set; }

    public double? TariffA { get; set; }

    public double? TariffB { get; set; }

    public double? TariffC { get; set; }

    public int? CurrencyCode { get; set; }
}
