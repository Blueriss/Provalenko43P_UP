using System;
using System.Collections.Generic;

namespace Provalenko43P_UP.Models;

public partial class MaterialType
{
    public long Id { get; set; }

    public string Type { get; set; } = null!;

    public double? ProcentDefect { get; set; }
}
