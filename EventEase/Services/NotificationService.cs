// NotificationService.cs
public class NotificationService
{
    private readonly Dictionary<string, List<Func<string, Task>>> _handlers 
        = new Dictionary<string, List<Func<string, Task>>>();

    public void Subscribe(string channel, Func<string, Task> handler)
    {
        if (!_handlers.ContainsKey(channel))
        {
            _handlers[channel] = new List<Func<string, Task>>();
        }
        _handlers[channel].Add(handler);
    }

    public void Unsubscribe(string channel, Func<string, Task> handler)
    {
        if (_handlers.ContainsKey(channel))
        {
            _handlers[channel].Remove(handler);
        }
    }

    public async Task NotifyAsync(string channel, string message)
    {
        if (_handlers.ContainsKey(channel))
        {
            var handlers = new List<Func<string, Task>>(_handlers[channel]);
            foreach (var handler in handlers)
            {
                await handler(message);
            }
        }
    }
}