using System;
using System.Collections.Generic;

namespace Provalenko43P_UP.Models;

public partial class ProductType
{
    public long Id { get; set; }

    public string Type { get; set; } = null!;

    public double? Coef { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
