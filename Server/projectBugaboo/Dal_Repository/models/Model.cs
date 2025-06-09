using System;
using System.Collections.Generic;

namespace Dal_Repository.models;

public partial class Model
{
    public int ModelId { get; set; }

    public string NameModel { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
