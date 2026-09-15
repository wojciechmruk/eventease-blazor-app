using EventEaseApp.Models;

namespace EventEaseApp.Services;

public sealed class AttendanceService
{
    private readonly List<AttendeeRecord> _attendees = new();

    public IReadOnlyList<AttendeeRecord> Attendees => _attendees.AsReadOnly();

    public void AddAttendee(AttendeeRecord attendee)
    {
        ArgumentNullException.ThrowIfNull(attendee);
        _attendees.Add(attendee);
    }

    public int CountForEvent(int eventId)
    {
        return _attendees.Count(item => item.EventId == eventId);
    }

    public int TotalGuestsForEvent(int eventId)
    {
        return _attendees.Where(item => item.EventId == eventId).Sum(item => item.GuestCount + 1);
    }
}
