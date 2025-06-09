using System;
using System.Collections.Generic;

namespace Dal_Repository.models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? NameCustomer { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? DateBirth { get; set; }

    public virtual ICollection<Buy> Buys { get; } = new List<Buy>();
}
