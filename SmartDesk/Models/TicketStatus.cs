using System;
using System.Collections.Generic;

namespace SmartDesk.Models;

public partial class TicketStatus
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool? IsFinal { get; set; }

    public bool? IsCancelled { get; set; }

    public virtual ICollection<TicketStatusHistory> TicketStatusHistories { get; set; } = new List<TicketStatusHistory>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
