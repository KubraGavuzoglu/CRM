namespace Sm.Crm.Application.Features.Notifications.Queries;

public class NotificationDto
{
    public Guid UserId { get; set; }
    public string? Title { get; set; }
    public string Description { get; set; } = null!;
    public bool IsRead { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid CreatedBy { get; set; }
}