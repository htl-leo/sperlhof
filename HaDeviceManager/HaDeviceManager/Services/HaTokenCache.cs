namespace HaDeviceManager.Services;

public class HaTokenCache
{
    private string? _token;
    private DateTime _expiry = DateTime.MinValue;
    private readonly object _lock = new();

    public string? GetToken()
    {
        lock (_lock)
        {
            return _token != null && DateTime.UtcNow < _expiry ? _token : null;
        }
    }

    public void SetToken(string token)
    {
        lock (_lock)
        {
            _token = token;
            _expiry = DateTime.UtcNow.AddMinutes(25);
        }
    }

    public void Invalidate()
    {
        lock (_lock)
        {
            _token = null;
            _expiry = DateTime.MinValue;
        }
    }
}
