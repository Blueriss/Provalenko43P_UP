using System;
using System.Collections.Generic;

namespace Provalenko43P_UP.Models;

public partial class PartnerProduct
{
    public long Id { get; set; }

    public long? IdProduct { get; set; }

    public long? IdPartner { get; set; }

    public long? ProductCount { get; set; }

    public DateOnly? Date { get; set; }

    public virtual Partner? IdPartnerNavigation { get; set; }

    public virtual Product? IdProductNavigation { get; set; }
}
