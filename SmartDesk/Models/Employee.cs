using System;
using System.Collections.Generic;

namespace SmartDesk.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public int RoleId { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<TicketStatusHistory> TicketStatusHistories { get; set; } = new List<TicketStatusHistory>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
