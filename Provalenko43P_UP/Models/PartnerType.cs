using System;
using System.Collections.Generic;

namespace Provalenko43P_UP.Models;

public partial class PartnerType
{
    public long Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
