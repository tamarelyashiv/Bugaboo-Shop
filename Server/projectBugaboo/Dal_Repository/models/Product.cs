using System;
using System.Collections.Generic;

namespace Dal_Repository.models;

public partial class Product
{
    public int ProductId { get; set; }

    public string NameProduct { get; set; } = null!;

    public int? ModelId { get; set; }

    public int? CategoryId { get; set; }

    public string? Descriptions { get; set; }

    public int? Price { get; set; }

    public string? Picture { get; set; }

    public int? Quantity { get; set; }

    public DateTime? LastUpdate { get; set; }

    public virtual ICollection<BuyDetail> BuyDetails { get; } = new List<BuyDetail>();

    public virtual Category? Category { get; set; }

    public virtual Model? Model { get; set; }
}
