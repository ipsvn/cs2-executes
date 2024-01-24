using CounterStrikeSharp.API.Core;
using ExecutesPlugin.Models;

namespace ExecutesPlugin.Managers
{
    public sealed class QueueManager : BaseManager
    {
        public readonly ExecutesQueue<CCSPlayerController> _queue = new();
    }
}