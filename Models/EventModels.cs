using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models;

public sealed class EventItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public int SeatsLeft { get; set; }
}

public sealed class RegistrationModel
{
    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Range(0, 10)]
    public int GuestCount { get; set; } = 1;

    [Required]
    public string AttendanceType { get; set; } = "In Person";

    public string? SpecialNotes { get; set; }
}

public sealed class AttendeeRecord
{
    public int EventId { get; init; }
    public string FullName { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public int GuestCount { get; init; }
    public string AttendanceType { get; init; } = string.Empty;
    public string? SpecialNotes { get; init; }
    public DateTime RegisteredAt { get; init; } = DateTime.UtcNow;
}
