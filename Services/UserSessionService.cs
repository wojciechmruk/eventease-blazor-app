namespace EventEaseApp.Services;

public sealed class UserSessionService
{
    public string? CurrentUserName { get; private set; }

    public event Action? StateChanged;

    public void Login(string userName)
    {
        var value = userName.Trim();

        if (string.IsNullOrWhiteSpace(value))
        {
            return;
        }

        CurrentUserName = value;
        StateChanged?.Invoke();
    }

    public void Logout()
    {
        CurrentUserName = null;
        StateChanged?.Invoke();
    }
}
