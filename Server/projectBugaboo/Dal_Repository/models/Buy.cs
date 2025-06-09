using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;

namespace Dal_Repository.models;

public partial class Buy
{
    public int BuyId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? BuyDate { get; set; }

    public int? Payment { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<BuyDetail> BuyDetails { get; } = new List<BuyDetail>();

    public virtual Customer? Customer { get; set; }

    public static explicit operator Buy(EntityEntry<Buy> v)
    {
        throw new NotImplementedException();
    }
}
