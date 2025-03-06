using System;
using System.Collections.Generic;

namespace Provalenko43P_UP.Models;

public partial class Partner
{
    public long Id { get; set; }

    public long? Type { get; set; }

    public string? Address { get; set; }

    public string? Inn { get; set; }

    public string? Fio { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public long? Rating { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<PartnerProduct> PartnerProducts { get; set; } = new List<PartnerProduct>();

    public virtual PartnerType? TypeNavigation { get; set; }

    public string discount
    {
        get
        {
            long summ = 0;
            foreach (var item in PartnerProducts)
            {
                if (item.IdPartner == Id)
                {
                    summ += item.ProductCount.GetValueOrDefault();
                }
            }

            if (summ > 10000 && summ < 50000)
            {
                return "5%";
            }
            else if (summ > 50000 && summ < 300000)
            {
                return "10%";
            }
            else if (summ > 300000)
            {
                return "15%";
            }
            else
            {
                return "0%";
            }
        }
    }
}
