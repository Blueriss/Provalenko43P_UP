using System;
using System.Collections.Generic;

namespace Provalenko43P_UP.Models;

public partial class Product
{
    public long Id { get; set; }

    public string? Art { get; set; }

    public long? Type { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? MinCost { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public virtual ICollection<PartnerProduct> PartnerProducts { get; set; } = new List<PartnerProduct>();

    public virtual ProductType? TypeNavigation { get; set; }
}
