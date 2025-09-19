using System.Threading;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces
{
    public interface IAiService
    {
        Task<string> GenerateChatResponseAsync(string message, string? userId, CancellationToken cancellationToken = default);
    }
}


