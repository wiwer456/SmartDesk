using System;
using System.Collections.Generic;

namespace SmartDesk.Models;

public partial class Equipment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string SerialNumber { get; set; } = null!;

    public string? Model { get; set; }

    public int CustomerId { get; set; }

    public DateOnly? CommissioningDate { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
